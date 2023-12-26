using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShtolAA.Sprint7.Project.V4.Lib;


namespace Tyuiu.ShtolAA.Sprint7.Project.V4
{
    public partial class FormСharts : Form
    {
        public FormСharts()
        {
            InitializeComponent();
         
        }


        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                buttonDel_SAA.Visible = true;
                buttonBuild_SAA.Visible = true;
                buttonOpenFile_SAA.Visible = true;
              

                openFileDialogProject_SAA.ShowDialog();
                openFile = openFileDialogProject_SAA.FileName;

                
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_SAA.Rows.Clear();
                dataGridView_SAA.Columns.Clear();
                dataGridView_SAA.RowCount = rows + 1;
                dataGridView_SAA.ColumnCount = columns + 10;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_SAA.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridView_SAA.Rows[i].Cells[j].Selected = false;
                    }
                }
                this.dataGridView_SAA.DefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridView_SAA.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
