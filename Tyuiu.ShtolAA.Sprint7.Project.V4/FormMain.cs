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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void panelbasic_SAA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddition_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOpenFile_SAA.Rows.Add();
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
