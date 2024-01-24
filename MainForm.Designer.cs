using System.Reflection;

namespace HraZivota
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
            //pictureBox1 = new PictureBox();
            //((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            //SuspendLayout();
            //// 
            //// pictureBox1
            //// 
            //pictureBox1.Location = new Point(2, 3);
            //pictureBox1.Name = "pictureBox1";
            //pictureBox1.Size = new Size(800, 800);
            //pictureBox1.TabIndex = 0;
            //pictureBox1.TabStop = false;
            //pictureBox1.Paint += pictureBox1_Paint;
            //// 
            //// Form1
            //// 
            this.BackColor = Color.White;
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            this.Visible = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(Parameters.meshWidth*2+45, Parameters.meshHeight*2+6);
            //Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hra života - rabbits";
            //((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        //private PictureBox pictureBox1;
    }
}
