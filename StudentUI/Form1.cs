using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarApp;

namespace StudentUI
{
    public partial class Form1 : Form
    {
        AutoPark sl;
        
        public Form1()
        {
            InitializeComponent();
            sl = new AutoPark();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //functie care se executa la click
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("Id cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_Faculty.Text))
            {
                MessageBox.Show("Faculty cannot be empty!");
                return;
            }

            int id = 0; //conversie string ==> int
            if(!int.TryParse(textBox_Id.Text, out id))
            {
                MessageBox.Show(string.Format("{0} is not a number!", textBox_Id.Text));
                return;
            }

            sl.Add(new Student() 
            { 
                Id = id,
                Name = textBox_Name.Text,
                Faculty = textBox_Faculty.Text
            });

            richTextBox1.Clear();
            richTextBox1.Text = sl.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sl.SaveOnDisk("Students.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("Id cannot be empty!");
                return;
            }

            int id = 0; //conversie string ==> int
            if (!int.TryParse(textBox_Id.Text, out id))
            {
                MessageBox.Show(string.Format("{0} is not a number!", textBox_Id.Text));
                return;
            }

            if (string.IsNullOrEmpty(textBox_Course.Text))
            {
                MessageBox.Show("Course cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(textBox_Grade.Text))
            {
                MessageBox.Show("Grade cannot be empty!");
                return;
            }

            double grade = 0; //conversie string ==> int
            if (!double.TryParse(textBox_Grade.Text, out grade))
            {
                MessageBox.Show(string.Format("{0} is not a number!", textBox_Grade.Text));
                return;
            }

            sl.AddGrade(id, textBox_Course.Text, grade);
            richTextBox1.Clear();
            richTextBox1.Text = sl.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
