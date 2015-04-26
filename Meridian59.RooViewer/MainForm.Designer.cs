﻿namespace Meridian59.RooViewer
{
    partial class MainForm
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.grpBoxSectors = new System.Windows.Forms.GroupBox();
            this.grpBoxSides = new System.Windows.Forms.GroupBox();
            this.grpBoxWalls = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.viewerRooSectors = new Meridian59.RooViewer.UI.RooSectorsViewer();
            this.viewerRooSides = new Meridian59.RooViewer.UI.RooSidesViewer();
            this.viewerRooWalls = new Meridian59.RooViewer.UI.RooWallsViewer();
            this.viewerRooSubSectors = new Meridian59.RooViewer.UI.RooSubSectorsViewer();
            this.viewerRooVertices = new Meridian59.RooViewer.UI.RooVerticesViewer();
            this.viewerRooPartitionLines = new Meridian59.RooViewer.UI.RooPartitionLinesViewer();
            this.map = new Meridian59.RooViewer.UI.Map();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpBoxSectors.SuspendLayout();
            this.grpBoxSides.SuspendLayout();
            this.grpBoxWalls.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 24);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.grpBoxSectors);
            this.splitMain.Panel1.Controls.Add(this.grpBoxSides);
            this.splitMain.Panel1.Controls.Add(this.grpBoxWalls);
            this.splitMain.Panel1.Controls.Add(this.groupBox5);
            this.splitMain.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.groupBoxMap);
            this.splitMain.Size = new System.Drawing.Size(1424, 788);
            this.splitMain.SplitterDistance = 621;
            this.splitMain.TabIndex = 0;
            // 
            // grpBoxSectors
            // 
            this.grpBoxSectors.Controls.Add(this.viewerRooSectors);
            this.grpBoxSectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxSectors.Location = new System.Drawing.Point(0, 566);
            this.grpBoxSectors.Name = "grpBoxSectors";
            this.grpBoxSectors.Size = new System.Drawing.Size(621, 222);
            this.grpBoxSectors.TabIndex = 1;
            this.grpBoxSectors.TabStop = false;
            this.grpBoxSectors.Text = "Sectors";
            // 
            // grpBoxSides
            // 
            this.grpBoxSides.Controls.Add(this.viewerRooSides);
            this.grpBoxSides.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxSides.Location = new System.Drawing.Point(0, 410);
            this.grpBoxSides.Name = "grpBoxSides";
            this.grpBoxSides.Size = new System.Drawing.Size(621, 156);
            this.grpBoxSides.TabIndex = 2;
            this.grpBoxSides.TabStop = false;
            this.grpBoxSides.Text = "Sides";
            // 
            // grpBoxWalls
            // 
            this.grpBoxWalls.Controls.Add(this.viewerRooWalls);
            this.grpBoxWalls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxWalls.Location = new System.Drawing.Point(0, 256);
            this.grpBoxWalls.Name = "grpBoxWalls";
            this.grpBoxWalls.Size = new System.Drawing.Size(621, 154);
            this.grpBoxWalls.TabIndex = 0;
            this.grpBoxWalls.TabStop = false;
            this.grpBoxWalls.Text = "Walls";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.splitContainer2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(621, 128);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BSP leafs";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.viewerRooSubSectors);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.viewerRooVertices);
            this.splitContainer2.Size = new System.Drawing.Size(615, 109);
            this.splitContainer2.SplitterDistance = 426;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.viewerRooPartitionLines);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BSP splitters";
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.map);
            this.groupBoxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMap.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(799, 788);
            this.groupBoxMap.TabIndex = 1;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1424, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnMenuFileOpen);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OnOpenFileDialogFileOk);
            // 
            // viewerRooSectors
            // 
            this.viewerRooSectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRooSectors.Location = new System.Drawing.Point(3, 16);
            this.viewerRooSectors.Name = "viewerRooSectors";
            this.viewerRooSectors.Size = new System.Drawing.Size(615, 203);
            this.viewerRooSectors.TabIndex = 0;
            this.viewerRooSectors.SelectedItemChanged += new System.EventHandler(this.OnViewerRooSectorsSelectedItemChanged);
            // 
            // viewerRooSides
            // 
            this.viewerRooSides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRooSides.Location = new System.Drawing.Point(3, 16);
            this.viewerRooSides.Name = "viewerRooSides";
            this.viewerRooSides.Size = new System.Drawing.Size(615, 137);
            this.viewerRooSides.TabIndex = 0;
            this.viewerRooSides.SelectedItemChanged += new System.EventHandler(this.OnViewerRooSidesSelectedItemChanged);
            // 
            // viewerRooWalls
            // 
            this.viewerRooWalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRooWalls.Location = new System.Drawing.Point(3, 16);
            this.viewerRooWalls.Name = "viewerRooWalls";
            this.viewerRooWalls.Size = new System.Drawing.Size(615, 135);
            this.viewerRooWalls.TabIndex = 0;
            this.viewerRooWalls.SelectedItemChanged += new System.EventHandler(this.OnViewerRooWallsSelectedItemChanged);
            // 
            // viewerRooSubSectors
            // 
            this.viewerRooSubSectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRooSubSectors.Location = new System.Drawing.Point(0, 0);
            this.viewerRooSubSectors.Name = "viewerRooSubSectors";
            this.viewerRooSubSectors.Size = new System.Drawing.Size(426, 109);
            this.viewerRooSubSectors.TabIndex = 0;
            this.viewerRooSubSectors.SelectedItemChanged += new System.EventHandler(this.OnViewerRooSubSectorsSelectedItemChanged);
            // 
            // viewerRooVertices
            // 
            this.viewerRooVertices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRooVertices.Location = new System.Drawing.Point(0, 0);
            this.viewerRooVertices.Name = "viewerRooVertices";
            this.viewerRooVertices.Size = new System.Drawing.Size(185, 109);
            this.viewerRooVertices.TabIndex = 0;
            // 
            // viewerRooPartitionLines
            // 
            this.viewerRooPartitionLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerRooPartitionLines.Location = new System.Drawing.Point(3, 16);
            this.viewerRooPartitionLines.Name = "viewerRooPartitionLines";
            this.viewerRooPartitionLines.Size = new System.Drawing.Size(615, 109);
            this.viewerRooPartitionLines.TabIndex = 0;
            this.viewerRooPartitionLines.SelectedItemChanged += new System.EventHandler(this.OnViewerRooPartitionLinesSelectedItemChanged);
            // 
            // map
            // 
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Location = new System.Drawing.Point(3, 16);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(793, 769);
            this.map.TabIndex = 0;
            this.map.SelectedSubSectorChanged += new System.EventHandler(this.OnMapSelectedSubSectorChanged);
            this.map.SelectedSectorChanged += new System.EventHandler(this.OnMapSelectedSectorChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 812);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "RooViewer";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpBoxSectors.ResumeLayout(false);
            this.grpBoxSides.ResumeLayout(false);
            this.grpBoxWalls.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBoxMap.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpBoxWalls;
        private System.Windows.Forms.GroupBox grpBoxSectors;
        private System.Windows.Forms.GroupBox grpBoxSides;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private UI.Map map;
        private UI.RooWallsViewer viewerRooWalls;
        private UI.RooSidesViewer viewerRooSides;
        private UI.RooSectorsViewer viewerRooSectors;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private UI.RooPartitionLinesViewer viewerRooPartitionLines;
        private UI.RooSubSectorsViewer viewerRooSubSectors;
        private UI.RooVerticesViewer viewerRooVertices;
        
    }
}