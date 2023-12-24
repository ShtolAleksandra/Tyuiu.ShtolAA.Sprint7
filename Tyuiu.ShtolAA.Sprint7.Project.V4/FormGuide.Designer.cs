
namespace Tyuiu.ShtolAA.Sprint7.Project.V4
{
    partial class FormGuide
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
            this.buttonOK_SAA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK_SAA
            // 
            this.buttonOK_SAA.AutoSize = true;
            this.buttonOK_SAA.Location = new System.Drawing.Point(262, 180);
            this.buttonOK_SAA.MaximumSize = new System.Drawing.Size(116, 31);
            this.buttonOK_SAA.MinimumSize = new System.Drawing.Size(116, 31);
            this.buttonOK_SAA.Name = "buttonOK_SAA";
            this.buttonOK_SAA.Size = new System.Drawing.Size(116, 31);
            this.buttonOK_SAA.TabIndex = 0;
            this.buttonOK_SAA.Text = "Ok";
            this.buttonOK_SAA.UseVisualStyleBackColor = true;
            this.buttonOK_SAA.Click += new System.EventHandler(this.buttonOK_SAA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(366, 159);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Руководство пользователя:\r\n\r\n1) введение\r\n2)назначение и условие применения\r\n3)по" +
    "дготовка к работе\r\n4)описание операций\r\n5)аварийные ситуации\r\n6) рекоминдации по" +
    " освоению\r\n\r\n\r\n\r\n";
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(397, 223);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOK_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Краткое руководство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_SAA;
        private System.Windows.Forms.TextBox textBox1;
    }
}