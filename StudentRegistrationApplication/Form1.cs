using Microsoft.VisualBasic.Devices;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populateComboBoxes();

        }
        void Display1(String in1, String in2, String in3, String gender, String day, String month, String year, String course)
        {
            MessageBox.Show("Student Name: " + in1 + ", " + in2 + ", " + in3 + "\n" + "Gender: " + gender + "\n" + "Date of Birth: " + (day + "-" + month + "-" + year) +
                "\nChosen Course:" + course);
        }
        void Display1(String in1, String in2, String in3,String course)
        {
            MessageBox.Show("Student Name: " + in1 + ", " + in2 + ", " + in3 + "\nChosen Course: " + course);
        }
        void Display1(String in1, String in3, String course)
        {
            MessageBox.Show("Student Name; " + in1 + " " + in3 + "\n Chosen Course: " + course);
        }
        private void populateComboBoxes()
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string LastName = textBox1.Text;
            string MiddleName = textBox3.Text;
            string FirstName = textBox2.Text;
            string gender = radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : "Not specified";
            string day = comboBox1.Text;
            string month = comboBox2.Text;
            string year = comboBox3.Text;
            string course = comboBox4.Text;

            Display1(FirstName, MiddleName, LastName, gender, day, month, year, course);
            Display1(FirstName, MiddleName, LastName, course);
            Display1(FirstName, LastName, course);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
