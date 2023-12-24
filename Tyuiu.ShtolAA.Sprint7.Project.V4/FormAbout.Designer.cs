
namespace Tyuiu.ShtolAA.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_SAA = new System.Windows.Forms.TextBox();
            this.buttonOk_SAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxInfo_SAA
            // 
            this.textBoxInfo_SAA.Location = new System.Drawing.Point(162, 12);
            this.textBoxInfo_SAA.Multiline = true;
            this.textBoxInfo_SAA.Name = "textBoxInfo_SAA";
            this.textBoxInfo_SAA.ReadOnly = true;
            this.textBoxInfo_SAA.Size = new System.Drawing.Size(375, 181);
            this.textBoxInfo_SAA.TabIndex = 1;
            this.textBoxInfo_SAA.Text = resources.GetString("textBoxInfo_SAA.Text");
            // 
            // buttonOk_SAA
            // 
            this.buttonOk_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk_SAA.Location = new System.Drawing.Point(438, 199);
            this.buttonOk_SAA.Name = "buttonOk_SAA";
            this.buttonOk_SAA.Size = new System.Drawing.Size(99, 32);
            this.buttonOk_SAA.TabIndex = 2;
            this.buttonOk_SAA.Text = "Ок";
            this.buttonOk_SAA.UseVisualStyleBackColor = true;
            this.buttonOk_SAA.Click += new System.EventHandler(this.buttonOk_SAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 242);
            this.Controls.Add(this.buttonOk_SAA);
            this.Controls.Add(this.textBoxInfo_SAA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(567, 289);
            this.MinimumSize = new System.Drawing.Size(567, 289);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxInfo_SAA;
        private System.Windows.Forms.Button buttonOk_SAA;
    }
}