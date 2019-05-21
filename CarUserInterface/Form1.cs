using CarApp;
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

namespace CarUserInterface
{
    public partial class FormForm : Form
    {
        AutoPark ap;

        public FormForm()
        {
            InitializeComponent();
            ap = new AutoPark();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("ID cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(textBoxModel.Text))
            {
                MessageBox.Show("Model cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(textBoxManufacturer.Text))
            {
                MessageBox.Show("Manufacturer cannot be empty!");
                return;
            }

            int id = 0; //conversie string ==> int
            if (!int.TryParse(textBoxID.Text, out id))
            {
                MessageBox.Show(string.Format("{0} is not a number!", textBoxID.Text));
                return;
            }

            int year = 0; //conversie string ==> int
            if (!int.TryParse(textBoxYear.Text, out year))
            {
                MessageBox.Show(string.Format("{0} is not a number!", textBoxYear.Text));
                return;
            }

            ap.Add(new Car()
            {
                Id = id,
                Model = textBoxModel.Text,
                Manufacturer = textBoxManufacturer.Text,
                Year = year
            });

            richTextBox1.Clear();
            richTextBox1.Text = ap.ToString();


    }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
               var strfilename = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
               MessageBox.Show(strfilename + " selected!");

                int id = 0; //conversie string ==> int
                if (!int.TryParse(textBoxID.Text, out id))
                {
                    MessageBox.Show(string.Format("{0} is not a number!", textBoxID.Text));
                    return;
                }

                Picture temppic = new Picture()
                    {
                        Name = openFileDialog1.FileName,
                        FilePath = strfilename
                    };

                ap.AddPicture(id, temppic.Name, temppic.FilePath);

                Image image = Image.FromFile(strfilename);
                pictureBox1.Image = image;
                /*
                pictureBox1.Height = 100;
                pictureBox1.Width = 100;
                */
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            //Console.WriteLine(result);
        }



    }
}
