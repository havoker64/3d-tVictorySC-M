namespace _3d_t_Victory_SC_M
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tlMain = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tlOptions = new TableLayoutPanel();
            btnImport = new Button();
            btnCreate = new Button();
            btnProfile = new Button();
            tlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlOptions.SuspendLayout();
            SuspendLayout();
            // 
            // tlMain
            // 
            tlMain.ColumnCount = 3;
            tlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.59243F));
            tlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.40757F));
            tlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 271F));
            tlMain.Controls.Add(pictureBox1, 1, 0);
            tlMain.Controls.Add(tlOptions, 1, 2);
            tlMain.Location = new Point(23, 28);
            tlMain.Name = "tlMain";
            tlMain.RowCount = 4;
            tlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 86.07595F));
            tlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.92405F));
            tlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 358F));
            tlMain.Size = new Size(959, 591);
            tlMain.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tlOptions
            // 
            tlOptions.ColumnCount = 5;
            tlOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.31056F));
            tlOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.68944F));
            tlOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tlOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tlOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlOptions.Controls.Add(btnImport, 2, 0);
            tlOptions.Controls.Add(btnCreate, 0, 0);
            tlOptions.Controls.Add(btnProfile, 4, 0);
            tlOptions.Location = new Point(275, 145);
            tlOptions.Name = "tlOptions";
            tlOptions.RowCount = 1;
            tlOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlOptions.Size = new Size(406, 84);
            tlOptions.TabIndex = 1;
            // 
            // btnImport
            // 
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Image = (Image)resources.GetObject("btnImport.Image");
            btnImport.Location = new Point(166, 3);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 75);
            btnImport.TabIndex = 2;
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Image = (Image)resources.GetObject("btnCreate.Image");
            btnCreate.Location = new Point(3, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 75);
            btnCreate.TabIndex = 0;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(328, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(75, 75);
            btnProfile.TabIndex = 3;
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 623);
            Controls.Add(tlMain);
            Name = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            tlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlMain;
        private PictureBox pictureBox1;
        private TableLayoutPanel tlOptions;
        private Button btnCreate;
        private Button btnImport;
        private Button btnProfile;
    }
}
