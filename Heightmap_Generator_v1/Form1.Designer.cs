namespace Heightmap_Generator_v1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbxAlgorithmSelection = new System.Windows.Forms.ComboBox();
            this.lblNumIterations = new System.Windows.Forms.Label();
            this.txtbxNumOfIterations = new System.Windows.Forms.TextBox();
            this.pctbxHeightmap = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbxMapResolution = new System.Windows.Forms.ComboBox();
            this.lblMapResolution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxHeightmap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(595, 452);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // cbxAlgorithmSelection
            // 
            this.cbxAlgorithmSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxAlgorithmSelection.FormattingEnabled = true;
            this.cbxAlgorithmSelection.Items.AddRange(new object[] {
            "Plasma",
            "Fault Line",
            "Diamond-square",
            "Perlin Noise"});
            this.cbxAlgorithmSelection.Location = new System.Drawing.Point(428, 292);
            this.cbxAlgorithmSelection.Name = "cbxAlgorithmSelection";
            this.cbxAlgorithmSelection.Size = new System.Drawing.Size(242, 21);
            this.cbxAlgorithmSelection.TabIndex = 1;
            this.cbxAlgorithmSelection.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblNumIterations
            // 
            this.lblNumIterations.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumIterations.AutoSize = true;
            this.lblNumIterations.Location = new System.Drawing.Point(428, 330);
            this.lblNumIterations.Name = "lblNumIterations";
            this.lblNumIterations.Size = new System.Drawing.Size(101, 13);
            this.lblNumIterations.TabIndex = 2;
            this.lblNumIterations.Text = "Number of iterations";
            // 
            // txtbxNumOfIterations
            // 
            this.txtbxNumOfIterations.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtbxNumOfIterations.Location = new System.Drawing.Point(632, 323);
            this.txtbxNumOfIterations.Name = "txtbxNumOfIterations";
            this.txtbxNumOfIterations.Size = new System.Drawing.Size(38, 20);
            this.txtbxNumOfIterations.TabIndex = 3;
            this.txtbxNumOfIterations.TextChanged += new System.EventHandler(this.NumOfIterations_TextChanged);
            // 
            // pctbxHeightmap
            // 
            this.pctbxHeightmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxHeightmap.Location = new System.Drawing.Point(13, 27);
            this.pctbxHeightmap.Name = "pctbxHeightmap";
            this.pctbxHeightmap.Size = new System.Drawing.Size(409, 419);
            this.pctbxHeightmap.TabIndex = 4;
            this.pctbxHeightmap.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveMapToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openToolStripMenuItem.Text = "Open Empty Map";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveMapToolStripMenuItem.Text = "Save Map";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.SaveMapToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(428, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 259);
            this.textBox2.TabIndex = 6;
            // 
            // cbxMapResolution
            // 
            this.cbxMapResolution.AllowDrop = true;
            this.cbxMapResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxMapResolution.FormattingEnabled = true;
            this.cbxMapResolution.Items.AddRange(new object[] {
            "256x256",
            "512x512",
            "1024x1024",
            "2048x2048"});
            this.cbxMapResolution.Location = new System.Drawing.Point(592, 349);
            this.cbxMapResolution.Name = "cbxMapResolution";
            this.cbxMapResolution.Size = new System.Drawing.Size(78, 21);
            this.cbxMapResolution.TabIndex = 8;
            this.cbxMapResolution.SelectedIndexChanged += new System.EventHandler(this.CbxMapResolution_SelectedIndexChanged);
            // 
            // lblMapResolution
            // 
            this.lblMapResolution.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMapResolution.AutoSize = true;
            this.lblMapResolution.Location = new System.Drawing.Point(428, 357);
            this.lblMapResolution.Name = "lblMapResolution";
            this.lblMapResolution.Size = new System.Drawing.Size(106, 13);
            this.lblMapResolution.TabIndex = 9;
            this.lblMapResolution.Text = "Heightmap resolution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 487);
            this.Controls.Add(this.lblMapResolution);
            this.Controls.Add(this.cbxMapResolution);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pctbxHeightmap);
            this.Controls.Add(this.txtbxNumOfIterations);
            this.Controls.Add(this.lblNumIterations);
            this.Controls.Add(this.cbxAlgorithmSelection);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctbxHeightmap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbxAlgorithmSelection;
        private System.Windows.Forms.Label lblNumIterations;
        private System.Windows.Forms.TextBox txtbxNumOfIterations;
        private System.Windows.Forms.PictureBox pctbxHeightmap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbxMapResolution;
        private System.Windows.Forms.Label lblMapResolution;
    }
}

