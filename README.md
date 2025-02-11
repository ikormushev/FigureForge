# FigureForge

🔶 **FigureForge** is a Windows Forms desktop application that allows users to create and manipulate graphic figures with ease. This application showcases proficiency in C# object-oriented programming (OOP) principles as well as JSON serialization and deserialization for saving and loading drawings.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)

## Overview
FigureForge provides an intuitive interface for drawing and editing various geometric shapes. With a comprehensive toolset and dynamic editing features, users can effortlessly design, modify, and manage graphic figures. Drawings can be saved as JSON files and later reloaded, making it easy to preserve your creative work.
![FigureForge - main stage](https://github.com/user-attachments/assets/dee05e45-1834-4f85-9bec-3f0c8399dd4d)

## Features
- **Tools Panel:**
  - **Selection Button:** Select and manipulate figures on the canvas.
  - **Eraser:** Remove figures.
  - **Color Picker:** Choose colors for shapes from other shapes.
  - **Fill Bucket:** Fill shapes with a selected color.
  - **Border & Fill Color Options:** Customize the appearance of shapes.
  - **Pen Thickness:** Adjust the thickness of shape borders.

- **Shapes:**
  - Draw a variety of shapes including **rectangle**, **square**, **triangle**, **circle**, and **pentagon**.

- **View Filtering:**
  - Filter the shapes on the main stage based on criteria such as shape type, area, fill color, and border color.
  - Option to delete either the selected or non-selected shapes based on the filter.
  ![FigureForge - View Filtering](https://github.com/user-attachments/assets/49aadd73-4c74-4a42-9c1e-092d16958d3a)

- **Undo/Redo Functionality:**
  - Easily revert or reapply actions during the drawing process.

- **Edit Panel:**
  - Displays detailed properties of the selected shape, including:
    - Area
    - Sides & their lengths
    - Border color and fill color
    - Pen thickness
    - Position (with options to move up or down)
  - Allows the user to modify these properties or delete the shape entirely.
  ![FigureForge - edit](https://github.com/user-attachments/assets/22457eea-98c0-4c60-b203-ff43ca16ca31)

- **History Panel:**
  - Keeps a log of all actions performed for easy reference.

- **Saving and Loading:**
  - Save your drawn figures as a JSON file via serialization.
  - Reload your saved drawings through JSON deserialization.

## Technologies Used

- **Language:** C#
- **Framework:** WinForms (.NET)
- **Serialization:** JSON Serialization & Deserialization
- **Design Principles:** Object-Oriented Programming (OOP)
