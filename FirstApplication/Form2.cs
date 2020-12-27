using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(employee emp)
        {
            InitializeComponent();
            label1.Text = "My Name is " + emp.name + ". I am " + emp.DOB + " Years Old. " + "I am a Working in " +
                "GC University Department " + emp.department + "From " + emp.years_of_experience + " Years " +
                "Contact Me at : " + emp.contact + "\n";
            pictureBox1.ImageLocation = emp.img;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font=fontDialog1.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor= colorDialog1.Color;
            button1.BackColor = button2.BackColor = button3.BackColor = colorDialog1.Color;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            button1.ForeColor = button2.ForeColor = button3.ForeColor = colorDialog1.Color;
        }
    }
}
