//////////////////////////////////////////////////////////////////////////////////////////////////
// File Name: Tsp.Form.Designer.cs
//      Date: 06/01/2006
// Copyright (c) 2006 Michael LaLena. All rights reserved.
// Permission to use, copy, modify, and distribute this Program and its documentation,
//  if any, for any purpose and without fee is hereby granted, provided that:
//   (i) you not charge any fee for the Program, and the Program not be incorporated
//       by you in any software or code for which compensation is expected or received;
//   (ii) the copyright notice listed above appears in all copies;
//   (iii) both the copyright notice and this Agreement appear in all supporting documentation; and
//   (iv) the name of Michael LaLena or lalena.com not be used in advertising or publicity
//          pertaining to distribution of the Program without specific, written prior permission. 
///////////////////////////////////////////////////////////////////////////////////////////////////
namespace Tsp
{
    partial class TspForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tourDiagram = new System.Windows.Forms.PictureBox();
            this.populationSizeTextBox = new System.Windows.Forms.TextBox();
            this.PopulationSizeLabel = new System.Windows.Forms.Label();
            this.lastIterationLabel = new System.Windows.Forms.Label();
            this.lastIterationValue = new System.Windows.Forms.Label();
            this.lastTourLabel = new System.Windows.Forms.Label();
            this.lastFitnessValue = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.maxGenerationLabel = new System.Windows.Forms.Label();
            this.maxGenerationTextBox = new System.Windows.Forms.TextBox();
            this.groupSizeLabel = new System.Windows.Forms.Label();
            this.groupSizeTextBox = new System.Windows.Forms.TextBox();
            this.randomSeedTextBox = new System.Windows.Forms.TextBox();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.openCityListButton = new System.Windows.Forms.Button();
            this.clearCityListButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.mutationTextBox = new System.Windows.Forms.TextBox();
            this.mutationLabel = new System.Windows.Forms.Label();
            this.NumberCitiesLabel = new System.Windows.Forms.Label();
            this.NumberCitiesValue = new System.Windows.Forms.Label();
            this.NumberCloseCitiesTextBox = new System.Windows.Forms.TextBox();
            this.NumberCloseCitiesLabel = new System.Windows.Forms.Label();
            this.CloseCityOddsTextBox = new System.Windows.Forms.TextBox();
            this.CloseCityOddsLabel = new System.Windows.Forms.Label();
            this.Main_split_container = new System.Windows.Forms.SplitContainer();
            this.PictureBox_PanellTool = new System.Windows.Forms.SplitContainer();
            this.Settings_panel = new System.Windows.Forms.Panel();
            this.City_XML_File_name = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Start_button_panel = new System.Windows.Forms.Panel();
            this.Save_kml_file = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).BeginInit();
            this.Main_split_container.Panel1.SuspendLayout();
            this.Main_split_container.Panel2.SuspendLayout();
            this.Main_split_container.SuspendLayout();
            this.PictureBox_PanellTool.Panel1.SuspendLayout();
            this.PictureBox_PanellTool.Panel2.SuspendLayout();
            this.PictureBox_PanellTool.SuspendLayout();
            this.Settings_panel.SuspendLayout();
            this.City_XML_File_name.SuspendLayout();
            this.Start_button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourDiagram
            // 
            this.tourDiagram.BackColor = System.Drawing.Color.Silver;
            this.tourDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourDiagram.Location = new System.Drawing.Point(0, 0);
            this.tourDiagram.Margin = new System.Windows.Forms.Padding(10);
            this.tourDiagram.Name = "tourDiagram";
            this.tourDiagram.Size = new System.Drawing.Size(589, 497);
            this.tourDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tourDiagram.TabIndex = 0;
            this.tourDiagram.TabStop = false;
            this.tourDiagram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tourDiagram_MouseDown);
            // 
            // populationSizeTextBox
            // 
            this.populationSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.populationSizeTextBox.Location = new System.Drawing.Point(49, -257);
            this.populationSizeTextBox.Name = "populationSizeTextBox";
            this.populationSizeTextBox.Size = new System.Drawing.Size(116, 21);
            this.populationSizeTextBox.TabIndex = 1;
            this.populationSizeTextBox.Text = "10000";
            // 
            // PopulationSizeLabel
            // 
            this.PopulationSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopulationSizeLabel.AutoSize = true;
            this.PopulationSizeLabel.Location = new System.Drawing.Point(49, -273);
            this.PopulationSizeLabel.Name = "PopulationSizeLabel";
            this.PopulationSizeLabel.Size = new System.Drawing.Size(94, 13);
            this.PopulationSizeLabel.TabIndex = 0;
            this.PopulationSizeLabel.Text = "Population Size";
            // 
            // lastIterationLabel
            // 
            this.lastIterationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastIterationLabel.AutoSize = true;
            this.lastIterationLabel.Location = new System.Drawing.Point(21, 23);
            this.lastIterationLabel.Name = "lastIterationLabel";
            this.lastIterationLabel.Size = new System.Drawing.Size(92, 13);
            this.lastIterationLabel.TabIndex = 0;
            this.lastIterationLabel.Text = "Last Iteration: ";
            // 
            // lastIterationValue
            // 
            this.lastIterationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastIterationValue.Location = new System.Drawing.Point(118, 23);
            this.lastIterationValue.Name = "lastIterationValue";
            this.lastIterationValue.Size = new System.Drawing.Size(117, 13);
            this.lastIterationValue.TabIndex = 0;
            this.lastIterationValue.Text = "itter";
            // 
            // lastTourLabel
            // 
            this.lastTourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastTourLabel.AutoSize = true;
            this.lastTourLabel.Location = new System.Drawing.Point(241, 23);
            this.lastTourLabel.Name = "lastTourLabel";
            this.lastTourLabel.Size = new System.Drawing.Size(106, 13);
            this.lastTourLabel.TabIndex = 0;
            this.lastTourLabel.Text = "Last Tour Length:";
            // 
            // lastFitnessValue
            // 
            this.lastFitnessValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastFitnessValue.Location = new System.Drawing.Point(358, 23);
            this.lastFitnessValue.Name = "lastFitnessValue";
            this.lastFitnessValue.Size = new System.Drawing.Size(85, 13);
            this.lastFitnessValue.TabIndex = 0;
            this.lastFitnessValue.Text = "lenght";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Location = new System.Drawing.Point(34, 18);
            this.StartButton.Margin = new System.Windows.Forms.Padding(5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(70, 39);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(23, 34);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(117, 13);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "City XML File Name";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(25, 55);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(87, 21);
            this.fileNameTextBox.TabIndex = 6;
            this.fileNameTextBox.Text = "../../Cities.xml";
            // 
            // maxGenerationLabel
            // 
            this.maxGenerationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGenerationLabel.AutoSize = true;
            this.maxGenerationLabel.Location = new System.Drawing.Point(-7, 69);
            this.maxGenerationLabel.Name = "maxGenerationLabel";
            this.maxGenerationLabel.Size = new System.Drawing.Size(89, 13);
            this.maxGenerationLabel.TabIndex = 0;
            this.maxGenerationLabel.Text = "Maximum Gen";
            // 
            // maxGenerationTextBox
            // 
            this.maxGenerationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxGenerationTextBox.Location = new System.Drawing.Point(-4, 85);
            this.maxGenerationTextBox.Name = "maxGenerationTextBox";
            this.maxGenerationTextBox.Size = new System.Drawing.Size(116, 21);
            this.maxGenerationTextBox.TabIndex = 4;
            this.maxGenerationTextBox.Text = "10000000";
            // 
            // groupSizeLabel
            // 
            this.groupSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSizeLabel.AutoSize = true;
            this.groupSizeLabel.Location = new System.Drawing.Point(49, -197);
            this.groupSizeLabel.Name = "groupSizeLabel";
            this.groupSizeLabel.Size = new System.Drawing.Size(70, 13);
            this.groupSizeLabel.TabIndex = 0;
            this.groupSizeLabel.Text = "Group Size";
            // 
            // groupSizeTextBox
            // 
            this.groupSizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSizeTextBox.Location = new System.Drawing.Point(49, -183);
            this.groupSizeTextBox.Name = "groupSizeTextBox";
            this.groupSizeTextBox.Size = new System.Drawing.Size(116, 21);
            this.groupSizeTextBox.TabIndex = 3;
            this.groupSizeTextBox.Text = "5";
            // 
            // randomSeedTextBox
            // 
            this.randomSeedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedTextBox.Location = new System.Drawing.Point(-4, 203);
            this.randomSeedTextBox.Name = "randomSeedTextBox";
            this.randomSeedTextBox.Size = new System.Drawing.Size(116, 21);
            this.randomSeedTextBox.TabIndex = 5;
            this.randomSeedTextBox.Text = "0";
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(-4, 187);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Size = new System.Drawing.Size(87, 13);
            this.randomSeedLabel.TabIndex = 0;
            this.randomSeedLabel.Text = "Random Seed";
            // 
            // openCityListButton
            // 
            this.openCityListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openCityListButton.Location = new System.Drawing.Point(23, 111);
            this.openCityListButton.Name = "openCityListButton";
            this.openCityListButton.Size = new System.Drawing.Size(91, 23);
            this.openCityListButton.TabIndex = 8;
            this.openCityListButton.Text = "Open City List";
            this.openCityListButton.UseVisualStyleBackColor = true;
            this.openCityListButton.Click += new System.EventHandler(this.openCityListButton_Click);
            // 
            // clearCityListButton
            // 
            this.clearCityListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCityListButton.Location = new System.Drawing.Point(23, 140);
            this.clearCityListButton.Name = "clearCityListButton";
            this.clearCityListButton.Size = new System.Drawing.Size(91, 23);
            this.clearCityListButton.TabIndex = 9;
            this.clearCityListButton.Text = "Clear City List";
            this.clearCityListButton.UseVisualStyleBackColor = true;
            this.clearCityListButton.Click += new System.EventHandler(this.clearCityListButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.Location = new System.Drawing.Point(23, 48);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(422, 13);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Open a City List or click the map to place cities.";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFileButton.Location = new System.Drawing.Point(23, 82);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(91, 23);
            this.selectFileButton.TabIndex = 7;
            this.selectFileButton.Text = "Browse";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // mutationTextBox
            // 
            this.mutationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationTextBox.Location = new System.Drawing.Point(49, -219);
            this.mutationTextBox.Name = "mutationTextBox";
            this.mutationTextBox.Size = new System.Drawing.Size(116, 21);
            this.mutationTextBox.TabIndex = 2;
            this.mutationTextBox.Text = "3";
            // 
            // mutationLabel
            // 
            this.mutationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationLabel.AutoSize = true;
            this.mutationLabel.Location = new System.Drawing.Point(49, -233);
            this.mutationLabel.Name = "mutationLabel";
            this.mutationLabel.Size = new System.Drawing.Size(71, 13);
            this.mutationLabel.TabIndex = 10;
            this.mutationLabel.Text = "Mutation %";
            // 
            // NumberCitiesLabel
            // 
            this.NumberCitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCitiesLabel.Location = new System.Drawing.Point(762, 71);
            this.NumberCitiesLabel.Name = "NumberCitiesLabel";
            this.NumberCitiesLabel.Size = new System.Drawing.Size(64, 13);
            this.NumberCitiesLabel.TabIndex = 12;
            this.NumberCitiesLabel.Text = "# Cities: ";
            // 
            // NumberCitiesValue
            // 
            this.NumberCitiesValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCitiesValue.Location = new System.Drawing.Point(672, 558);
            this.NumberCitiesValue.Name = "NumberCitiesValue";
            this.NumberCitiesValue.Size = new System.Drawing.Size(48, 13);
            this.NumberCitiesValue.TabIndex = 13;
            // 
            // NumberCloseCitiesTextBox
            // 
            this.NumberCloseCitiesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCloseCitiesTextBox.Location = new System.Drawing.Point(-4, 123);
            this.NumberCloseCitiesTextBox.Name = "NumberCloseCitiesTextBox";
            this.NumberCloseCitiesTextBox.Size = new System.Drawing.Size(116, 21);
            this.NumberCloseCitiesTextBox.TabIndex = 15;
            this.NumberCloseCitiesTextBox.Text = "5";
            // 
            // NumberCloseCitiesLabel
            // 
            this.NumberCloseCitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberCloseCitiesLabel.AutoSize = true;
            this.NumberCloseCitiesLabel.Location = new System.Drawing.Point(-7, 107);
            this.NumberCloseCitiesLabel.Name = "NumberCloseCitiesLabel";
            this.NumberCloseCitiesLabel.Size = new System.Drawing.Size(97, 13);
            this.NumberCloseCitiesLabel.TabIndex = 14;
            this.NumberCloseCitiesLabel.Text = "# Nearby Cities";
            // 
            // CloseCityOddsTextBox
            // 
            this.CloseCityOddsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseCityOddsTextBox.Location = new System.Drawing.Point(-4, 163);
            this.CloseCityOddsTextBox.Name = "CloseCityOddsTextBox";
            this.CloseCityOddsTextBox.Size = new System.Drawing.Size(116, 21);
            this.CloseCityOddsTextBox.TabIndex = 18;
            this.CloseCityOddsTextBox.Text = "90";
            // 
            // CloseCityOddsLabel
            // 
            this.CloseCityOddsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseCityOddsLabel.AutoSize = true;
            this.CloseCityOddsLabel.Location = new System.Drawing.Point(-7, 147);
            this.CloseCityOddsLabel.Name = "CloseCityOddsLabel";
            this.CloseCityOddsLabel.Size = new System.Drawing.Size(124, 13);
            this.CloseCityOddsLabel.TabIndex = 17;
            this.CloseCityOddsLabel.Text = "Nearby City Odds %";
            // 
            // Main_split_container
            // 
            this.Main_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_split_container.Location = new System.Drawing.Point(0, 0);
            this.Main_split_container.Name = "Main_split_container";
            this.Main_split_container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Main_split_container.Panel1
            // 
            this.Main_split_container.Panel1.Controls.Add(this.PictureBox_PanellTool);
            // 
            // Main_split_container.Panel2
            // 
            this.Main_split_container.Panel2.Controls.Add(this.lastTourLabel);
            this.Main_split_container.Panel2.Controls.Add(this.lastIterationLabel);
            this.Main_split_container.Panel2.Controls.Add(this.lastIterationValue);
            this.Main_split_container.Panel2.Controls.Add(this.lastFitnessValue);
            this.Main_split_container.Panel2.Controls.Add(this.StatusLabel);
            this.Main_split_container.Panel2.Controls.Add(this.NumberCitiesLabel);
            this.Main_split_container.Size = new System.Drawing.Size(728, 581);
            this.Main_split_container.SplitterDistance = 501;
            this.Main_split_container.SplitterWidth = 10;
            this.Main_split_container.TabIndex = 19;
            // 
            // PictureBox_PanellTool
            // 
            this.PictureBox_PanellTool.BackColor = System.Drawing.Color.Silver;
            this.PictureBox_PanellTool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox_PanellTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_PanellTool.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.PictureBox_PanellTool.IsSplitterFixed = true;
            this.PictureBox_PanellTool.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_PanellTool.Name = "PictureBox_PanellTool";
            // 
            // PictureBox_PanellTool.Panel1
            // 
            this.PictureBox_PanellTool.Panel1.Controls.Add(this.tourDiagram);
            // 
            // PictureBox_PanellTool.Panel2
            // 
            this.PictureBox_PanellTool.Panel2.BackColor = System.Drawing.Color.Silver;
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.Settings_panel);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.City_XML_File_name);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.Start_button_panel);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.populationSizeTextBox);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.PopulationSizeLabel);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.groupSizeTextBox);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.groupSizeLabel);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.mutationLabel);
            this.PictureBox_PanellTool.Panel2.Controls.Add(this.mutationTextBox);
            this.PictureBox_PanellTool.Size = new System.Drawing.Size(728, 501);
            this.PictureBox_PanellTool.SplitterDistance = 593;
            this.PictureBox_PanellTool.SplitterWidth = 1;
            this.PictureBox_PanellTool.TabIndex = 19;
            // 
            // Settings_panel
            // 
            this.Settings_panel.Controls.Add(this.maxGenerationTextBox);
            this.Settings_panel.Controls.Add(this.maxGenerationLabel);
            this.Settings_panel.Controls.Add(this.CloseCityOddsTextBox);
            this.Settings_panel.Controls.Add(this.NumberCloseCitiesLabel);
            this.Settings_panel.Controls.Add(this.randomSeedTextBox);
            this.Settings_panel.Controls.Add(this.NumberCloseCitiesTextBox);
            this.Settings_panel.Controls.Add(this.CloseCityOddsLabel);
            this.Settings_panel.Controls.Add(this.randomSeedLabel);
            this.Settings_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_panel.Location = new System.Drawing.Point(0, 0);
            this.Settings_panel.Name = "Settings_panel";
            this.Settings_panel.Size = new System.Drawing.Size(130, 231);
            this.Settings_panel.TabIndex = 1;
            // 
            // City_XML_File_name
            // 
            this.City_XML_File_name.Controls.Add(this.button1);
            this.City_XML_File_name.Controls.Add(this.fileNameLabel);
            this.City_XML_File_name.Controls.Add(this.fileNameTextBox);
            this.City_XML_File_name.Controls.Add(this.selectFileButton);
            this.City_XML_File_name.Controls.Add(this.openCityListButton);
            this.City_XML_File_name.Controls.Add(this.clearCityListButton);
            this.City_XML_File_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.City_XML_File_name.Location = new System.Drawing.Point(0, 231);
            this.City_XML_File_name.Name = "City_XML_File_name";
            this.City_XML_File_name.Size = new System.Drawing.Size(130, 194);
            this.City_XML_File_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Create_kml_Click);
            // 
            // Start_button_panel
            // 
            this.Start_button_panel.Controls.Add(this.StartButton);
            this.Start_button_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Start_button_panel.Location = new System.Drawing.Point(0, 425);
            this.Start_button_panel.Name = "Start_button_panel";
            this.Start_button_panel.Size = new System.Drawing.Size(130, 72);
            this.Start_button_panel.TabIndex = 2;
            // 
            // Save_kml_file
            // 
            this.Save_kml_file.Filter = "\"KML file (* .kml)| * .kml\"";
            // 
            // TspForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 581);
            this.Controls.Add(this.Main_split_container);
            this.Controls.Add(this.NumberCitiesValue);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TspForm";
            this.Text = "Traveling Salesman Problem";
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).EndInit();
            this.Main_split_container.Panel1.ResumeLayout(false);
            this.Main_split_container.Panel2.ResumeLayout(false);
            this.Main_split_container.Panel2.PerformLayout();
            this.Main_split_container.ResumeLayout(false);
            this.PictureBox_PanellTool.Panel1.ResumeLayout(false);
            this.PictureBox_PanellTool.Panel2.ResumeLayout(false);
            this.PictureBox_PanellTool.Panel2.PerformLayout();
            this.PictureBox_PanellTool.ResumeLayout(false);
            this.Settings_panel.ResumeLayout(false);
            this.Settings_panel.PerformLayout();
            this.City_XML_File_name.ResumeLayout(false);
            this.City_XML_File_name.PerformLayout();
            this.Start_button_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tourDiagram;
        private System.Windows.Forms.TextBox populationSizeTextBox;
        private System.Windows.Forms.Label PopulationSizeLabel;
        private System.Windows.Forms.Label lastIterationLabel;
        private System.Windows.Forms.Label lastIterationValue;
        private System.Windows.Forms.Label lastTourLabel;
        private System.Windows.Forms.Label lastFitnessValue;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label maxGenerationLabel;
        private System.Windows.Forms.TextBox maxGenerationTextBox;
        private System.Windows.Forms.Label groupSizeLabel;
        private System.Windows.Forms.TextBox groupSizeTextBox;
        private System.Windows.Forms.TextBox randomSeedTextBox;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Button openCityListButton;
        private System.Windows.Forms.Button clearCityListButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox mutationTextBox;
        private System.Windows.Forms.Label mutationLabel;
        private System.Windows.Forms.Label NumberCitiesLabel;
        private System.Windows.Forms.Label NumberCitiesValue;
        private System.Windows.Forms.TextBox NumberCloseCitiesTextBox;
        private System.Windows.Forms.Label NumberCloseCitiesLabel;
        private System.Windows.Forms.TextBox CloseCityOddsTextBox;
        private System.Windows.Forms.Label CloseCityOddsLabel;
        private System.Windows.Forms.SplitContainer Main_split_container;
        private System.Windows.Forms.SplitContainer PictureBox_PanellTool;
        private System.Windows.Forms.Panel City_XML_File_name;
        private System.Windows.Forms.Panel Start_button_panel;
        private System.Windows.Forms.Panel Settings_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog Save_kml_file;
    }
}

