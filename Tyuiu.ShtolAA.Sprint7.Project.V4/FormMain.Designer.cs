
namespace Tyuiu.ShtolAA.Sprint7.Project.V4
{
    partial class FormMain
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
            this.panelbasic_SAA = new System.Windows.Forms.Panel();
            this.panelinformation_SAA = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonFile_SAA = new System.Windows.Forms.Button();
            this.buttoncharts_SAA = new System.Windows.Forms.Button();
            this.buttonguide_SAA = new System.Windows.Forms.Button();
            this.buttonInfo_SAA = new System.Windows.Forms.Button();
            this.panelbasic_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbasic_SAA
            // 
            this.panelbasic_SAA.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelbasic_SAA.Controls.Add(this.buttonInfo_SAA);
            this.panelbasic_SAA.Controls.Add(this.buttonguide_SAA);
            this.panelbasic_SAA.Controls.Add(this.buttoncharts_SAA);
            this.panelbasic_SAA.Controls.Add(this.buttonFile_SAA);
            this.panelbasic_SAA.Controls.Add(this.splitter1);
            this.panelbasic_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbasic_SAA.Location = new System.Drawing.Point(0, 0);
            this.panelbasic_SAA.Name = "panelbasic_SAA";
            this.panelbasic_SAA.Size = new System.Drawing.Size(1354, 711);
            this.panelbasic_SAA.TabIndex = 0;
            // 
            // panelinformation_SAA
            // 
            this.panelinformation_SAA.BackColor = System.Drawing.Color.Wheat;
            this.panelinformation_SAA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinformation_SAA.Location = new System.Drawing.Point(0, 544);
            this.panelinformation_SAA.Name = "panelinformation_SAA";
            this.panelinformation_SAA.Size = new System.Drawing.Size(1354, 167);
            this.panelinformation_SAA.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 711);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // buttonFile_SAA
            // 
            this.buttonFile_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFile_SAA.Location = new System.Drawing.Point(12, 12);
            this.buttonFile_SAA.Name = "buttonFile_SAA";
            this.buttonFile_SAA.Size = new System.Drawing.Size(104, 36);
            this.buttonFile_SAA.TabIndex = 1;
            this.buttonFile_SAA.Text = "Файл";
            this.buttonFile_SAA.UseVisualStyleBackColor = true;
            // 
            // buttoncharts_SAA
            // 
            this.buttoncharts_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncharts_SAA.Location = new System.Drawing.Point(122, 12);
            this.buttoncharts_SAA.Name = "buttoncharts_SAA";
            this.buttoncharts_SAA.Size = new System.Drawing.Size(104, 37);
            this.buttoncharts_SAA.TabIndex = 2;
            this.buttoncharts_SAA.Text = "Графики";
            this.buttoncharts_SAA.UseVisualStyleBackColor = true;
            // 
            // buttonguide_SAA
            // 
            this.buttonguide_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonguide_SAA.Location = new System.Drawing.Point(232, 12);
            this.buttonguide_SAA.Name = "buttonguide_SAA";
            this.buttonguide_SAA.Size = new System.Drawing.Size(169, 37);
            this.buttonguide_SAA.TabIndex = 3;
            this.buttonguide_SAA.Text = "Краткое руководство";
            this.buttonguide_SAA.UseVisualStyleBackColor = true;
            // 
            // buttonInfo_SAA
            // 
            this.buttonInfo_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_SAA.Location = new System.Drawing.Point(407, 12);
            this.buttonInfo_SAA.Name = "buttonInfo_SAA";
            this.buttonInfo_SAA.Size = new System.Drawing.Size(114, 37);
            this.buttonInfo_SAA.TabIndex = 4;
            this.buttonInfo_SAA.Text = "О программе";
            this.buttonInfo_SAA.UseVisualStyleBackColor = true;
            this.buttonInfo_SAA.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 711);
            this.Controls.Add(this.panelinformation_SAA);
            this.Controls.Add(this.panelbasic_SAA);
            this.MinimumSize = new System.Drawing.Size(1372, 758);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.panelbasic_SAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelbasic_SAA;
        private System.Windows.Forms.Panel panelinformation_SAA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonInfo_SAA;
        private System.Windows.Forms.Button buttonguide_SAA;
        private System.Windows.Forms.Button buttoncharts_SAA;
        private System.Windows.Forms.Button buttonFile_SAA;
    }
}

