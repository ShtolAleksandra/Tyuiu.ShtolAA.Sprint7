﻿using System;
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
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                            {
                                nugno = j;
                                break;
                            }
                        }
                        if (nugno > -1) break;
                    }

                    if (nugno > -1)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[0].Cells[nugno].Selected != true)
                        {
                            double max = -9999999;
                            for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {

                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value = cellValue;
                                        max = Math.Max(Convert.ToDouble(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString()), max);
                                    }
                                }
                            }
                            if (max != -9999999) textBoxMax_SAA.Text = Convert.ToString(max);
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxMax_SAA.Text = "";

                                textBoxSum_SAA.Text = "";
                                textBoxaverage_SAA.Text = "";
                                textBoxmin_SAA.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxMax_SAA.Text = "";

                            textBoxSum_SAA.Text = "";
                            textBoxaverage_SAA.Text = "";
                            textBoxmin_SAA.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonFiltering_SAA_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0 && bip != 0)
            {
                dataGridViewOpenFile_SAA.Rows.Clear();
                dataGridViewOpenFile_SAA.Columns.Clear();
                dataGridViewOpenFile_SAA.RowCount = mtrxFilter.GetUpperBound(0) + 1;
                dataGridViewOpenFile_SAA.ColumnCount = mtrxFilter.GetUpperBound(1) + 1;
                textBoxMax_SAA.Text = Convert.ToString(mtrxFilter.GetUpperBound(0) + 1);
                textBoxmin_SAA.Text = Convert.ToString(mtrxFilter.GetUpperBound(1) + 10);
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value = mtrxFilter[i, j];
                    }
                }
                dataGridViewOpenFile_SAA.AutoResizeColumns();

                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                    }
                }

                textBoxFiltr_SAA.Text = "";
                textBoxKolvo_SAA.Text = "";
                textBoxSum_SAA.Text = "";
                textBoxaverage_SAA.Text = "";
                textBoxmin_SAA.Text = "";
                textBoxMax_SAA.Text = "";
            }
            else if (dataGridViewOpenFile_SAA.RowCount != 0 && bip == 0) MessageBox.Show("Еще не были применены фильтры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                mtrxSort = new string[dataGridViewOpenFile_SAA.RowCount, dataGridViewOpenFile_SAA.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        mtrxSort[i, j] = Convert.ToString(dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value);
                    }
                }
                trip++;

                int vozmogno = 0; int k = -1;
                for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount; j++)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value == null) vozmogno++;
                    }
                    if (vozmogno == dataGridViewOpenFile_SAA.ColumnCount)
                    {
                        k = i;
                        break;
                    }
                    else vozmogno = 0;
                }
                if (k > 0) MessageBox.Show("Пожалуйста, удалите все пустые строки, кроме последней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        static string[,] mtrxFilter;
        static int bip = 0;
        private void buttonFiltering_SAA_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                mtrxFilter = new string[dataGridViewOpenFile_SAA.RowCount, dataGridViewOpenFile_SAA.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        mtrxFilter[i, j] = Convert.ToString(dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value);
                    }
                }
                bip++;
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonFiltering_SAA_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBoxFiltr_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFiltr_SAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int nugno = -1;
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                            {
                                nugno = j;
                                break;
                            }
                        }
                        if (nugno > -1) break;
                    }
                }
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                    }
                }

                if (nugno > -1)
                {
                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount; i++)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value != null)
                        {
                            string elmnt = dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString().ToLower();
                            if (elmnt.Contains(textBoxFiltr_SAA.Text.ToLower())) dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Selected = true;
                            //if (elmnt.StartsWith(textBoxFilter_URI.Text.ToLower())) dataGridViewOpenFile_URI.Rows[i].Cells[nugno].Selected = true;
                        }
                    }

                    for (int r = 1; r < dataGridViewOpenFile_SAA.RowCount - 1; r++)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[r].Cells[nugno].Selected != true) dataGridViewOpenFile_SAA.Rows[r].Visible = false;
                    }

                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                        {
                            dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                        }
                    }

                    textBoxKolvo_SAA.Text = "";
                    textBoxSum_SAA.Text = "";
                    textBoxaverage_SAA.Text = "";
                    textBoxmin_SAA.Text = "";
                    textBoxMax_SAA.Text = "";
                }
                else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void textBoxmin_SAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                            {
                                nugno = j;
                                break;
                            }
                        }
                        if (nugno > -1) break;
                    }

                    if (nugno > -1)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[0].Cells[nugno].Selected != true)
                        {
                            double min = 9999999;
                            for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value = cellValue;
                                        min = Math.Min(Convert.ToDouble(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString()), min);
                                    }
                                }
                            }
                            if (min != 9999999) textBoxmin_SAA.Text = Convert.ToString(min);
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxmin_SAA.Text = "";

                                textBoxSum_SAA.Text = "";
                                textBoxaverage_SAA.Text = "";
                                textBoxMax_SAA.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxmin_SAA.Text = "";

                            textBoxSum_SAA.Text = "";
                            textBoxaverage_SAA.Text = "";
                            textBoxMax_SAA.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxaverage_SAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                            {
                                nugno = j;
                                break;
                            }
                        }
                        if (nugno > -1) break;
                    }

                    if (nugno > -1)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[0].Cells[nugno].Selected != true)
                        {
                            double srznach = 0; int kol = 0;
                            for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value = cellValue;
                                        srznach += Convert.ToDouble(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString());
                                        kol++;
                                    }
                                }
                            }
                            if (srznach != 0) textBoxaverage_SAA.Text = Convert.ToString(Math.Round(srznach / kol, 5));
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxaverage_SAA.Text = "";

                                textBoxSum_SAA.Text = "";
                                textBoxmin_SAA.Text = "";
                                textBoxMax_SAA.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxaverage_SAA.Text = "";

                            textBoxSum_SAA.Text = "";
                            textBoxmin_SAA.Text = "";
                            textBoxMax_SAA.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxSum_SAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                            {
                                nugno = j;
                                break;
                            }
                        }
                        if (nugno > -1) break;
                    }

                    if (nugno > -1)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[0].Cells[nugno].Selected != true)
                        {
                            double sum = 0;
                            for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Selected == true)
                                {
                                    double cellValue;
                                    if (dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value != null && double.TryParse(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString(), out cellValue))
                                    {
                                        dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value = cellValue;
                                        sum += Convert.ToDouble(dataGridViewOpenFile_SAA.Rows[i].Cells[nugno].Value.ToString());
                                    }
                                }
                            }
                            if (sum != 0) textBoxSum_SAA.Text = Convert.ToString(sum);
                            else
                            {
                                MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxSum_SAA.Text = "";

                                textBoxaverage_SAA.Text = "";
                                textBoxmin_SAA.Text = "";
                                textBoxMax_SAA.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, выберите диапозон ячеек с числами", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxSum_SAA.Text = "";

                            textBoxaverage_SAA.Text = "";
                            textBoxmin_SAA.Text = "";
                            textBoxMax_SAA.Text = "";
                        }
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxKolvo_SAA_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                                {
                                    nugno = j;
                                    break;
                                }
                            }
                            if (nugno > -1) break;
                        }
                    }

                    int counter = 0;
                    for (int r = 0; r < dataGridViewOpenFile_SAA.RowCount - 1; r++)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[r].Cells[nugno].Selected == true) counter++;
                    }
                    textBoxKolvo_SAA.Text = Convert.ToString(counter);
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxFiltr_SAA_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewOpenFile_SAA.RowCount != 0)
            {
                mtrxFilter = new string[dataGridViewOpenFile_SAA.RowCount, dataGridViewOpenFile_SAA.ColumnCount];
                for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                    {
                        mtrxFilter[i, j] = Convert.ToString(dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value);
                    }
                }
                bip++;
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxSort_SAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSort_SAA.SelectedItem != null && dataGridViewOpenFile_SAA.RowCount != 0)
            {
                int vozmogno = 0; int k = -1;
                for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount; j++)
                    {
                        if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value == null) vozmogno++;
                    }
                    textBoxMax_SAA.Text = Convert.ToString(vozmogno);
                    if (vozmogno == dataGridViewOpenFile_SAA.ColumnCount)
                    {
                        k = i;
                        break;
                    }
                    else vozmogno = 0;
                }
                if (k > 0) MessageBox.Show("Пожалуйста, удалите все пустые строки, кроме последней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int kakbuda = 0;
                    for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == false) kakbuda++;
                        }
                    }
                    if (kakbuda != (dataGridViewOpenFile_SAA.RowCount - 1) * (dataGridViewOpenFile_SAA.ColumnCount - 1))
                    {
                        int columnIndex = -1;
                        for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                            {
                                if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Value != null)
                                {
                                    if (dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected == true)
                                    {
                                        columnIndex = j;
                                        break;
                                    }
                                }
                            }
                            if (columnIndex > -1) break;
                        }

                        for (int i = 1; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                        {
                            double cellValue;
                            if (dataGridViewOpenFile_SAA.Rows[i].Cells[columnIndex].Value != null && double.TryParse(dataGridViewOpenFile_SAA.Rows[i].Cells[columnIndex].Value.ToString(), out cellValue))
                            {
                                dataGridViewOpenFile_SAA.Rows[i].Cells[columnIndex].Value = cellValue;
                            }
                        }

                        string selectedItem = comboBoxSort_SAA.SelectedItem.ToString();
                        if (selectedItem == "По возрастанию (от А до Я)" && trip != 0)
                        {
                            DataGridViewRow row = dataGridViewOpenFile_SAA.Rows[0];
                            dataGridViewOpenFile_SAA.Rows.Remove(dataGridViewOpenFile_SAA.Rows[0]);

                            DataGridViewColumn column = dataGridViewOpenFile_SAA.Columns[columnIndex];

                            dataGridViewOpenFile_SAA.Sort(column, ListSortDirection.Ascending);
                            dataGridViewOpenFile_SAA.Rows.Insert(0, row);

                            for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                        else if (selectedItem == "По убыванию (от Я до А)" && trip != 0)
                        {
                            DataGridViewRow row = dataGridViewOpenFile_SAA.Rows[0];
                            dataGridViewOpenFile_SAA.Rows.Remove(dataGridViewOpenFile_SAA.Rows[0]);

                            DataGridViewColumn column = dataGridViewOpenFile_SAA.Columns[columnIndex];

                            dataGridViewOpenFile_SAA.Sort(column, ListSortDirection.Descending);
                            dataGridViewOpenFile_SAA.Rows.Insert(0, row);

                            for (int i = 0; i < dataGridViewOpenFile_SAA.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOpenFile_SAA.ColumnCount - 1; j++)
                                {
                                    dataGridViewOpenFile_SAA.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                        else MessageBox.Show("Не забудьте нажать на пустое поле ввода сортирвоки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textBoxKolvo_SAA.Text = "";
                        textBoxSum_SAA.Text = "";
                        textBoxaverage_SAA.Text = "";
                        textBoxmin_SAA.Text = "";
                        textBoxMax_SAA.Text = "";
                    }
                    else if (kakbuda == (dataGridViewOpenFile_SAA.RowCount - 1) * (dataGridViewOpenFile_SAA.ColumnCount - 1) && trip != 0)
                    {
                        MessageBox.Show("Пожалуйста, выберите столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (kakbuda == (dataGridViewOpenFile_SAA.RowCount - 1) * (dataGridViewOpenFile_SAA.ColumnCount - 1) && trip == 0)
                    {
                        MessageBox.Show($"{"Пожалуйста, выберите столбец." + "\r"}{"Не забудьте нажать на пустое поле ввода сортирвоки!"}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
