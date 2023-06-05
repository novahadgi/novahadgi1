using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ПР_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random getRandomValue = new Random();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            for (int i = 0; i < dataGridView_MatrixA.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView_MatrixA.Rows.Count; j++)
                {
                    dataGridView_MatrixA[i, j].Value = getRandomValue.Next(form2.firstValue, form2.secondValue);
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxFit.Checked == true)
            {
                try
                {
                    dataGridView_MatrixA.ColumnCount = (int)numericUpDown1.Value;
                    numericUpDown4.Value = numericUpDown1.Value;
                    dataGridView1.ColumnCount = (int)numericUpDown4.Value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridView_MatrixA.RowCount = 1;
                }
            }
            else
            {
                try
                {
                    dataGridView_MatrixA.ColumnCount = (int)numericUpDown1.Value;
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("Неправильно указано количество столбцов!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    dataGridView_MatrixA.ColumnCount = 1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random getRandomValue = new Random();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1[i, j].Value = getRandomValue.Next(form2.firstValue, form2.secondValue);
                }
            }
        }
    }
}
