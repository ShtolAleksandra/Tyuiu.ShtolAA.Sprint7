
namespace Tyuiu.ShtolAA.Sprint7.Project.V4
{
    partial class FormСharts
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
            this.buttonDel_SAA = new System.Windows.Forms.Button();
            this.buttonBuild_SAA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDel_SAA
            // 
            this.buttonDel_SAA.Location = new System.Drawing.Point(880, 449);
            this.buttonDel_SAA.Name = "buttonDel_SAA";
            this.buttonDel_SAA.Size = new System.Drawing.Size(177, 42);
            this.buttonDel_SAA.TabIndex = 0;
            this.buttonDel_SAA.Text = "Удалить график";
            this.buttonDel_SAA.UseVisualStyleBackColor = true;
            // 
            // buttonBuild_SAA
            // 
            this.buttonBuild_SAA.Location = new System.Drawing.Point(880, 509);
            this.buttonBuild_SAA.Name = "buttonBuild_SAA";
            this.buttonBuild_SAA.Size = new System.Drawing.Size(177, 42);
            this.buttonBuild_SAA.TabIndex = 1;
            this.buttonBuild_SAA.Text = "Построить график";
            this.buttonBuild_SAA.UseVisualStyleBackColor = true;
            // 
            // FormСharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 563);
            this.Controls.Add(this.buttonBuild_SAA);
            this.Controls.Add(this.buttonDel_SAA);
            this.Name = "FormСharts";
            this.Text = "Графики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDel_SAA;
        private System.Windows.Forms.Button buttonBuild_SAA;
    }
}