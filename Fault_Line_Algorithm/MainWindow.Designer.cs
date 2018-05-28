namespace Fault_Line_Algorithm
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnGenerateMap = new System.Windows.Forms.Button();
            this.pctbxHeightmap = new System.Windows.Forms.PictureBox();
            this.txtbxNumOfIterations = new System.Windows.Forms.TextBox();
            this.lblNumOfIterations = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxMapResolution = new System.Windows.Forms.ComboBox();
            this.lblMapResolution = new System.Windows.Forms.Label();
            this.txtbxTestOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxHeightmap)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateMap
            // 
            this.btnGenerateMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateMap.Location = new System.Drawing.Point(458, 297);
            this.btnGenerateMap.Name = "btnGenerateMap";
            this.btnGenerateMap.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateMap.TabIndex = 0;
            this.btnGenerateMap.Text = "Generate";
            this.btnGenerateMap.UseVisualStyleBackColor = true;
            this.btnGenerateMap.Click += new System.EventHandler(this.BtnGenerateMap_Click);
            // 
            // pctbxHeightmap
            // 
            this.pctbxHeightmap.Location = new System.Drawing.Point(12, 28);
            this.pctbxHeightmap.Name = "pctbxHeightmap";
            this.pctbxHeightmap.Size = new System.Drawing.Size(256, 256);
            this.pctbxHeightmap.TabIndex = 1;
            this.pctbxHeightmap.TabStop = false;
            // 
            // txtbxNumOfIterations
            // 
            this.txtbxNumOfIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxNumOfIterations.Location = new System.Drawing.Point(458, 265);
            this.txtbxNumOfIterations.Name = "txtbxNumOfIterations";
            this.txtbxNumOfIterations.Size = new System.Drawing.Size(75, 20);
            this.txtbxNumOfIterations.TabIndex = 2;
            // 
            // lblNumOfIterations
            // 
            this.lblNumOfIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumOfIterations.AutoSize = true;
            this.lblNumOfIterations.Location = new System.Drawing.Point(350, 272);
            this.lblNumOfIterations.Name = "lblNumOfIterations";
            this.lblNumOfIterations.Size = new System.Drawing.Size(102, 13);
            this.lblNumOfIterations.TabIndex = 3;
            this.lblNumOfIterations.Text = "Number of Iterations";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(545, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.toolStripMenuFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFile.Image")));
            this.toolStripMenuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripMenuFile.Text = "File";
            this.toolStripMenuFile.ToolTipText = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // cbxMapResolution
            // 
            this.cbxMapResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMapResolution.FormattingEnabled = true;
            this.cbxMapResolution.Items.AddRange(new object[] {
            "256x256",
            "512x512",
            "1024x1024",
            "2048x2048"});
            this.cbxMapResolution.Location = new System.Drawing.Point(458, 237);
            this.cbxMapResolution.Name = "cbxMapResolution";
            this.cbxMapResolution.Size = new System.Drawing.Size(75, 21);
            this.cbxMapResolution.TabIndex = 5;
            // 
            // lblMapResolution
            // 
            this.lblMapResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMapResolution.AutoSize = true;
            this.lblMapResolution.Location = new System.Drawing.Point(346, 245);
            this.lblMapResolution.Name = "lblMapResolution";
            this.lblMapResolution.Size = new System.Drawing.Size(106, 13);
            this.lblMapResolution.TabIndex = 6;
            this.lblMapResolution.Text = "Heightmap resolution";
            // 
            // txtbxTestOutput
            // 
            this.txtbxTestOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxTestOutput.Location = new System.Drawing.Point(349, 28);
            this.txtbxTestOutput.Multiline = true;
            this.txtbxTestOutput.Name = "txtbxTestOutput";
            this.txtbxTestOutput.Size = new System.Drawing.Size(184, 203);
            this.txtbxTestOutput.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.txtbxTestOutput);
            this.Controls.Add(this.lblMapResolution);
            this.Controls.Add(this.cbxMapResolution);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblNumOfIterations);
            this.Controls.Add(this.txtbxNumOfIterations);
            this.Controls.Add(this.pctbxHeightmap);
            this.Controls.Add(this.btnGenerateMap);
            this.Name = "MainWindow";
            this.Text = "Fault Line Heightmap Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pctbxHeightmap)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateMap;
        private System.Windows.Forms.PictureBox pctbxHeightmap;
        private System.Windows.Forms.TextBox txtbxNumOfIterations;
        private System.Windows.Forms.Label lblNumOfIterations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxMapResolution;
        private System.Windows.Forms.Label lblMapResolution;
        private System.Windows.Forms.TextBox txtbxTestOutput;
    }
}

