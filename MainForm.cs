using System.Reflection;
using Newtonsoft.Json;

namespace FigureForge
{
    public partial class MainForm : Form
    {
        private List<Shape> shapesCreated = [];
        private List<Shape> filteredShapes = [];

        private Stack<AppAction> undoStack = new();
        private Stack<AppAction> redoStack = new();

        private Dictionary<string, bool> ButtonsClicked = new()
        {
            {"Eraser", false },
            {"ColorPicker", false },
            {"ColorBucket", false },
            {"Rectangle", false },
            {"Triangle", false },
            {"Circle", false },
            {"Square", false },
            {"Pentagon", false },
        };
        private Color colorBucketColor = Color.Empty;
        private bool editPenScrollClicked = false;

        private Shape? selectedShape = null;
        private Color selectedMainBorderColor = Color.Black;
        private Color selectedMainFillColor = Color.Black;
        private int mainBorderThickness = 2;

        private PointF lastMouseClickPoint = PointF.Empty;
        private bool isMouseMoving = false;
        private PointF lastCenterPosition;

        private bool viewFilteringModeOn = false;
        private float prevMinArea = 0;
        private float prevMaxArea = 0;

        private bool isFileSaved = false;
        private string currentFilePath = "";

        // MainForm - Functionality
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ChangeEditTabs();

            // To remove the flickering in the panel, we use Reflection
            typeof(Control).InvokeMember("DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null, drawPanel, new object[] { true });
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("\tWelcome to FigureForge!\nWould you like to open an existing file?", "FigureForge", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) OpenFile();
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            RemoveSelectedShape();
            drawPanel.Refresh();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFileSaved)
            {
                DialogResult result = MessageBox.Show("File not saved. Do you want to save it?", "FigureForge", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if (currentFilePath == "") SaveFileAs();
                    else SaveFile();
                }
                else if (result == DialogResult.Cancel) e.Cancel = true;
            }
        }

        // General Methods
        private void RemoveOtherButtonsClicked(string buttonName = "")
        {
            foreach (string key in ButtonsClicked.Keys)
            {
                if (key == buttonName) continue;
                ButtonsClicked[key] = false;
            }
        }
        private void ChangeEditTabs()
        {
            if (selectedShape is null)
            {
                editHoverPanel.Visible = true;

                shapeNameLabel.Text = "Shape";
                editAreaSize.Text = "0";
                editMainSideLabel.Text = "Side";
                editMainSideBox.Text = "0";

                editSecondarySideLabel.Visible = false;
                editSecondarySideBox.Visible = false;
                editSecondarySideButton.Visible = false;
                editSecondarySideLabel.Text = "Side";
                editSecondarySideBox.Text = "0";

                editPenTextBox.Text = "0";
                editPenThicknessScroll.Value = mainBorderThickness;
            }
            else
            {
                editHoverPanel.Visible = false;
                shapeNameLabel.Text = selectedShape.GetType().Name;
                editAreaSize.Text = $"{selectedShape.Area()}";

                Line mainSide = selectedShape.GetMainSides()[0];
                editMainSideLabel.Text = mainSide.Name is null ? "Side" : mainSide.Name;
                editMainSideBox.Text = $"{mainSide.Length}";

                if (selectedShape is Rectangle)
                {
                    Line secondarySide = selectedShape.GetMainSides()[1];
                    editSecondarySideLabel.Text = secondarySide.Name;
                    editSecondarySideBox.Text = $"{secondarySide.Length}";
                    editSecondarySideLabel.Visible = true;
                    editSecondarySideBox.Visible = true;
                    editSecondarySideButton.Visible = true;
                }

                editFillColorButton.BackColor = selectedShape.ShapeFillColor == Color.Empty ? SystemColors.ControlLight : selectedShape.ShapeFillColor;
                editBorderColorButton.BackColor = selectedShape.ShapeBorderColor == Color.Empty ? SystemColors.ControlLight : selectedShape.ShapeBorderColor;

                editPenThicknessScroll.Value = selectedShape.ShapeBorderThickness;
                editPenTextBox.Text = $"{selectedShape.ShapeBorderThickness}";
            }
        }
        private void RemoveSelectedShape()
        {
            selectedShape = null;
            ChangeEditTabs();
        }
        private void RemoveAllOtherButtonsClickedAndShapeSelection(string buttonName = "")
        {
            RemoveSelectedShape();
            RemoveOtherButtonsClicked(buttonName);
            drawPanel.Refresh();
        }
        private void ClearFile()
        {
            shapesCreated.Clear();
            currentFilePath = "";
            selectedShape = null;
            undoStack.Clear();
            redoStack.Clear();
            ChangeEditTabs();
            historyViewBox.Items.Clear();
            historyViewBox.EndUpdate();

            drawPanel.Refresh();
        }
        private void AddActionToUndoStack(AppAction action)
        {
            undoStack.Push(action);
            historyViewBox.Items.Add(action.Name);
            historyViewBox.TopIndex = historyViewBox.Items.Count - 1;
            historyViewBox.EndUpdate();
            redoStack.Clear();
        }
        private void RemoveFilters()
        {
            filterGroupBox.Enabled = filterCheckBox.Checked;
            viewFilteringModeOn = filterGroupBox.Enabled;

            filterAreaMinTextBox.Text = "";
            filterAreaMaxTextBox.Text = "";
            filterShapesCheckedListBox.Items.Clear();
            filterFillColorCheckedListBox.Items.Clear();
            filterBorderColorCheckedListBox.Items.Clear();
            filteredShapes.Clear();

            toolsPanel.Enabled = !filterGroupBox.Enabled;
            shapesPanel.Enabled = !filterGroupBox.Enabled;
            editPanel.Enabled = !filterGroupBox.Enabled;
            editHoverPanel.Enabled = !filterGroupBox.Enabled;
            historyPanel.Enabled = !filterGroupBox.Enabled;
            undoButton.Enabled = !filterGroupBox.Enabled;
            redoButton.Enabled = !filterGroupBox.Enabled;
        }

