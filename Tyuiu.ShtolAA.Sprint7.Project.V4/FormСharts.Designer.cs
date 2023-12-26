
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormСharts));
            this.buttonDel_SAA = new System.Windows.Forms.Button();
            this.buttonBuild_SAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SAA = new System.Windows.Forms.Button();
            this.openFileDialogProject_SAA = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_SAA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel_SAA
            // 
            this.buttonDel_SAA.Location = new System.Drawing.Point(1012, 448);
            this.buttonDel_SAA.Name = "buttonDel_SAA";
            this.buttonDel_SAA.Size = new System.Drawing.Size(177, 42);
            this.buttonDel_SAA.TabIndex = 0;
            this.buttonDel_SAA.Text = "Удалить график";
            this.buttonDel_SAA.UseVisualStyleBackColor = true;
            // 
            // buttonBuild_SAA
            // 
            this.buttonBuild_SAA.Location = new System.Drawing.Point(1012, 496);
            this.buttonBuild_SAA.Name = "buttonBuild_SAA";
            this.buttonBuild_SAA.Size = new System.Drawing.Size(177, 42);
            this.buttonBuild_SAA.TabIndex = 1;
            this.buttonBuild_SAA.Text = "Построить график";
            this.buttonBuild_SAA.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile_SAA
            // 
            this.buttonOpenFile_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SAA.Image")));
            this.buttonOpenFile_SAA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            this.buttonOpenFile_SAA.Size = new System.Drawing.Size(69, 68);
            this.buttonOpenFile_SAA.TabIndex = 2;
            this.buttonOpenFile_SAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SAA.Click += new System.EventHandler(this.buttonOpenFile_SAA_Click);
            // 
            // openFileDialogProject_SAA
            // 
            this.openFileDialogProject_SAA.FileName = "openFileDialog1";
            // 
            // dataGridView_SAA
            // 
            this.dataGridView_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SAA.Location = new System.Drawing.Point(101, 22);
            this.dataGridView_SAA.Name = "dataGridView_SAA";
            this.dataGridView_SAA.RowHeadersWidth = 51;
            this.dataGridView_SAA.RowTemplate.Height = 24;
            this.dataGridView_SAA.Size = new System.Drawing.Size(501, 516);
            this.dataGridView_SAA.TabIndex = 3;
            // 
            // FormСharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 563);
            this.Controls.Add(this.dataGridView_SAA);
            this.Controls.Add(this.buttonOpenFile_SAA);
            this.Controls.Add(this.buttonBuild_SAA);
            this.Controls.Add(this.buttonDel_SAA);
            this.Name = "FormСharts";
            this.Text = "Графики";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDel_SAA;
        private System.Windows.Forms.Button buttonBuild_SAA;
        private System.Windows.Forms.Button buttonOpenFile_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogProject_SAA;
        private System.Windows.Forms.DataGridView dataGridView_SAA;
    }
}