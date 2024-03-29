﻿
namespace TASK_4_FIXXX
{
    partial class Form1
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
            this.pnlMap = new System.Windows.Forms.Panel();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.map1 = new DotSpatial.Controls.Map();
            this.gbCustom = new System.Windows.Forms.GroupBox();
            this.gbShapeAttribute = new System.Windows.Forms.GroupBox();
            this.gbCustomAttribute = new System.Windows.Forms.GroupBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.btnsetFont = new System.Windows.Forms.Button();
            this.btnsetColor = new System.Windows.Forms.Button();
            this.cmbFiledName = new System.Windows.Forms.ComboBox();
            this.btnDisplayLabel = new System.Windows.Forms.Button();
            this.lblLabelName = new System.Windows.Forms.Label();
            this.txtCustomAttribute = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMap.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbCustom.SuspendLayout();
            this.gbShapeAttribute.SuspendLayout();
            this.gbCustomAttribute.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMap
            // 
            this.pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMap.Controls.Add(this.map1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(919, 450);
            this.pnlMap.TabIndex = 0;
            // 
            // pnlOperations
            // 
            this.pnlOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOperations.Controls.Add(this.gbCustomAttribute);
            this.pnlOperations.Controls.Add(this.gbShapeAttribute);
            this.pnlOperations.Controls.Add(this.gbCustom);
            this.pnlOperations.Controls.Add(this.menuStrip1);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(320, 450);
            this.pnlOperations.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mapOptionsToolStripMenuItem
            // 
            this.mapOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomToExtendToolStripMenuItem,
            this.panToolStripMenuItem,
            this.measureToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem";
            this.mapOptionsToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.mapOptionsToolStripMenuItem.Text = "MapOptions";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomToExtendToolStripMenuItem
            // 
            this.zoomToExtendToolStripMenuItem.Name = "zoomToExtendToolStripMenuItem";
            this.zoomToExtendToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.zoomToExtendToolStripMenuItem.Text = "Zoom to MaxExtend";
            this.zoomToExtendToolStripMenuItem.Click += new System.EventHandler(this.zoomToExtendToolStripMenuItem_Click);
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.panToolStripMenuItem.Text = "Pan";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // measureToolStripMenuItem
            // 
            this.measureToolStripMenuItem.Name = "measureToolStripMenuItem";
            this.measureToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.measureToolStripMenuItem.Text = "Measure";
            this.measureToolStripMenuItem.Click += new System.EventHandler(this.measureToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.Legend = null;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(915, 446);
            this.map1.TabIndex = 0;
            // 
            // gbCustom
            // 
            this.gbCustom.Controls.Add(this.btnsetColor);
            this.gbCustom.Controls.Add(this.btnsetFont);
            this.gbCustom.Location = new System.Drawing.Point(-1, 52);
            this.gbCustom.Name = "gbCustom";
            this.gbCustom.Size = new System.Drawing.Size(316, 107);
            this.gbCustom.TabIndex = 1;
            this.gbCustom.TabStop = false;
            this.gbCustom.Text = "Set the label properties";
            // 
            // gbShapeAttribute
            // 
            this.gbShapeAttribute.Controls.Add(this.btnDisplayLabel);
            this.gbShapeAttribute.Controls.Add(this.cmbFiledName);
            this.gbShapeAttribute.Controls.Add(this.lblFieldName);
            this.gbShapeAttribute.Location = new System.Drawing.Point(11, 165);
            this.gbShapeAttribute.Name = "gbShapeAttribute";
            this.gbShapeAttribute.Size = new System.Drawing.Size(304, 120);
            this.gbShapeAttribute.TabIndex = 2;
            this.gbShapeAttribute.TabStop = false;
            this.gbShapeAttribute.Text = "Display label from Attribute table";
            // 
            // gbCustomAttribute
            // 
            this.gbCustomAttribute.Controls.Add(this.btnDelete);
            this.gbCustomAttribute.Controls.Add(this.btnSave);
            this.gbCustomAttribute.Controls.Add(this.btnAdd);
            this.gbCustomAttribute.Controls.Add(this.txtCustomAttribute);
            this.gbCustomAttribute.Controls.Add(this.lblLabelName);
            this.gbCustomAttribute.Location = new System.Drawing.Point(11, 312);
            this.gbCustomAttribute.Name = "gbCustomAttribute";
            this.gbCustomAttribute.Size = new System.Drawing.Size(304, 125);
            this.gbCustomAttribute.TabIndex = 3;
            this.gbCustomAttribute.TabStop = false;
            this.gbCustomAttribute.Text = "Custom Attributes for existing shapefile";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(6, 22);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(51, 20);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Fields";
            // 
            // btnsetFont
            // 
            this.btnsetFont.Location = new System.Drawing.Point(18, 16);
            this.btnsetFont.Name = "btnsetFont";
            this.btnsetFont.Size = new System.Drawing.Size(211, 36);
            this.btnsetFont.TabIndex = 0;
            this.btnsetFont.Text = "Set Font Style and Size";
            this.btnsetFont.UseVisualStyleBackColor = true;
            this.btnsetFont.Click += new System.EventHandler(this.btnsetFont_Click);
            // 
            // btnsetColor
            // 
            this.btnsetColor.Location = new System.Drawing.Point(18, 58);
            this.btnsetColor.Name = "btnsetColor";
            this.btnsetColor.Size = new System.Drawing.Size(211, 34);
            this.btnsetColor.TabIndex = 1;
            this.btnsetColor.Text = "Set Color";
            this.btnsetColor.UseVisualStyleBackColor = true;
            this.btnsetColor.Click += new System.EventHandler(this.btnsetColor_Click);
            // 
            // cmbFiledName
            // 
            this.cmbFiledName.FormattingEnabled = true;
            this.cmbFiledName.Location = new System.Drawing.Point(20, 46);
            this.cmbFiledName.Name = "cmbFiledName";
            this.cmbFiledName.Size = new System.Drawing.Size(121, 28);
            this.cmbFiledName.TabIndex = 1;
            // 
            // btnDisplayLabel
            // 
            this.btnDisplayLabel.Location = new System.Drawing.Point(43, 74);
            this.btnDisplayLabel.Name = "btnDisplayLabel";
            this.btnDisplayLabel.Size = new System.Drawing.Size(75, 29);
            this.btnDisplayLabel.TabIndex = 2;
            this.btnDisplayLabel.Text = "Display Labels";
            this.btnDisplayLabel.UseVisualStyleBackColor = true;
            this.btnDisplayLabel.Click += new System.EventHandler(this.btnDisplayLabel_Click);
            // 
            // lblLabelName
            // 
            this.lblLabelName.AutoSize = true;
            this.lblLabelName.Location = new System.Drawing.Point(10, 26);
            this.lblLabelName.Name = "lblLabelName";
            this.lblLabelName.Size = new System.Drawing.Size(92, 20);
            this.lblLabelName.TabIndex = 0;
            this.lblLabelName.Text = "Label name";
            // 
            // txtCustomAttribute
            // 
            this.txtCustomAttribute.Location = new System.Drawing.Point(117, 26);
            this.txtCustomAttribute.Name = "txtCustomAttribute";
            this.txtCustomAttribute.Size = new System.Drawing.Size(148, 26);
            this.txtCustomAttribute.TabIndex = 1;
            this.txtCustomAttribute.TextChanged += new System.EventHandler(this.txtCustomAttribute_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(101, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.pnlMap);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMap.ResumeLayout(false);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCustom.ResumeLayout(false);
            this.gbShapeAttribute.ResumeLayout(false);
            this.gbShapeAttribute.PerformLayout();
            this.gbCustomAttribute.ResumeLayout(false);
            this.gbCustomAttribute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.GroupBox gbCustomAttribute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustomAttribute;
        private System.Windows.Forms.Label lblLabelName;
        private System.Windows.Forms.GroupBox gbShapeAttribute;
        private System.Windows.Forms.Button btnDisplayLabel;
        private System.Windows.Forms.ComboBox cmbFiledName;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.GroupBox gbCustom;
        private System.Windows.Forms.Button btnsetColor;
        private System.Windows.Forms.Button btnsetFont;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToExtendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
    }
}

