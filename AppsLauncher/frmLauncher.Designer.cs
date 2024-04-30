namespace AppsLauncher
{
    partial class frmLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
            picNotepad = new PictureBox();
            picPaint = new PictureBox();
            picWord = new PictureBox();
            picCMD = new PictureBox();
            picExit = new PictureBox();
            picChrome = new PictureBox();
            picFileExplorer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picNotepad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPaint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCMD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChrome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFileExplorer).BeginInit();
            SuspendLayout();
            // 
            // picNotepad
            // 
            picNotepad.Image = (Image)resources.GetObject("picNotepad.Image");
            picNotepad.Location = new Point(12, 12);
            picNotepad.Name = "picNotepad";
            picNotepad.Size = new Size(90, 69);
            picNotepad.SizeMode = PictureBoxSizeMode.Zoom;
            picNotepad.TabIndex = 0;
            picNotepad.TabStop = false;
            picNotepad.Click += picNotepad_Click;
            // 
            // picPaint
            // 
            picPaint.Image = (Image)resources.GetObject("picPaint.Image");
            picPaint.Location = new Point(120, 12);
            picPaint.Name = "picPaint";
            picPaint.Size = new Size(90, 69);
            picPaint.SizeMode = PictureBoxSizeMode.Zoom;
            picPaint.TabIndex = 1;
            picPaint.TabStop = false;
            picPaint.Click += picPaint_Click;
            // 
            // picWord
            // 
            picWord.Image = (Image)resources.GetObject("picWord.Image");
            picWord.Location = new Point(228, 12);
            picWord.Name = "picWord";
            picWord.Size = new Size(90, 69);
            picWord.SizeMode = PictureBoxSizeMode.Zoom;
            picWord.TabIndex = 2;
            picWord.TabStop = false;
            picWord.Click += picWord_Click;
            // 
            // picCMD
            // 
            picCMD.Image = (Image)resources.GetObject("picCMD.Image");
            picCMD.Location = new Point(336, 12);
            picCMD.Name = "picCMD";
            picCMD.Size = new Size(90, 69);
            picCMD.SizeMode = PictureBoxSizeMode.Zoom;
            picCMD.TabIndex = 3;
            picCMD.TabStop = false;
            picCMD.Click += picCMD_Click;
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(660, 12);
            picExit.Name = "picExit";
            picExit.Size = new Size(90, 69);
            picExit.SizeMode = PictureBoxSizeMode.Zoom;
            picExit.TabIndex = 4;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // picChrome
            // 
            picChrome.Image = (Image)resources.GetObject("picChrome.Image");
            picChrome.Location = new Point(444, 12);
            picChrome.Name = "picChrome";
            picChrome.Size = new Size(90, 69);
            picChrome.SizeMode = PictureBoxSizeMode.Zoom;
            picChrome.TabIndex = 5;
            picChrome.TabStop = false;
            picChrome.Click += picChrome_Click;
            // 
            // picFileExplorer
            // 
            picFileExplorer.Image = (Image)resources.GetObject("picFileExplorer.Image");
            picFileExplorer.Location = new Point(552, 12);
            picFileExplorer.Name = "picFileExplorer";
            picFileExplorer.Size = new Size(90, 69);
            picFileExplorer.SizeMode = PictureBoxSizeMode.Zoom;
            picFileExplorer.TabIndex = 6;
            picFileExplorer.TabStop = false;
            picFileExplorer.Click += picFileExplorer_Click;
            // 
            // frmLauncher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 93);
            ControlBox = false;
            Controls.Add(picFileExplorer);
            Controls.Add(picChrome);
            Controls.Add(picExit);
            Controls.Add(picCMD);
            Controls.Add(picWord);
            Controls.Add(picPaint);
            Controls.Add(picNotepad);
            Name = "frmLauncher";
            Text = "Apps Launcher";
            ((System.ComponentModel.ISupportInitialize)picNotepad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPaint).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCMD).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChrome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFileExplorer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picNotepad;
        private PictureBox picPaint;
        private PictureBox picWord;
        private PictureBox picCMD;
        private PictureBox picExit;
        private PictureBox picChrome;
        private PictureBox picFileExplorer;
    }
}
