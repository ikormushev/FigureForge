namespace FigureForge
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            fileMenu = new MenuStrip();
            fileToolStripMenu = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparatorBeforeSaveAs = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparatorBeforeExit = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            rectangleButton = new Button();
            editFillColorButton = new Button();
            triangleButton = new Button();
            selectButton = new Button();
            mainFillColorButton = new Button();
            mainColorDialog = new ColorDialog();
            circleButton = new Button();
            squareButton = new Button();
            pentagonButton = new Button();
            drawPanel = new Panel();
            editSecondarySideButton = new Button();
            editSecondarySideBox = new TextBox();
            editSecondarySideLabel = new Label();
            editMainSideButton = new Button();
            editMainSideBox = new TextBox();
            editMainSideLabel = new Label();
            editAreaSize = new Label();
            editAreaLabel = new Label();
            editDeleteButton = new Button();
            editHoverTextLabel = new Label();
            editBorderColorButton = new Button();
            editMoveUpButton = new Button();
            editMoveDownButton = new Button();
            shapeNameLabel = new Label();
            mainBorderColorButton = new Button();
            undoButton = new Button();
            redoButton = new Button();
            historyViewBox = new ListBox();
            historyLabel = new Label();
            shapesPanel = new Panel();
            shapesPanelLabel = new Label();
            toolsPanel = new Panel();
            mainFillColorRemoveColorButton = new Button();
            colorBucketRemoveColorButton = new Button();
            colorPickerRemoveColorButton = new Button();
            colorBucketButton = new Button();
            colorPickerButton = new Button();
            toolsFillLabel = new Label();
            toolsBorderLabel = new Label();
            eraserButton = new Button();
            penSizeTrackBar = new TrackBar();
            toolsPenButton = new Button();
            toolsPenTextBox = new TextBox();
            toolsPenLabel = new Label();
            toolsLabel = new Label();
            historyPanel = new Panel();
            penScrollToolTip = new ToolTip(components);
            editPanel = new Panel();
            editHoverPanel = new Panel();
            editFillColorNoColorButton = new Button();
            editPositionDownLabel = new Label();
            editPositionUpLabel = new Label();
            editPositionLabel = new Label();
            editPenTextBox = new TextBox();
            editPenButton = new Button();
            editPenThicknessScroll = new TrackBar();
            editPenLabel = new Label();
            editFillLabel = new Label();
            editBorderLabel = new Label();
            editPenScrollToolTip = new ToolTip(components);
            rectangleToolTip = new ToolTip(components);
            shapeFillColorToolTip = new ToolTip(components);
            triangleToolTip = new ToolTip(components);
            selectToolTip = new ToolTip(components);
            mainFillColorToolTip = new ToolTip(components);
            circleToolTip = new ToolTip(components);
            squareToolTip = new ToolTip(components);
            pentagonToolTip = new ToolTip(components);
            deleteToolTip = new ToolTip(components);
            moveUpToolTip = new ToolTip(components);
            moveDownToolTip = new ToolTip(components);
            mainBorderColorToolTip = new ToolTip(components);
            undoToolTip = new ToolTip(components);
            redoToolTip = new ToolTip(components);
            editBorderColorToolTip = new ToolTip(components);
            colorPickerToolTip = new ToolTip(components);
            eraserToolTip = new ToolTip(components);
            filterPanel = new Panel();
            filterGroupBox = new GroupBox();
            filterDeleteElseButton = new Button();
            filterDeleteSelectedButton = new Button();
            label1 = new Label();
            filterBorderColorCheckedListBox = new CheckedListBox();
            filterAreaPanel = new Panel();
            filterAreaMaxButton = new Button();
            filterAreaMinButton = new Button();
            filterAreaMaxTextBox = new TextBox();
            filterAreaMinTextBox = new TextBox();
            filterAreaMinLabel = new Label();
            filterAreaMaxLabel = new Label();
            filterAreaLabel = new Label();
            filterFillColorCheckedListBox = new CheckedListBox();
            filterFillColorLabel = new Label();
            filterShapesCheckedListBox = new CheckedListBox();
            filterShapesLabel = new Label();
            filterCheckBox = new CheckBox();
            filterLabel = new Label();
            mainSaveFileDialog = new SaveFileDialog();
            mainOpenFileDialog = new OpenFileDialog();
            colorBucketToolTip = new ToolTip(components);
            mainFillColorRemoveColorToolTip = new ToolTip(components);
            colorBucketRemoveColorToolTip = new ToolTip(components);
            colorPickerRemoveColorToolTip = new ToolTip(components);
            editFillColorNoColorToolTip = new ToolTip(components);
            fileMenu.SuspendLayout();
            shapesPanel.SuspendLayout();
            toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).BeginInit();
            historyPanel.SuspendLayout();
            editPanel.SuspendLayout();
            editHoverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editPenThicknessScroll).BeginInit();
            filterPanel.SuspendLayout();
            filterGroupBox.SuspendLayout();
            filterAreaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // fileMenu
            // 
            fileMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenu });
            fileMenu.Location = new Point(0, 0);
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(1902, 28);
            fileMenu.TabIndex = 0;
            fileMenu.Text = "fileMenu";
            // 
            // fileToolStripMenu
            // 
            fileToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { newFileToolStripMenuItem, openToolStripMenuItem, toolStripSeparatorBeforeSaveAs, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparatorBeforeExit, exitToolStripMenuItem });
            fileToolStripMenu.Name = "fileToolStripMenu";
            fileToolStripMenu.Size = new Size(44, 24);
            fileToolStripMenu.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.Size = new Size(129, 24);
            newFileToolStripMenuItem.Text = "&New";
            newFileToolStripMenuItem.Click += NewFileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(129, 24);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparatorBeforeSaveAs
            // 
            toolStripSeparatorBeforeSaveAs.Name = "toolStripSeparatorBeforeSaveAs";
            toolStripSeparatorBeforeSaveAs.Size = new Size(126, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(129, 24);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(129, 24);
            saveAsToolStripMenuItem.Text = "Save &As";
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparatorBeforeExit
            // 
            toolStripSeparatorBeforeExit.Name = "toolStripSeparatorBeforeExit";
            toolStripSeparatorBeforeExit.Size = new Size(126, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(129, 24);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // rectangleButton
            // 
            rectangleButton.BackgroundImage = (Image)resources.GetObject("rectangleButton.BackgroundImage");
            rectangleButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rectangleButton.Location = new Point(16, 48);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(100, 55);
            rectangleButton.TabIndex = 2;
            rectangleToolTip.SetToolTip(rectangleButton, "Click here to enable creating Rectangles on the main stage with LEFT mouse click.");
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += RectangleButton_Click;
            // 
            // editFillColorButton
            // 
            editFillColorButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editFillColorButton.Location = new Point(179, 199);
            editFillColorButton.Name = "editFillColorButton";
            editFillColorButton.Size = new Size(50, 50);
            editFillColorButton.TabIndex = 0;
            shapeFillColorToolTip.SetToolTip(editFillColorButton, "Click here to change the Fill Color for the current shape.");
            editFillColorButton.UseVisualStyleBackColor = true;
            editFillColorButton.Click += EditFillColorButton_Click;
            // 
            // triangleButton
            // 
            triangleButton.BackgroundImage = (Image)resources.GetObject("triangleButton.BackgroundImage");
            triangleButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            triangleButton.Location = new Point(197, 48);
            triangleButton.Name = "triangleButton";
            triangleButton.Size = new Size(55, 55);
            triangleButton.TabIndex = 4;
            triangleToolTip.SetToolTip(triangleButton, "Click here to enable creating Triangles on the main stage with LEFT mouse click.");
            triangleButton.UseVisualStyleBackColor = true;
            triangleButton.Click += TriangleButton_Click;
            // 
            // selectButton
            // 
            selectButton.Image = (Image)resources.GetObject("selectButton.Image");
            selectButton.Location = new Point(12, 55);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(50, 50);
            selectButton.TabIndex = 1;
            selectToolTip.SetToolTip(selectButton, "Click here to remove any other button clicked.");
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += SelectButton_Click;
            // 
            // mainFillColorButton
            // 
            mainFillColorButton.BackColor = Color.Black;
            mainFillColorButton.Location = new Point(146, 148);
            mainFillColorButton.Name = "mainFillColorButton";
            mainFillColorButton.Size = new Size(50, 50);
            mainFillColorButton.TabIndex = 6;
            mainFillColorToolTip.SetToolTip(mainFillColorButton, "Click here to change the Main Fill Color for any following shape.");
            mainFillColorButton.UseVisualStyleBackColor = false;
            mainFillColorButton.Click += MainFillColorButton_Click;
            // 
            // circleButton
            // 
            circleButton.BackgroundImage = (Image)resources.GetObject("circleButton.BackgroundImage");
            circleButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            circleButton.Location = new Point(61, 116);
            circleButton.Name = "circleButton";
            circleButton.Size = new Size(55, 55);
            circleButton.TabIndex = 5;
            circleToolTip.SetToolTip(circleButton, "Click here to enable creating Circles on the main stage with LEFT mouse click.");
            circleButton.UseVisualStyleBackColor = true;
            circleButton.Click += CircleButton_Click;
            // 
            // squareButton
            // 
            squareButton.BackgroundImage = (Image)resources.GetObject("squareButton.BackgroundImage");
            squareButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            squareButton.Location = new Point(128, 48);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(55, 55);
            squareButton.TabIndex = 3;
            squareToolTip.SetToolTip(squareButton, "Click here to enable creating Squares on the main stage with LEFT mouse click.");
            squareButton.UseVisualStyleBackColor = true;
            squareButton.Click += SquareButton_Click;
            // 
            // pentagonButton
            // 
            pentagonButton.BackgroundImage = (Image)resources.GetObject("pentagonButton.BackgroundImage");
            pentagonButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pentagonButton.Location = new Point(155, 116);
            pentagonButton.Name = "pentagonButton";
            pentagonButton.Size = new Size(55, 55);
            pentagonButton.TabIndex = 9;
            pentagonToolTip.SetToolTip(pentagonButton, "Click here to enable creating Pentagons on the main stage with LEFT mouse click.");
            pentagonButton.UseVisualStyleBackColor = true;
            pentagonButton.Click += PentagonButton_Click;
            // 
            // drawPanel
            // 
            drawPanel.BackColor = SystemColors.ControlLightLight;
            drawPanel.BorderStyle = BorderStyle.FixedSingle;
            drawPanel.Location = new Point(347, 66);
            drawPanel.Name = "drawPanel";
            drawPanel.Size = new Size(1169, 921);
            drawPanel.TabIndex = 10;
            drawPanel.Paint += DrawPanel_Paint;
            drawPanel.MouseDown += DrawPanel_MouseDown;
            drawPanel.MouseMove += DrawPanel_MouseMove;
            drawPanel.MouseUp += DrawPanel_MouseUp;
            // 
            // editSecondarySideButton
            // 
            editSecondarySideButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editSecondarySideButton.Location = new Point(235, 136);
            editSecondarySideButton.Name = "editSecondarySideButton";
            editSecondarySideButton.Size = new Size(47, 23);
            editSecondarySideButton.TabIndex = 12;
            editSecondarySideButton.Text = "Apply";
            editSecondarySideButton.UseVisualStyleBackColor = true;
            editSecondarySideButton.Click += EditSecondarySideButton_Click;
            // 
            // editSecondarySideBox
            // 
            editSecondarySideBox.Location = new Point(155, 136);
            editSecondarySideBox.Name = "editSecondarySideBox";
            editSecondarySideBox.Size = new Size(74, 23);
            editSecondarySideBox.TabIndex = 11;
            // 
            // editSecondarySideLabel
            // 
            editSecondarySideLabel.AutoSize = true;
            editSecondarySideLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSecondarySideLabel.Location = new Point(155, 112);
            editSecondarySideLabel.Name = "editSecondarySideLabel";
            editSecondarySideLabel.Size = new Size(42, 21);
            editSecondarySideLabel.TabIndex = 10;
            editSecondarySideLabel.Text = "Side";
            // 
            // editMainSideButton
            // 
            editMainSideButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editMainSideButton.Location = new Point(93, 136);
            editMainSideButton.Name = "editMainSideButton";
            editMainSideButton.Size = new Size(47, 23);
            editMainSideButton.TabIndex = 9;
            editMainSideButton.Text = "Apply";
            editMainSideButton.UseVisualStyleBackColor = true;
            editMainSideButton.Click += EditMainSideButton_Click;
            // 
            // editMainSideBox
            // 
            editMainSideBox.Location = new Point(13, 136);
            editMainSideBox.Name = "editMainSideBox";
            editMainSideBox.Size = new Size(74, 23);
            editMainSideBox.TabIndex = 8;
            // 
            // editMainSideLabel
            // 
            editMainSideLabel.AutoSize = true;
            editMainSideLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editMainSideLabel.Location = new Point(11, 112);
            editMainSideLabel.Name = "editMainSideLabel";
            editMainSideLabel.Size = new Size(42, 21);
            editMainSideLabel.TabIndex = 7;
            editMainSideLabel.Text = "Side";
            // 
            // editAreaSize
            // 
            editAreaSize.AutoSize = true;
            editAreaSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editAreaSize.Location = new Point(70, 66);
            editAreaSize.Name = "editAreaSize";
            editAreaSize.Size = new Size(22, 25);
            editAreaSize.TabIndex = 6;
            editAreaSize.Text = "0";
            // 
            // editAreaLabel
            // 
            editAreaLabel.AutoSize = true;
            editAreaLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editAreaLabel.Location = new Point(11, 66);
            editAreaLabel.Name = "editAreaLabel";
            editAreaLabel.Size = new Size(52, 25);
            editAreaLabel.TabIndex = 5;
            editAreaLabel.Text = "Area";
            // 
            // editDeleteButton
            // 
            editDeleteButton.Image = (Image)resources.GetObject("editDeleteButton.Image");
            editDeleteButton.Location = new Point(254, 430);
            editDeleteButton.Name = "editDeleteButton";
            editDeleteButton.Size = new Size(50, 52);
            editDeleteButton.TabIndex = 3;
            deleteToolTip.SetToolTip(editDeleteButton, "Click here to delete the current shape.");
            editDeleteButton.UseVisualStyleBackColor = true;
            editDeleteButton.Click += EditDeleteButton_Click;
            // 
            // editHoverTextLabel
            // 
            editHoverTextLabel.Anchor = AnchorStyles.Left;
            editHoverTextLabel.AutoSize = true;
            editHoverTextLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editHoverTextLabel.Location = new Point(83, 218);
            editHoverTextLabel.Name = "editHoverTextLabel";
            editHoverTextLabel.Size = new Size(166, 42);
            editHoverTextLabel.TabIndex = 0;
            editHoverTextLabel.Text = "Please select a shape \r\nin order to edit!\r\n";
            editHoverTextLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // editBorderColorButton
            // 
            editBorderColorButton.BackColor = SystemColors.ControlLight;
            editBorderColorButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBorderColorButton.Location = new Point(70, 199);
            editBorderColorButton.Name = "editBorderColorButton";
            editBorderColorButton.Size = new Size(50, 50);
            editBorderColorButton.TabIndex = 1;
            editBorderColorToolTip.SetToolTip(editBorderColorButton, "Click here to change the Border Color of the current shape.");
            editBorderColorButton.UseVisualStyleBackColor = false;
            editBorderColorButton.Click += EditBorderColorButton_Click;
            // 
            // editMoveUpButton
            // 
            editMoveUpButton.BackgroundImage = (Image)resources.GetObject("editMoveUpButton.BackgroundImage");
            editMoveUpButton.Location = new Point(53, 394);
            editMoveUpButton.Name = "editMoveUpButton";
            editMoveUpButton.Size = new Size(50, 50);
            editMoveUpButton.TabIndex = 1;
            moveUpToolTip.SetToolTip(editMoveUpButton, "Click here to move the current shape one position Up.");
            editMoveUpButton.UseVisualStyleBackColor = true;
            editMoveUpButton.Click += EditMoveUpButton_Click;
            // 
            // editMoveDownButton
            // 
            editMoveDownButton.BackgroundImage = (Image)resources.GetObject("editMoveDownButton.BackgroundImage");
            editMoveDownButton.Location = new Point(134, 394);
            editMoveDownButton.Name = "editMoveDownButton";
            editMoveDownButton.Size = new Size(50, 50);
            editMoveDownButton.TabIndex = 2;
            moveDownToolTip.SetToolTip(editMoveDownButton, "Click here to move the current shape one position Down.");
            editMoveDownButton.UseVisualStyleBackColor = true;
            editMoveDownButton.Click += EditMoveDownButton_Click;
            // 
            // shapeNameLabel
            // 
            shapeNameLabel.AutoSize = true;
            shapeNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            shapeNameLabel.Location = new Point(11, 9);
            shapeNameLabel.Name = "shapeNameLabel";
            shapeNameLabel.Size = new Size(72, 30);
            shapeNameLabel.TabIndex = 1;
            shapeNameLabel.Text = "Shape";
            // 
            // mainBorderColorButton
            // 
            mainBorderColorButton.BackColor = Color.Black;
            mainBorderColorButton.Location = new Point(64, 148);
            mainBorderColorButton.Name = "mainBorderColorButton";
            mainBorderColorButton.Size = new Size(50, 50);
            mainBorderColorButton.TabIndex = 11;
            mainBorderColorToolTip.SetToolTip(mainBorderColorButton, "Click here to change the Main Border Color for any following shape.");
            mainBorderColorButton.UseVisualStyleBackColor = false;
            mainBorderColorButton.Click += MainBorderColorButton_Click;
            // 
            // undoButton
            // 
            undoButton.Image = (Image)resources.GetObject("undoButton.Image");
            undoButton.Location = new Point(347, 31);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(30, 30);
            undoButton.TabIndex = 12;
            undoToolTip.SetToolTip(undoButton, "Click here to undo the last action.");
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += UndoButton_Click;
            // 
            // redoButton
            // 
            redoButton.Image = (Image)resources.GetObject("redoButton.Image");
            redoButton.Location = new Point(383, 31);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(30, 30);
            redoButton.TabIndex = 13;
            redoToolTip.SetToolTip(redoButton, "Click here to redo the last undone action.");
            redoButton.UseVisualStyleBackColor = true;
            redoButton.Click += RedoButton_Click;
            // 
            // historyViewBox
            // 
            historyViewBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            historyViewBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historyViewBox.FormattingEnabled = true;
            historyViewBox.ItemHeight = 19;
            historyViewBox.Location = new Point(17, 50);
            historyViewBox.Name = "historyViewBox";
            historyViewBox.Size = new Size(287, 137);
            historyViewBox.TabIndex = 14;
            // 
            // historyLabel
            // 
            historyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            historyLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyLabel.Location = new Point(97, 19);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(132, 25);
            historyLabel.TabIndex = 15;
            historyLabel.Text = "History";
            historyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shapesPanel
            // 
            shapesPanel.BackColor = SystemColors.ControlLightLight;
            shapesPanel.Controls.Add(pentagonButton);
            shapesPanel.Controls.Add(shapesPanelLabel);
            shapesPanel.Controls.Add(triangleButton);
            shapesPanel.Controls.Add(rectangleButton);
            shapesPanel.Controls.Add(circleButton);
            shapesPanel.Controls.Add(squareButton);
            shapesPanel.Location = new Point(41, 376);
            shapesPanel.Name = "shapesPanel";
            shapesPanel.Size = new Size(271, 185);
            shapesPanel.TabIndex = 16;
            // 
            // shapesPanelLabel
            // 
            shapesPanelLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            shapesPanelLabel.Location = new Point(3, 9);
            shapesPanelLabel.Name = "shapesPanelLabel";
            shapesPanelLabel.Size = new Size(265, 36);
            shapesPanelLabel.TabIndex = 10;
            shapesPanelLabel.Text = "Shapes";
            shapesPanelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolsPanel
            // 
            toolsPanel.BackColor = SystemColors.ControlLightLight;
            toolsPanel.Controls.Add(mainFillColorRemoveColorButton);
            toolsPanel.Controls.Add(colorBucketRemoveColorButton);
            toolsPanel.Controls.Add(colorPickerRemoveColorButton);
            toolsPanel.Controls.Add(colorBucketButton);
            toolsPanel.Controls.Add(colorPickerButton);
            toolsPanel.Controls.Add(toolsFillLabel);
            toolsPanel.Controls.Add(toolsBorderLabel);
            toolsPanel.Controls.Add(eraserButton);
            toolsPanel.Controls.Add(penSizeTrackBar);
            toolsPanel.Controls.Add(toolsPenButton);
            toolsPanel.Controls.Add(toolsPenTextBox);
            toolsPanel.Controls.Add(toolsPenLabel);
            toolsPanel.Controls.Add(toolsLabel);
            toolsPanel.Controls.Add(selectButton);
            toolsPanel.Controls.Add(mainFillColorButton);
            toolsPanel.Controls.Add(mainBorderColorButton);
            toolsPanel.Location = new Point(41, 66);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(271, 299);
            toolsPanel.TabIndex = 17;
            // 
            // mainFillColorRemoveColorButton
            // 
            mainFillColorRemoveColorButton.Location = new Point(187, 187);
            mainFillColorRemoveColorButton.Name = "mainFillColorRemoveColorButton";
            mainFillColorRemoveColorButton.Size = new Size(22, 22);
            mainFillColorRemoveColorButton.TabIndex = 23;
            mainFillColorRemoveColorButton.Text = "❌";
            mainFillColorRemoveColorToolTip.SetToolTip(mainFillColorRemoveColorButton, "Click here to set the Main Fill Color to No Color.");
            mainFillColorRemoveColorButton.UseVisualStyleBackColor = true;
            mainFillColorRemoveColorButton.Click += MainFillColorRemoveColorButton_Click;
            // 
            // colorBucketRemoveColorButton
            // 
            colorBucketRemoveColorButton.Location = new Point(242, 92);
            colorBucketRemoveColorButton.Name = "colorBucketRemoveColorButton";
            colorBucketRemoveColorButton.Size = new Size(22, 22);
            colorBucketRemoveColorButton.TabIndex = 22;
            colorBucketRemoveColorButton.Text = "❌";
            colorBucketRemoveColorToolTip.SetToolTip(colorBucketRemoveColorButton, "Click here to set the Color Bucket Color to No Color.");
            colorBucketRemoveColorButton.UseVisualStyleBackColor = true;
            colorBucketRemoveColorButton.Click += ColorBucketRemoveColorButton_Click;
            // 
            // colorPickerRemoveColorButton
            // 
            colorPickerRemoveColorButton.Location = new Point(174, 92);
            colorPickerRemoveColorButton.Name = "colorPickerRemoveColorButton";
            colorPickerRemoveColorButton.Size = new Size(22, 22);
            colorPickerRemoveColorButton.TabIndex = 21;
            colorPickerRemoveColorButton.Text = "❌";
            colorPickerRemoveColorToolTip.SetToolTip(colorPickerRemoveColorButton, "Click here to remove the color picked with the Color Picker.");
            colorPickerRemoveColorButton.UseVisualStyleBackColor = true;
            colorPickerRemoveColorButton.Click += ColorPickerRemoveColorButton_Click;
            // 
            // colorBucketButton
            // 
            colorBucketButton.BackColor = SystemColors.ControlLight;
            colorBucketButton.Image = (Image)resources.GetObject("colorBucketButton.Image");
            colorBucketButton.Location = new Point(202, 54);
            colorBucketButton.Name = "colorBucketButton";
            colorBucketButton.Size = new Size(50, 51);
            colorBucketButton.TabIndex = 20;
            colorBucketToolTip.SetToolTip(colorBucketButton, "Click here to choose a color to fill shapes with when clicking on them.");
            colorBucketButton.UseVisualStyleBackColor = false;
            colorBucketButton.Click += ColorBucketButton_Click;
            // 
            // colorPickerButton
            // 
            colorPickerButton.BackColor = SystemColors.ControlLight;
            colorPickerButton.Image = (Image)resources.GetObject("colorPickerButton.Image");
            colorPickerButton.Location = new Point(136, 56);
            colorPickerButton.Name = "colorPickerButton";
            colorPickerButton.Size = new Size(50, 50);
            colorPickerButton.TabIndex = 19;
            colorPickerToolTip.SetToolTip(colorPickerButton, "Click here to pick the Main Fill Color from the created shapes on the main stage when clicking on them.");
            colorPickerButton.UseVisualStyleBackColor = false;
            colorPickerButton.Click += ColorPickerButton_Click;
            // 
            // toolsFillLabel
            // 
            toolsFillLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolsFillLabel.Location = new Point(146, 122);
            toolsFillLabel.Name = "toolsFillLabel";
            toolsFillLabel.Size = new Size(50, 23);
            toolsFillLabel.TabIndex = 18;
            toolsFillLabel.Text = "Fill";
            toolsFillLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolsBorderLabel
            // 
            toolsBorderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolsBorderLabel.Location = new Point(61, 122);
            toolsBorderLabel.Name = "toolsBorderLabel";
            toolsBorderLabel.Size = new Size(60, 23);
            toolsBorderLabel.TabIndex = 17;
            toolsBorderLabel.Text = "Border";
            toolsBorderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eraserButton
            // 
            eraserButton.Image = (Image)resources.GetObject("eraserButton.Image");
            eraserButton.Location = new Point(73, 56);
            eraserButton.Name = "eraserButton";
            eraserButton.Size = new Size(50, 50);
            eraserButton.TabIndex = 16;
            eraserToolTip.SetToolTip(eraserButton, "Click here to erase any shape on the main stage when clicking on them.");
            eraserButton.UseVisualStyleBackColor = true;
            eraserButton.Click += EraserButton_Click;
            // 
            // penSizeTrackBar
            // 
            penSizeTrackBar.Location = new Point(43, 244);
            penSizeTrackBar.Maximum = 30;
            penSizeTrackBar.Minimum = 2;
            penSizeTrackBar.Name = "penSizeTrackBar";
            penSizeTrackBar.Size = new Size(171, 45);
            penSizeTrackBar.TabIndex = 15;
            penSizeTrackBar.Value = 2;
            penSizeTrackBar.Scroll += PenSizeTrackBar_Scroll;
            // 
            // toolsPenButton
            // 
            toolsPenButton.Location = new Point(226, 220);
            toolsPenButton.Name = "toolsPenButton";
            toolsPenButton.Size = new Size(26, 23);
            toolsPenButton.TabIndex = 14;
            toolsPenButton.Text = "✅";
            toolsPenButton.UseVisualStyleBackColor = true;
            toolsPenButton.Click += ToolsPenButton_Click;
            // 
            // toolsPenTextBox
            // 
            toolsPenTextBox.Location = new Point(190, 220);
            toolsPenTextBox.Name = "toolsPenTextBox";
            toolsPenTextBox.Size = new Size(31, 23);
            toolsPenTextBox.TabIndex = 13;
            toolsPenTextBox.Text = "2";
            // 
            // toolsPenLabel
            // 
            toolsPenLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolsPenLabel.Location = new Point(43, 218);
            toolsPenLabel.Name = "toolsPenLabel";
            toolsPenLabel.Size = new Size(108, 23);
            toolsPenLabel.TabIndex = 12;
            toolsPenLabel.Text = "Pen Thickness";
            // 
            // toolsLabel
            // 
            toolsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            toolsLabel.ImageAlign = ContentAlignment.MiddleRight;
            toolsLabel.Location = new Point(3, 16);
            toolsLabel.Name = "toolsLabel";
            toolsLabel.Size = new Size(265, 23);
            toolsLabel.TabIndex = 0;
            toolsLabel.Text = "Tools";
            toolsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // historyPanel
            // 
            historyPanel.BackColor = SystemColors.ControlLightLight;
            historyPanel.Controls.Add(historyViewBox);
            historyPanel.Controls.Add(historyLabel);
            historyPanel.Location = new Point(1555, 589);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(320, 212);
            historyPanel.TabIndex = 18;
            // 
            // editPanel
            // 
            editPanel.BackColor = SystemColors.ControlLightLight;
            editPanel.Controls.Add(editHoverPanel);
            editPanel.Controls.Add(editFillColorNoColorButton);
            editPanel.Controls.Add(editPositionDownLabel);
            editPanel.Controls.Add(editPositionUpLabel);
            editPanel.Controls.Add(editPositionLabel);
            editPanel.Controls.Add(editPenTextBox);
            editPanel.Controls.Add(editPenButton);
            editPanel.Controls.Add(editPenThicknessScroll);
            editPanel.Controls.Add(editPenLabel);
            editPanel.Controls.Add(editFillLabel);
            editPanel.Controls.Add(editBorderLabel);
            editPanel.Controls.Add(editSecondarySideButton);
            editPanel.Controls.Add(shapeNameLabel);
            editPanel.Controls.Add(editSecondarySideLabel);
            editPanel.Controls.Add(editSecondarySideBox);
            editPanel.Controls.Add(editDeleteButton);
            editPanel.Controls.Add(editMainSideButton);
            editPanel.Controls.Add(editAreaLabel);
            editPanel.Controls.Add(editMainSideLabel);
            editPanel.Controls.Add(editMainSideBox);
            editPanel.Controls.Add(editAreaSize);
            editPanel.Controls.Add(editFillColorButton);
            editPanel.Controls.Add(editMoveDownButton);
            editPanel.Controls.Add(editMoveUpButton);
            editPanel.Controls.Add(editBorderColorButton);
            editPanel.Location = new Point(1555, 66);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(320, 495);
            editPanel.TabIndex = 19;
            // 
            // editHoverPanel
            // 
            editHoverPanel.BackColor = SystemColors.ControlLightLight;
            editHoverPanel.Controls.Add(editHoverTextLabel);
            editHoverPanel.Location = new Point(0, 0);
            editHoverPanel.Name = "editHoverPanel";
            editHoverPanel.Size = new Size(320, 495);
            editHoverPanel.TabIndex = 21;
            // 
            // editFillColorNoColorButton
            // 
            editFillColorNoColorButton.Location = new Point(218, 235);
            editFillColorNoColorButton.Name = "editFillColorNoColorButton";
            editFillColorNoColorButton.Size = new Size(22, 22);
            editFillColorNoColorButton.TabIndex = 22;
            editFillColorNoColorButton.Text = "❌";
            editFillColorNoColorToolTip.SetToolTip(editFillColorNoColorButton, "Click here to remove the Fill color of the current shape.");
            editFillColorNoColorButton.UseVisualStyleBackColor = true;
            editFillColorNoColorButton.Click += EditFillColorNoColorButton_Click;
            // 
            // editPositionDownLabel
            // 
            editPositionDownLabel.AutoSize = true;
            editPositionDownLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPositionDownLabel.Location = new Point(134, 447);
            editPositionDownLabel.Name = "editPositionDownLabel";
            editPositionDownLabel.Size = new Size(50, 17);
            editPositionDownLabel.TabIndex = 21;
            editPositionDownLabel.Text = "DOWN";
            // 
            // editPositionUpLabel
            // 
            editPositionUpLabel.AutoSize = true;
            editPositionUpLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPositionUpLabel.Location = new Point(67, 447);
            editPositionUpLabel.Name = "editPositionUpLabel";
            editPositionUpLabel.Size = new Size(25, 17);
            editPositionUpLabel.TabIndex = 20;
            editPositionUpLabel.Text = "UP";
            // 
            // editPositionLabel
            // 
            editPositionLabel.AutoSize = true;
            editPositionLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPositionLabel.Location = new Point(13, 358);
            editPositionLabel.Name = "editPositionLabel";
            editPositionLabel.Size = new Size(68, 21);
            editPositionLabel.TabIndex = 19;
            editPositionLabel.Text = "Position";
            // 
            // editPenTextBox
            // 
            editPenTextBox.Location = new Point(218, 281);
            editPenTextBox.Name = "editPenTextBox";
            editPenTextBox.Size = new Size(31, 23);
            editPenTextBox.TabIndex = 18;
            // 
            // editPenButton
            // 
            editPenButton.Location = new Point(255, 281);
            editPenButton.Name = "editPenButton";
            editPenButton.Size = new Size(49, 23);
            editPenButton.TabIndex = 17;
            editPenButton.Text = "Apply";
            editPenButton.UseVisualStyleBackColor = true;
            editPenButton.Click += EditPenButton_Click;
            // 
            // editPenThicknessScroll
            // 
            editPenThicknessScroll.Location = new Point(58, 310);
            editPenThicknessScroll.Maximum = 30;
            editPenThicknessScroll.Minimum = 2;
            editPenThicknessScroll.Name = "editPenThicknessScroll";
            editPenThicknessScroll.Size = new Size(171, 45);
            editPenThicknessScroll.TabIndex = 16;
            editPenThicknessScroll.Value = 2;
            editPenThicknessScroll.Scroll += EditPenThicknessScroll_Scroll;
            editPenThicknessScroll.MouseUp += EditPenThicknessScroll_MouseUp;
            // 
            // editPenLabel
            // 
            editPenLabel.AutoSize = true;
            editPenLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPenLabel.Location = new Point(13, 278);
            editPenLabel.Name = "editPenLabel";
            editPenLabel.Size = new Size(110, 21);
            editPenLabel.TabIndex = 15;
            editPenLabel.Text = "Pen Thickness";
            // 
            // editFillLabel
            // 
            editFillLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editFillLabel.Location = new Point(179, 175);
            editFillLabel.Name = "editFillLabel";
            editFillLabel.Size = new Size(50, 23);
            editFillLabel.TabIndex = 14;
            editFillLabel.Text = "Fill";
            editFillLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // editBorderLabel
            // 
            editBorderLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBorderLabel.Location = new Point(58, 175);
            editBorderLabel.Name = "editBorderLabel";
            editBorderLabel.Size = new Size(82, 23);
            editBorderLabel.TabIndex = 13;
            editBorderLabel.Text = "Border";
            editBorderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rectangleToolTip
            // 
            rectangleToolTip.ToolTipTitle = "Rectangle";
            // 
            // shapeFillColorToolTip
            // 
            shapeFillColorToolTip.ToolTipTitle = "Shape Fill Color";
            // 
            // triangleToolTip
            // 
            triangleToolTip.ToolTipTitle = "Triangle";
            // 
            // selectToolTip
            // 
            selectToolTip.ToolTipTitle = "Select";
            // 
            // mainFillColorToolTip
            // 
            mainFillColorToolTip.ToolTipTitle = "Main Fill Color";
            // 
            // circleToolTip
            // 
            circleToolTip.ToolTipTitle = "Circle";
            // 
            // squareToolTip
            // 
            squareToolTip.ToolTipTitle = "Square";
            // 
            // pentagonToolTip
            // 
            pentagonToolTip.ToolTipTitle = "Pentagon";
            // 
            // deleteToolTip
            // 
            deleteToolTip.ToolTipTitle = "Delete";
            // 
            // moveUpToolTip
            // 
            moveUpToolTip.ToolTipTitle = "Move Up";
            // 
            // moveDownToolTip
            // 
            moveDownToolTip.ToolTipTitle = "Move Down";
            // 
            // mainBorderColorToolTip
            // 
            mainBorderColorToolTip.ToolTipTitle = "Main Border Color";
            // 
            // undoToolTip
            // 
            undoToolTip.ToolTipTitle = "Undo";
            // 
            // redoToolTip
            // 
            redoToolTip.ToolTipTitle = "Redo";
            // 
            // editBorderColorToolTip
            // 
            editBorderColorToolTip.ToolTipTitle = "Shape Border Color";
            // 
            // colorPickerToolTip
            // 
            colorPickerToolTip.ToolTipTitle = "Fill Color Picker";
            // 
            // eraserToolTip
            // 
            eraserToolTip.ToolTipTitle = "Eraser";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = SystemColors.ControlLightLight;
            filterPanel.Controls.Add(filterGroupBox);
            filterPanel.Controls.Add(filterCheckBox);
            filterPanel.Controls.Add(filterLabel);
            filterPanel.Location = new Point(41, 567);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(271, 367);
            filterPanel.TabIndex = 20;
            // 
            // filterGroupBox
            // 
            filterGroupBox.Controls.Add(filterDeleteElseButton);
            filterGroupBox.Controls.Add(filterDeleteSelectedButton);
            filterGroupBox.Controls.Add(label1);
            filterGroupBox.Controls.Add(filterBorderColorCheckedListBox);
            filterGroupBox.Controls.Add(filterAreaPanel);
            filterGroupBox.Controls.Add(filterAreaLabel);
            filterGroupBox.Controls.Add(filterFillColorCheckedListBox);
            filterGroupBox.Controls.Add(filterFillColorLabel);
            filterGroupBox.Controls.Add(filterShapesCheckedListBox);
            filterGroupBox.Controls.Add(filterShapesLabel);
            filterGroupBox.Enabled = false;
            filterGroupBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterGroupBox.Location = new Point(3, 59);
            filterGroupBox.Name = "filterGroupBox";
            filterGroupBox.Size = new Size(265, 304);
            filterGroupBox.TabIndex = 3;
            filterGroupBox.TabStop = false;
            // 
            // filterDeleteElseButton
            // 
            filterDeleteElseButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterDeleteElseButton.Location = new Point(152, 239);
            filterDeleteElseButton.Name = "filterDeleteElseButton";
            filterDeleteElseButton.Size = new Size(97, 46);
            filterDeleteElseButton.TabIndex = 12;
            filterDeleteElseButton.Text = "Delete Non-selected";
            filterDeleteElseButton.UseVisualStyleBackColor = true;
            filterDeleteElseButton.Click += FilterDeleteElseButton_Click;
            // 
            // filterDeleteSelectedButton
            // 
            filterDeleteSelectedButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterDeleteSelectedButton.Location = new Point(35, 239);
            filterDeleteSelectedButton.Name = "filterDeleteSelectedButton";
            filterDeleteSelectedButton.Size = new Size(76, 46);
            filterDeleteSelectedButton.TabIndex = 11;
            filterDeleteSelectedButton.Text = "Delete Selected";
            filterDeleteSelectedButton.UseVisualStyleBackColor = true;
            filterDeleteSelectedButton.Click += FilterDeleteSelectedButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(139, 130);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 10;
            label1.Text = "Border Colors";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterBorderColorCheckedListBox
            // 
            filterBorderColorCheckedListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBorderColorCheckedListBox.FormattingEnabled = true;
            filterBorderColorCheckedListBox.HorizontalScrollbar = true;
            filterBorderColorCheckedListBox.Location = new Point(138, 153);
            filterBorderColorCheckedListBox.Name = "filterBorderColorCheckedListBox";
            filterBorderColorCheckedListBox.Size = new Size(120, 64);
            filterBorderColorCheckedListBox.TabIndex = 9;
            filterBorderColorCheckedListBox.MouseUp += FilterBorderColorCheckedListBox_MouseUp;
            // 
            // filterAreaPanel
            // 
            filterAreaPanel.Controls.Add(filterAreaMaxButton);
            filterAreaPanel.Controls.Add(filterAreaMinButton);
            filterAreaPanel.Controls.Add(filterAreaMaxTextBox);
            filterAreaPanel.Controls.Add(filterAreaMinTextBox);
            filterAreaPanel.Controls.Add(filterAreaMinLabel);
            filterAreaPanel.Controls.Add(filterAreaMaxLabel);
            filterAreaPanel.Location = new Point(139, 46);
            filterAreaPanel.Name = "filterAreaPanel";
            filterAreaPanel.Size = new Size(122, 64);
            filterAreaPanel.TabIndex = 8;
            // 
            // filterAreaMaxButton
            // 
            filterAreaMaxButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterAreaMaxButton.Location = new Point(94, 35);
            filterAreaMaxButton.Name = "filterAreaMaxButton";
            filterAreaMaxButton.Size = new Size(26, 23);
            filterAreaMaxButton.TabIndex = 11;
            filterAreaMaxButton.Text = "✅";
            filterAreaMaxButton.UseVisualStyleBackColor = true;
            filterAreaMaxButton.Click += FilterAreaMaxButton_Click;
            // 
            // filterAreaMinButton
            // 
            filterAreaMinButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterAreaMinButton.Location = new Point(94, 6);
            filterAreaMinButton.Name = "filterAreaMinButton";
            filterAreaMinButton.Size = new Size(26, 23);
            filterAreaMinButton.TabIndex = 10;
            filterAreaMinButton.Text = "✅";
            filterAreaMinButton.UseVisualStyleBackColor = true;
            filterAreaMinButton.Click += FilterAreaMinButton_Click;
            // 
            // filterAreaMaxTextBox
            // 
            filterAreaMaxTextBox.Location = new Point(40, 34);
            filterAreaMaxTextBox.Name = "filterAreaMaxTextBox";
            filterAreaMaxTextBox.Size = new Size(53, 27);
            filterAreaMaxTextBox.TabIndex = 9;
            // 
            // filterAreaMinTextBox
            // 
            filterAreaMinTextBox.Location = new Point(40, 4);
            filterAreaMinTextBox.Name = "filterAreaMinTextBox";
            filterAreaMinTextBox.Size = new Size(53, 27);
            filterAreaMinTextBox.TabIndex = 8;
            // 
            // filterAreaMinLabel
            // 
            filterAreaMinLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            filterAreaMinLabel.Location = new Point(3, 7);
            filterAreaMinLabel.Name = "filterAreaMinLabel";
            filterAreaMinLabel.Size = new Size(41, 20);
            filterAreaMinLabel.TabIndex = 6;
            filterAreaMinLabel.Text = "Min";
            filterAreaMinLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filterAreaMaxLabel
            // 
            filterAreaMaxLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            filterAreaMaxLabel.Location = new Point(3, 37);
            filterAreaMaxLabel.Name = "filterAreaMaxLabel";
            filterAreaMaxLabel.Size = new Size(38, 20);
            filterAreaMaxLabel.TabIndex = 7;
            filterAreaMaxLabel.Text = "Max";
            filterAreaMaxLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filterAreaLabel
            // 
            filterAreaLabel.Location = new Point(139, 23);
            filterAreaLabel.Name = "filterAreaLabel";
            filterAreaLabel.Size = new Size(122, 20);
            filterAreaLabel.TabIndex = 5;
            filterAreaLabel.Text = "Areas";
            filterAreaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterFillColorCheckedListBox
            // 
            filterFillColorCheckedListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterFillColorCheckedListBox.FormattingEnabled = true;
            filterFillColorCheckedListBox.HorizontalScrollbar = true;
            filterFillColorCheckedListBox.Location = new Point(9, 153);
            filterFillColorCheckedListBox.Name = "filterFillColorCheckedListBox";
            filterFillColorCheckedListBox.Size = new Size(120, 64);
            filterFillColorCheckedListBox.TabIndex = 4;
            filterFillColorCheckedListBox.TabStop = false;
            filterFillColorCheckedListBox.MouseUp += FilterFillColorCheckedListBox_MouseUp;
            // 
            // filterFillColorLabel
            // 
            filterFillColorLabel.Location = new Point(13, 130);
            filterFillColorLabel.Name = "filterFillColorLabel";
            filterFillColorLabel.Size = new Size(120, 20);
            filterFillColorLabel.TabIndex = 3;
            filterFillColorLabel.Text = "Fill Colors";
            filterFillColorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterShapesCheckedListBox
            // 
            filterShapesCheckedListBox.CheckOnClick = true;
            filterShapesCheckedListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterShapesCheckedListBox.FormattingEnabled = true;
            filterShapesCheckedListBox.Location = new Point(9, 46);
            filterShapesCheckedListBox.Name = "filterShapesCheckedListBox";
            filterShapesCheckedListBox.Size = new Size(120, 64);
            filterShapesCheckedListBox.TabIndex = 2;
            filterShapesCheckedListBox.TabStop = false;
            filterShapesCheckedListBox.MouseUp += FilterShapesCheckedListBox_MouseUp;
            // 
            // filterShapesLabel
            // 
            filterShapesLabel.Location = new Point(9, 23);
            filterShapesLabel.Name = "filterShapesLabel";
            filterShapesLabel.Size = new Size(120, 20);
            filterShapesLabel.TabIndex = 1;
            filterShapesLabel.Text = "Shapes";
            filterShapesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filterCheckBox
            // 
            filterCheckBox.AutoSize = true;
            filterCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            filterCheckBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterCheckBox.Location = new Point(54, 38);
            filterCheckBox.Name = "filterCheckBox";
            filterCheckBox.Size = new Size(167, 24);
            filterCheckBox.TabIndex = 2;
            filterCheckBox.Text = "Enable View Filtering";
            filterCheckBox.UseVisualStyleBackColor = true;
            filterCheckBox.Click += FilterCheckBox_Click;
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            filterLabel.Location = new Point(73, 10);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(129, 25);
            filterLabel.TabIndex = 0;
            filterLabel.Text = "View Filtering";
            // 
            // mainOpenFileDialog
            // 
            mainOpenFileDialog.FileName = "openFileDialog1";
            // 
            // colorBucketToolTip
            // 
            colorBucketToolTip.ToolTipTitle = "Fill Color Bucket";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1902, 1041);
            Controls.Add(filterPanel);
            Controls.Add(editPanel);
            Controls.Add(historyPanel);
            Controls.Add(toolsPanel);
            Controls.Add(shapesPanel);
            Controls.Add(redoButton);
            Controls.Add(undoButton);
            Controls.Add(drawPanel);
            Controls.Add(fileMenu);
            MainMenuStrip = fileMenu;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1038);
            Name = "MainForm";
            Text = "FigureForge";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            fileMenu.ResumeLayout(false);
            fileMenu.PerformLayout();
            shapesPanel.ResumeLayout(false);
            toolsPanel.ResumeLayout(false);
            toolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)penSizeTrackBar).EndInit();
            historyPanel.ResumeLayout(false);
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            editHoverPanel.ResumeLayout(false);
            editHoverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editPenThicknessScroll).EndInit();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            filterGroupBox.ResumeLayout(false);
            filterAreaPanel.ResumeLayout(false);
            filterAreaPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip fileMenu;
        private ToolStripMenuItem fileToolStripMenu;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button rectangleButton;
        private Button triangleButton;
        private Button selectButton;
        private Button mainFillColorButton;
        private ColorDialog mainColorDialog;
        private Button editFillColorButton;
        private Button circleButton;
        private Button squareButton;
        private Button pentagonButton;
        private Panel drawPanel;
        private Label editHoverTextLabel;
        private Label shapeNameLabel;
        private Button editMoveUpButton;
        private Button editMoveDownButton;
        private Button mainBorderColorButton;
        private Button editBorderColorButton;
        private Button undoButton;
        private Button redoButton;
        private Button editDeleteButton;
        private ListBox historyViewBox;
        private Label editAreaSize;
        private Label editAreaLabel;
        private Label editMainSideLabel;
        private Button editMainSideButton;
        private TextBox editMainSideBox;
        private Label editSecondarySideLabel;
        private TextBox editSecondarySideBox;
        private Button editSecondarySideButton;
        private Label historyLabel;
        private Panel shapesPanel;
        private Label shapesPanelLabel;
        private Panel toolsPanel;
        private Label toolsLabel;
        private Panel historyPanel;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private Button toolsPenButton;
        private TextBox toolsPenTextBox;
        private Label toolsPenLabel;
        private TrackBar penSizeTrackBar;
        private ToolTip penScrollToolTip;
        private Button eraserButton;
        private Label toolsFillLabel;
        private Label toolsBorderLabel;
        private Button colorPickerButton;
        private Panel editPanel;
        private Label editBorderLabel;
        private Label editFillLabel;
        private TrackBar editPenThicknessScroll;
        private Label editPenLabel;
        private Button editPenButton;
        private TextBox editPenTextBox;
        private ToolTip editPenScrollToolTip;
        private Label editPositionLabel;
        private Label editPositionDownLabel;
        private Label editPositionUpLabel;
        private ToolTip rectangleToolTip;
        private ToolTip shapeFillColorToolTip;
        private ToolTip triangleToolTip;
        private ToolTip selectToolTip;
        private ToolTip mainFillColorToolTip;
        private ToolTip circleToolTip;
        private ToolTip squareToolTip;
        private ToolTip pentagonToolTip;
        private ToolTip deleteToolTip;
        private ToolTip moveUpToolTip;
        private ToolTip moveDownToolTip;
        private ToolTip mainBorderColorToolTip;
        private ToolTip undoToolTip;
        private ToolTip redoToolTip;
        private ToolTip editBorderColorToolTip;
        private ToolTip colorPickerToolTip;
        private ToolTip eraserToolTip;
        private Panel filterPanel;
        private Label filterLabel;
        private CheckBox filterCheckBox;
        private GroupBox filterGroupBox;
        private Label filterShapesLabel;
        private CheckedListBox filterShapesCheckedListBox;
        private CheckedListBox filterFillColorCheckedListBox;
        private Label filterFillColorLabel;
        private Label filterAreaLabel;
        private Label filterAreaMaxLabel;
        private Label filterAreaMinLabel;
        private Panel filterAreaPanel;
        private TextBox filterAreaMinTextBox;
        private TextBox filterAreaMaxTextBox;
        private Button filterAreaMaxButton;
        private Button filterAreaMinButton;
        private Label label1;
        private CheckedListBox filterBorderColorCheckedListBox;
        private Panel editHoverPanel;
        private Button filterDeleteElseButton;
        private Button filterDeleteSelectedButton;
        private ToolStripSeparator toolStripSeparatorBeforeExit;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparatorBeforeSaveAs;
        private SaveFileDialog mainSaveFileDialog;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog mainOpenFileDialog;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button colorBucketButton;
        private ToolTip colorBucketToolTip;
        private Button colorPickerRemoveColorButton;
        private Button colorBucketRemoveColorButton;
        private Button mainFillColorRemoveColorButton;
        private ToolTip mainFillColorRemoveColorToolTip;
        private ToolTip colorBucketRemoveColorToolTip;
        private ToolTip colorPickerRemoveColorToolTip;
        private Button editFillColorNoColorButton;
        private ToolTip editFillColorNoColorToolTip;
    }
}
