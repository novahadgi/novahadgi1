using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР_12
{
    public partial class Form2 : Form
    {
        public int firstValue { get; set; }
        public int secondValue { get; set; }

        public Form2()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxRange.Checked == true)
                {
                    firstValue = int.Parse(textBox1.Text) + 1;
                    secondValue = int.Parse(textBox2.Text) + 1;
                    Close();
                }
                else
                {
                    firstValue = int.Parse(textBox1.Text);
                    secondValue = int.Parse(textBox2.Text);
                    Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ввести необходимо число!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            this.Close();
        }
    }
}
