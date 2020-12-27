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
    public partial class Form1 : Form
    {
        employee emp;
        public Form1()
        {
            InitializeComponent();
            emp = new employee();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        //save information btn eventa
        private void saveInformation(object sender, EventArgs e)
        {
            emp.name = textBox1.Text;
            emp.DOB = dateTimePicker1.Value;
            emp.contact = maskedTextBox1.Text;
            if(comboBox1.SelectedIndex<0)
            {
                MessageBox.Show("Kindly Fill all fields Carefully");
                return;
            }
            else
            {

                emp.years_of_experience = Convert.ToInt32(numericUpDown1.Value);
            }
            richTextBox1.Text = emp.ToString();

            /*try
            {
                emp.department = comboBox1.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
              
              
            }*/

        }
        //browse an image from files
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            emp.img= openFileDialog1.FileName;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(emp);
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
