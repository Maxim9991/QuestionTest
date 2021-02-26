
namespace QuestionTest
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.lblNameResult = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblgoodresult = new System.Windows.Forms.Label();
            this.lblproc = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTaskProc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Location = new System.Drawing.Point(86, 27);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(45, 15);
            this.lblNameResult.TabIndex = 1;
            this.lblNameResult.Text = "RESULT";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblgoodresult
            // 
            this.lblgoodresult.AutoSize = true;
            this.lblgoodresult.Location = new System.Drawing.Point(22, 196);
            this.lblgoodresult.Name = "lblgoodresult";
            this.lblgoodresult.Size = new System.Drawing.Size(69, 15);
            this.lblgoodresult.TabIndex = 4;
            this.lblgoodresult.Text = "rightanwers";
            // 
            // lblproc
            // 
            this.lblproc.AutoSize = true;
            this.lblproc.Location = new System.Drawing.Point(22, 245);
            this.lblproc.Name = "lblproc";
            this.lblproc.Size = new System.Drawing.Size(17, 15);
            this.lblproc.TabIndex = 5;
            this.lblproc.Text = "%";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(105, 108);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(26, 15);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "test";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Maroon;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.Location = new System.Drawing.Point(31, 82);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(228, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // lblTaskProc
            // 
            this.lblTaskProc.AutoSize = true;
            this.lblTaskProc.Location = new System.Drawing.Point(119, 64);
            this.lblTaskProc.Name = "lblTaskProc";
            this.lblTaskProc.Size = new System.Drawing.Size(77, 15);
            this.lblTaskProc.TabIndex = 8;
            this.lblTaskProc.Text = "%% Proc %%";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 298);
            this.Controls.Add(this.lblTaskProc);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblproc);
            this.Controls.Add(this.lblgoodresult);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblNameResult);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblgoodresult;
        private System.Windows.Forms.Label lblproc;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTaskProc;
    }
}