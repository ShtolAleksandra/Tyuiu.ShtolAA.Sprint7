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
            openFileDialogData_SAA.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static string openFilePath;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();


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

        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFile_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogData_SAA.ShowDialog();
                openFilePath = openFileDialogData_SAA.FileName;

                matrix = ds.LoadDataFromFile(openFilePath);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewOpenFile_SAA.Rows.Clear();
                dataGridViewOpenFile_SAA.Columns.Clear();
                dataGridViewOpenFile_SAA.RowCount = rows + 1;
                dataGridViewOpenFile_SAA.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                    }
                }
                this.dataGridViewOpenFile_SAA.DefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridViewOpenFile_SAA.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttoncharts_SAA_Click(object sender, EventArgs e)
        {
            FormСharts formCharts = new FormСharts();
            formCharts.Show();
        }

        private void buttonguide_SAA_Click(object sender, EventArgs e)
        {
            
            FormGuide formGuide = new FormGuide();
            formGuide.Show();
        }

        private void buttonguide_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_SAA.SetToolTip(buttonguide_SAA, "Открыть краткое руководство");
        }

        private void buttonInfo_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_SAA.SetToolTip(buttonInfo_SAA, "Открыть  информацию о разработчике");
        }

        private void buttoncharts_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_SAA.SetToolTip(buttoncharts_SAA, "Открыть графики");
        }

        private void buttonFile_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_SAA.SetToolTip(buttonFile_SAA, "Открыть файл");
        }

        private void textBoxMax_SAA_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void buttonFiltering_SAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_SAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                int nad = -1;
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                        {
                            nad = j;
                            break;
                        }
                    }
                    if (nad > -1) break;
                }
                if (nad > -1)
                {
                    if (dataGridViewOpenFile_SAA.Rows[0].Cells[nad].Selected == true) MessageBox.Show("Первую строку нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var result = MessageBox.Show($"{"Удалить данную строку?" + "\r"}{"Ее невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int k = -1; int udal = 0;
                            for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[nad].Selected == true)
                                {
                                    k = i;
                                    break;
                                }
                                if (k > -1) break;
                            }
                            for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[nad].Selected == true) udal++;
                            }
                            for (int r = 0; r < udal; r++) dataGridViewOpenFile_SAA.Rows.Remove(dataGridViewOpenFile_SAA.Rows[k]);
                            for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                    }
                }
                else MessageBox.Show("Выберите строку, которую ходите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSave_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_SAA.SetToolTip(buttonSave_SAA, "Сохранить файл");
        }

        static string[,] mtrxSearch;
        private void textBoxSearch_SAA_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                mtrxSearch = new string[dataGridViewOpenFile_SAA.RowCount, dataGridViewOpenFile_SAA.ColumnCount];
                for (int i = 0; i < mtrxSearch.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mtrxSearch.GetUpperBound(1); j++)
                    {
                        mtrxSearch[i, j] = Convert.ToString(dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value);
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                    }
                }

                textBoxKolvo_SAA.Text = "";
                textBoxSum_SAA.Text = "";
                textBoxaverage_SAA.Text = "";
                textBoxmin_SAA.Text = "";
                textBoxMax_SAA.Text = "";
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxSearch_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_SAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < mtrxSearch.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < mtrxSearch.GetUpperBound(1); j++)
                    {
                        if (mtrxSearch[i, j] != null)
                        {
                            string elmnt = mtrxSearch[i, j].ToLower();
                            if (elmnt.Contains(textBoxSearch_SAA.Text.ToLower())) dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = true;
                        }
                    }
                }
            }
        }
        static string[,] mtrxSort;
        static int trip = 0;
        private void buttonSorting_SAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0 && trip != 0)
            {
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value = mtrxSort[i, j];
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                    }
                }
            }
            else if (dataGridViewOpenFile_SAA.RowCount != 0 && trip == 0) MessageBox.Show("Надо нажимать на пустое поле ввода сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxSort_SAA_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void buttonSave_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogProject_SAA.FileName = "NewFileC#.csv";
                saveFileDialogProject_SAA.InitialDirectory = @"C:\Users\user\Desktop";
                if (saveFileDialogProject_SAA.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogProject_SAA.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewOpenFile_SAA.RowCount;
                    int columns = dataGridViewOpenFile_SAA.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(",");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
