using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiClient;
using System.Drawing;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            // dinaminis window
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = true;

            // Dock ir Anchor controleriams
            DogsBreeds.Dock = DockStyle.Fill;
            DogsBreeds.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            Subspeciesofbreed.Dock = DockStyle.Fill;
            Subspeciesofbreed.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            button2.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            button4.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        }

        //1 mygtukas visiems breeds
        private async void button1_Click(object sender, EventArgs e)
        {
            
            var breedsResponse = await ApiHelper.GetDogsAsync();
            DogsBreeds.Items.Clear(); //DogsBreeds - ListBox1
            foreach (var breed in breedsResponse.Message)
            {
                DogsBreeds.Items.Add(breed.Key);
            }
        }

        // 2 mygtukas gauti subbreeds 
        private async void button2_Click(object sender, EventArgs e)
        {
            //breeds
            var selectedBreed = DogsBreeds.SelectedItem?.ToString(); //pasirinktam breed object

            if (selectedBreed == null)
            {
                MessageBox.Show("Please select a breed first.");
                return;
            }

            // Subbreeds
            var subBreedsResponse = await ApiHelper.GetSubBreedsAsync(selectedBreed);

            Subspeciesofbreed.Items.Clear();//ListBox2
            if (subBreedsResponse.Message == null || subBreedsResponse.Message.Length == 0)//ar yra subbreed? 
            {
                MessageBox.Show("There are no subbreeds for the selected breed.");
            }
            else
            {
                foreach (var subBreed in subBreedsResponse.Message)
                {
                    Subspeciesofbreed.Items.Add(subBreed);
                }
            }
        }

        // 3 mygtukas random nuotraukai
        private async void button3_Click(object sender, EventArgs e)
        {
            var randomImageResponse = await ApiHelper.GetRandomImageAsync();
            pictureBox1.Load(randomImageResponse.Message);
        }

        //4 mygtukas random nuotrauka pasirinktam breed
        private async void button4_Click(object sender, EventArgs e)
        {
            // Pasirinkti breed
            var selectedBreed = DogsBreeds.SelectedItem?.ToString();

            if (selectedBreed == null)
            {
                MessageBox.Show("Please select a breed first.");
                return;
            }

            // Pasirinkto breed random image
            var breedImageResponse = await ApiHelper.GetBreedImageAsync(selectedBreed);

            if (breedImageResponse.Status == "success")
            {
                pictureBox1.Load(breedImageResponse.Message);
            }
            else
            {
                MessageBox.Show("An error occurred while trying to get the image.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}