        // Tools Panel - Functionality
        private void ClickUnclickButton(string buttonName)
        {
            ButtonsClicked[buttonName] ^= true;
            RemoveAllOtherButtonsClickedAndShapeSelection(buttonName);
        }
        private void SelectButton_Click(object sender, EventArgs e) => RemoveAllOtherButtonsClickedAndShapeSelection();
        private void EraserButton_Click(object sender, EventArgs e) => ClickUnclickButton("Eraser");
        private void ColorPickerButton_Click(object sender, EventArgs e) => ClickUnclickButton("ColorPicker");
        private void ColorPickerRemoveColorButton_Click(object sender, EventArgs e)
        {
            RemoveAllOtherButtonsClickedAndShapeSelection();
            colorPickerButton.BackColor = Color.Empty;
        }
        private void ColorBucketButton_Click(object sender, EventArgs e)
        {
            ClickUnclickButton("ColorBucket");

            if (ButtonsClicked["ColorBucket"])
            {
                if (mainColorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorBucketColor = mainColorDialog.Color;
                    colorBucketButton.BackColor = colorBucketColor;
                }
            }
        }
        private void ColorBucketRemoveColorButton_Click(object sender, EventArgs e)
        {
            RemoveAllOtherButtonsClickedAndShapeSelection();
            colorBucketColor = Color.Empty;
            colorBucketButton.BackColor = Color.Empty;
        }
        private void MainFillColorButton_Click(object sender, EventArgs e)
        {
            RemoveAllOtherButtonsClickedAndShapeSelection();

            if (mainColorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedMainFillColor = mainColorDialog.Color;
                mainFillColorButton.BackColor = selectedMainFillColor;
            }
        }
        private void MainFillColorRemoveColorButton_Click(object sender, EventArgs e)
        {
            RemoveAllOtherButtonsClickedAndShapeSelection();
            selectedMainFillColor = Color.Empty;
            mainFillColorButton.BackColor = Color.Empty;
        }
        private void MainBorderColorButton_Click(object sender, EventArgs e)
        {
            RemoveAllOtherButtonsClickedAndShapeSelection();

            if (mainColorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedMainBorderColor = mainColorDialog.Color;
                mainBorderColorButton.BackColor = selectedMainBorderColor;
            }
        }
        private void UpdateMainPenSize(int newPenSize)
        {
            mainBorderThickness = newPenSize;

            penSizeTrackBar.Value = newPenSize;
            penScrollToolTip.SetToolTip(penSizeTrackBar, penSizeTrackBar.Value.ToString());
            toolsPenTextBox.Text = $"{mainBorderThickness}";
            toolsPanel.Refresh();
        }
        private void ToolsPenButton_Click(object sender, EventArgs e)
        {
            string penInput = toolsPenTextBox.Text;

            if (int.TryParse(penInput, out int newPenSize))
            {
                if (newPenSize < 2 || newPenSize > 30)
                {
                    MessageBox.Show("Size must be between 2 and 30!");
                    toolsPenTextBox.Text = $"{mainBorderThickness}";
                }
                else UpdateMainPenSize(newPenSize);
            }
            else
            {
                MessageBox.Show("Size must be a number!");
                toolsPenTextBox.Text = $"{mainBorderThickness}";
            }
        }
        private void PenSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            int penInput = penSizeTrackBar.Value;
            UpdateMainPenSize(penInput);
        }

        // Shapes Panel - Buttons
        private void TriangleButton_Click(object sender, EventArgs e) => ClickUnclickButton("Triangle");
        private void RectangleButton_Click(object sender, EventArgs e) => ClickUnclickButton("Rectangle");
        private void CircleButton_Click(object sender, EventArgs e) => ClickUnclickButton("Circle");
        private void SquareButton_Click(object sender, EventArgs e) => ClickUnclickButton("Square");
        private void PentagonButton_Click(object sender, EventArgs e) => ClickUnclickButton("Pentagon");

        // Undo/Redo Buttons
        private void UndoAction()
        {
            isFileSaved = false;
            RemoveOtherButtonsClicked();
            RemoveSelectedShape();
            if (undoStack.Count > 0)
            {
                AppAction action = undoStack.Pop();
                action.Undo();
                redoStack.Push(action);

                historyViewBox.Items.RemoveAt(historyViewBox.Items.Count - 1);
                historyViewBox.TopIndex = historyViewBox.Items.Count - 1;
                historyViewBox.EndUpdate();

                drawPanel.Refresh();
            }
        }
        private void UndoButton_Click(object sender, EventArgs e) => UndoAction();
        private void RedoAction()
        {
            isFileSaved = false;

            RemoveOtherButtonsClicked();
            RemoveSelectedShape();
            if (redoStack.Count > 0)
            {
                AppAction action = redoStack.Pop();
                action.Do();
                undoStack.Push(action);

                historyViewBox.Items.Add(action.Name);
                historyViewBox.TopIndex = historyViewBox.Items.Count - 1;
                historyViewBox.EndUpdate();

                drawPanel.Refresh();
            }
        }
        private void RedoButton_Click(object sender, EventArgs e) => RedoAction();

        // DrawPanel - Functionality
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            isFileSaved = false;
            if (viewFilteringModeOn)
            {
                foreach (var shape in filteredShapes) shape.DrawOnMainStage(e.Graphics);
                return;
            }

            foreach (var shape in shapesCreated) shape.DrawOnMainStage(e.Graphics);

            selectedShape?.SelectionShapeGlow(e);

        }
        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (viewFilteringModeOn)
            {
                MessageBox.Show("Cannot edit the main stage when View Filtering mode is on!");
                return;
            }

            isFileSaved = false;
            lastMouseClickPoint = new PointF(e.X, e.Y);
            RemoveSelectedShape();

            if (e.Button == MouseButtons.Left)
            {
                Shape? newShape = null;
                if (ButtonsClicked["Rectangle"])
                    newShape = new Rectangle(e.Location, 50, 100, selectedMainFillColor, selectedMainBorderColor, mainBorderThickness);
                else if (ButtonsClicked["Triangle"])
                    newShape = new Triangle(e.Location, 100, selectedMainFillColor, selectedMainBorderColor, mainBorderThickness);
                else if (ButtonsClicked["Circle"])
                    newShape = new Circle(e.Location, 50, selectedMainFillColor, selectedMainBorderColor, mainBorderThickness);
                else if (ButtonsClicked["Square"])
                    newShape = new Square(e.Location, 50, selectedMainFillColor, selectedMainBorderColor, mainBorderThickness);
                else if (ButtonsClicked["Pentagon"])
                    newShape = new Pentagon(e.Location, 50, selectedMainFillColor, selectedMainBorderColor, mainBorderThickness);

                if (newShape is not null)
                {
                    AppActionAddShape appDraw = new(shapesCreated, newShape);
                    appDraw.Do();
                    AddActionToUndoStack(appDraw);
                    drawPanel.Refresh();
                    return;
                }
            }

            selectedShape = shapesCreated.LastOrDefault(x => x.ContainPoint(e.Location));
            if (selectedShape is not null)
            {
                lastCenterPosition = selectedShape.Center;

                if (ButtonsClicked["Eraser"])
                {
                    AppActionShapeDelete deleteShape = new(shapesCreated, selectedShape);
                    deleteShape.Do();
                    AddActionToUndoStack(deleteShape);
                    selectedShape = null;
                }
                else if (ButtonsClicked["ColorPicker"])
                {
                    selectedMainFillColor = selectedShape.ShapeFillColor;
                    mainFillColorButton.BackColor = selectedMainFillColor;
                    colorPickerButton.BackColor = selectedMainFillColor;
                }
                else if (ButtonsClicked["ColorBucket"])
                {
                    AppActionShapeFillColorChange colorChange = new(selectedShape, colorBucketColor);
                    colorChange.Do();
                    AddActionToUndoStack(colorChange);
                }
                else ChangeEditTabs();
            }
            else
            {
                if (ButtonsClicked["ColorPicker"])
                {
                    selectedMainFillColor = Color.Empty;
                    mainFillColorButton.BackColor = Color.Empty;
                    colorPickerButton.BackColor = Color.Empty;
                }
            }
        }
        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedShape != null && e.Button == MouseButtons.Right && e.Location != lastMouseClickPoint)
            {
                PointF newPosition = new(e.X, e.Y);
                AppActionShapeMove moveAction = new(selectedShape, selectedShape.Center, lastMouseClickPoint, newPosition);
                isMouseMoving = true;
                moveAction.Do();

                lastMouseClickPoint = newPosition;
                drawPanel.Refresh();
            }
        }
        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseMoving && selectedShape != null)
            {
                PointF newPosition = new(e.X, e.Y);
                AppActionShapeMove moveAction = new(selectedShape, lastCenterPosition, lastMouseClickPoint, newPosition);
                AddActionToUndoStack(moveAction);
            }

            isMouseMoving = false;
            drawPanel.Refresh();
        }

        // Edit Panel - Buttons & Functionality
        private void ChangeFillColor(Color color)
        {
            if (selectedShape is null) return;
            AppActionShapeFillColorChange colorAction = new(selectedShape, color);
            colorAction.Do();
            AddActionToUndoStack(colorAction);

            editFillColorButton.BackColor = color;
            drawPanel.Refresh();
        }
        private void EditFillColorButton_Click(object sender, EventArgs e)
        {
            if (mainColorDialog.ShowDialog() == DialogResult.OK) ChangeFillColor(mainColorDialog.Color);
        }
        private void EditFillColorNoColorButton_Click(object sender, EventArgs e) => ChangeFillColor(Color.Empty);
        private void EditBorderColorButton_Click(object sender, EventArgs e)
        {
            if (selectedShape is null) return;

            if (mainColorDialog.ShowDialog() == DialogResult.OK)
            {
                AppActionShapeBorderColorChange colorAction = new(selectedShape, mainColorDialog.Color);
                colorAction.Do();
                AddActionToUndoStack(colorAction);

                editBorderColorButton.BackColor = mainColorDialog.Color;
                drawPanel.Refresh();
            }
        }
        private void MoveOnePosition(string position)
        {
            if (selectedShape is not null)
            {
                int selectedShapeIndex = shapesCreated.IndexOf(selectedShape);
                AppActionShapePosition? moveAction = null;

                if (position == "UP" && selectedShapeIndex < shapesCreated.Count - 1) moveAction = new AppActionShapePosition(shapesCreated, selectedShape, position);
                else if (position == "DOWN" && selectedShapeIndex > 0) moveAction = new AppActionShapePosition(shapesCreated, selectedShape, position);

                if (moveAction is not null)
                {
                    moveAction.Do();
                    AddActionToUndoStack(moveAction);
                }
                drawPanel.Refresh();
            }
        }
        private void EditMoveUpButton_Click(object sender, EventArgs e) => MoveOnePosition("UP");
        private void EditMoveDownButton_Click(object sender, EventArgs e) => MoveOnePosition("DOWN");
        private void EditDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedShape is not null)
            {
                AppActionShapeDelete deleteAction = new(shapesCreated, selectedShape);
                deleteAction.Do();
                AddActionToUndoStack(deleteAction);
                RemoveAllOtherButtonsClickedAndShapeSelection();
            }
        }
        private void EditMainSideButton_Click(object sender, EventArgs e)
        {
            if (selectedShape is not null)
            {
                string sizeInput = editMainSideBox.Text;

                if (float.TryParse(sizeInput, out float size))
                {
                    if (size < 10)
                    {
                        MessageBox.Show("Size has to be at least 10!");
                        editMainSideBox.Text = $"{selectedShape.GetMainSides()[0].Length}";
                    }
                    else if (size == selectedShape.GetMainSides()[0].Length) return;
                    else
                    {
                        AppActionShapeSideSizeUpdate sizeAction = new(selectedShape, size, 0);
                        sizeAction.Do();
                        AddActionToUndoStack(sizeAction);

                        editAreaSize.Text = $"{selectedShape.Area()}";
                        drawPanel.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Size must be a number!");
                    editMainSideBox.Text = $"{selectedShape.GetMainSides()[0].Length}";
                }
            }
        }
        private void EditSecondarySideButton_Click(object sender, EventArgs e)
        {
            if (selectedShape is not null)
            {
                string sizeInput = editSecondarySideBox.Text;

                if (float.TryParse(sizeInput, out float size))
                {
                    if (size < 10)
                    {
                        MessageBox.Show("Size has to be at least 10!");
                        editSecondarySideBox.Text = $"{selectedShape.GetMainSides()[1].Length}";
                    }
                    else if (size == selectedShape.GetMainSides()[1].Length) return;
                    else
                    {
                        AppActionShapeSideSizeUpdate sizeAction = new(selectedShape, 0, size);
                        sizeAction.Do();
                        AddActionToUndoStack(sizeAction);

                        editAreaSize.Text = $"{selectedShape.Area()}";
                        drawPanel.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Size must be a number!");
                    editSecondarySideBox.Text = $"{selectedShape.GetMainSides()[1].Length}";
                }
            }
        }
        private void UpdateShapePenSize(int newPenSize)
        {
            if (selectedShape is not null)
            {
                AppActionShapePenThickness penThicknessUpdate = new(selectedShape, newPenSize);
                penThicknessUpdate.Do();
                AddActionToUndoStack(penThicknessUpdate);

                editPenThicknessScroll.Value = newPenSize;
                editPenScrollToolTip.SetToolTip(editPenThicknessScroll, editPenThicknessScroll.Value.ToString());
                editPenTextBox.Text = $"{newPenSize}";
                editPanel.Refresh();
                drawPanel.Refresh();
            }
        }
        private void EditPenButton_Click(object sender, EventArgs e)
        {
            if (selectedShape is null) return;
            string penInput = editPenTextBox.Text;

            if (int.TryParse(penInput, out int newPenSize))
            {
                if (newPenSize < 2 || newPenSize > 30)
                {
                    MessageBox.Show("Size must be between 2 and 30!");
                    editPenTextBox.Text = $"{selectedShape.ShapeBorderThickness}";
                }
                else UpdateShapePenSize(newPenSize);
            }
            else
            {
                MessageBox.Show("Size must be a number!");
                editPenTextBox.Text = $"{selectedShape.ShapeBorderThickness}";
            }
        }
        private void EditPenThicknessScroll_Scroll(object sender, EventArgs e)
        {
            editPenScrollClicked = true;
            editPenScrollToolTip.SetToolTip(editPenThicknessScroll, editPenThicknessScroll.Value.ToString());
        }
        private void EditPenThicknessScroll_MouseUp(object sender, MouseEventArgs e)
        {
            if (editPenScrollClicked)
            {
                editPenScrollClicked = false;
                UpdateShapePenSize(editPenThicknessScroll.Value);
            }
        }

        // View Filtering - Functionality
        private void AddItemsToSpecificCheckedListBox(CheckedListBox box, IEnumerable<string> items)
        {
            int currIndex = 0;

            foreach (string item in items)
            {
                box.Items.Add(item.ToString());
                box.SetItemChecked(currIndex, true);
                currIndex++;
            }
        }
        private void FilterCheckBox_Click(object sender, EventArgs e)
        {
            RemoveAllOtherButtonsClickedAndShapeSelection();
            if (shapesCreated.Count < 1)
            {
                filterCheckBox.Checked = false;
                MessageBox.Show("Create at least 1 shape in order to use View Filtering.");
                return;
            }

            RemoveFilters();

            if (filterGroupBox.Enabled)
            {
                filteredShapes = new List<Shape>(shapesCreated);

                var uniqueShapesNames = filteredShapes.Select(x => x.GetType().Name).Distinct();
                var uniqueShapeFillColors = filteredShapes.Select(x => x.ShapeFillColor.ToString()).Distinct();
                var uniqueShapeBorderColors = filteredShapes.Select(x => x.ShapeBorderColor.ToString()).Distinct();

                AddItemsToSpecificCheckedListBox(filterShapesCheckedListBox, uniqueShapesNames);
                AddItemsToSpecificCheckedListBox(filterFillColorCheckedListBox, uniqueShapeFillColors);
                AddItemsToSpecificCheckedListBox(filterBorderColorCheckedListBox, uniqueShapeBorderColors);

                var uniqueShapesAreas = filteredShapes.Select(x => x.Area());
                prevMinArea = uniqueShapesAreas.Min();
                prevMaxArea = uniqueShapesAreas.Max();

                filterAreaMinTextBox.Text = $"{prevMinArea}";
                filterAreaMaxTextBox.Text = $"{prevMaxArea}";
            }

            drawPanel.Refresh();
        }
        private void UpdateFilteredShapes()
        {
            float minArea = prevMinArea;
            float maxArea = prevMaxArea;

            filteredShapes = shapesCreated
                .Where(x => filterShapesCheckedListBox.CheckedItems.Contains(x.GetType().Name))
                .Where(x => x.Area() >= minArea && x.Area() <= maxArea)
                .Where(x => filterFillColorCheckedListBox.CheckedItems.Contains(x.ShapeFillColor.ToString()))
                .Where(x => filterBorderColorCheckedListBox.CheckedItems.Contains(x.ShapeBorderColor.ToString()))
                .ToList();

            prevMinArea = minArea;
            prevMaxArea = maxArea;

            drawPanel.Refresh();
        }
        private void FilterShapesCheckedListBox_MouseUp(object sender, MouseEventArgs e) => UpdateFilteredShapes();
        private void FilterFillColorCheckedListBox_MouseUp(object sender, MouseEventArgs e) => UpdateFilteredShapes();
        private void FilterBorderColorCheckedListBox_MouseUp(object sender, MouseEventArgs e) => UpdateFilteredShapes();
        private void FilterAreaMinButton_Click(object sender, EventArgs e)
        {
            string areaInput = filterAreaMinTextBox.Text;
            float minArea = shapesCreated.Select(x => x.Area()).Min();
            if (float.TryParse(areaInput, out float newArea))
            {
                if (newArea < minArea)
                {
                    MessageBox.Show($"Filter Area cannot be lower than the minimum area: {minArea}!");
                    filterAreaMinTextBox.Text = $"{prevMinArea}";
                }
                else
                {
                    prevMinArea = newArea;
                    UpdateFilteredShapes();
                }
            }
            else
            {
                MessageBox.Show("Filter Area must be a number!");
                filterAreaMinTextBox.Text = $"{prevMinArea}";
            }
        }
        private void FilterAreaMaxButton_Click(object sender, EventArgs e)
        {
            string areaInput = filterAreaMaxTextBox.Text;
            float maxArea = shapesCreated.Select(x => x.Area()).Max();
            if (float.TryParse(areaInput, out float newArea))
            {
                if (newArea > maxArea)
                {
                    MessageBox.Show($"Filter Area cannot be higher than the maximum area: {maxArea}!");
                    filterAreaMaxTextBox.Text = $"{prevMaxArea}";
                }
                else
                {
                    prevMaxArea = newArea;
                    UpdateFilteredShapes();
                }
            }
            else
            {
                MessageBox.Show("Filter Area must be a number!");
                filterAreaMaxTextBox.Text = $"{prevMaxArea}";
            }
        }
        private void FilteredShapesDeletion(AppAction deleteAction)
        {
            deleteAction.Do();
            AddActionToUndoStack(deleteAction);
            filterCheckBox.Checked = false;
            RemoveFilters();
            drawPanel.Refresh();
        }
        private void FilterDeleteSelectedButton_Click(object sender, EventArgs e) => FilteredShapesDeletion(new AppActionDeleteFilteredSelectedShapes(shapesCreated, filteredShapes));
        private void FilterDeleteElseButton_Click(object sender, EventArgs e) => FilteredShapesDeletion(new AppActionDeleteFilteredNonSelectedShapes(shapesCreated, filteredShapes));

        // ToolStripItemsClicks
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFileSaved)
            {
                DialogResult result = MessageBox.Show("File not saved. Do you want to save it?", "FigureForge", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if (currentFilePath == "") SaveFileAs();
                    else SaveFile();
                }
                else if (result == DialogResult.Cancel || result == 0) return;
            }

            filterCheckBox.Checked = false;
            RemoveFilters();
            ClearFile();
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAllOtherButtonsClickedAndShapeSelection();
            ChangeEditTabs();
            filterCheckBox.Checked = false;
            RemoveFilters();

            if (!isFileSaved)
            {
                DialogResult result = MessageBox.Show("File not saved. Do you want to save it?", "FigureForge", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if (currentFilePath == "") SaveFileAs();
                    else SaveFile();
                }
                else if (result == DialogResult.Cancel) return;
            }

            OpenFile();
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) => SaveFileAs();
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath == "") SaveFileAs();
            else SaveFile();
        }

        // Serialization & Deserialization
        private void SerializatingFile(string filePath)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            string jsonString = JsonConvert.SerializeObject(shapesCreated, settings);

            using var writer = new StreamWriter(filePath);
            writer.Write(jsonString);
            isFileSaved = true;
        }
        private void SaveFileAs()
        {
            using (mainSaveFileDialog)
            {
                mainSaveFileDialog.FileName = "";
                mainSaveFileDialog.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
                mainSaveFileDialog.DefaultExt = "json";

                if (mainSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = mainSaveFileDialog.FileName;
                    SerializatingFile(filePath);
                    currentFilePath = filePath;
                }
            }
        }
        private void SaveFile()
        {
            if (!File.Exists(currentFilePath))
            {
                var file = File.Open(currentFilePath, FileMode.Create);
                file.Close();
            }
            using (var file = File.Open(currentFilePath, FileMode.Truncate)) ;
            SerializatingFile(currentFilePath);
        }
        private void OpenFile()
        {
            using (mainOpenFileDialog)
            {
                mainOpenFileDialog.FileName = "";
                mainOpenFileDialog.Filter = "Json Files (*.json)|*.json";

                if (mainOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = mainOpenFileDialog.FileName;

                    try
                    {
                        string jsonContent = File.ReadAllText(filePath);

                        try
                        {
                            var settings = new JsonSerializerSettings { Converters = { new ShapeConverter() }, MissingMemberHandling = MissingMemberHandling.Error };
                            List<Shape>? shapes = JsonConvert.DeserializeObject<List<Shape>>(jsonContent, settings);

                            if (shapes is null) shapesCreated = [];
                            else shapesCreated = new(shapes);

                            foreach (Shape shape in shapesCreated) shape.InitializePointsAndSides();

                            currentFilePath = filePath;
                            drawPanel.Refresh();
                            isFileSaved = true;
                        }
                        catch (Exception ex) when (ex is JsonReaderException || ex is JsonSerializationException)
                        {
                            MessageBox.Show($"Opening file failed.\n{ex.Message}");
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show($"File not found: {filePath}");
                    }
                }
            }
        }
    }
}
