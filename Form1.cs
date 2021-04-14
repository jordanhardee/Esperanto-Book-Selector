using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5hardeehj
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Does the top 10 thing and selects the .txt book files
        }

        private void button3_Click(object sender, EventArgs e)
         {
             SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\jorda\OneDrive - University of Cincinnati\CSharpAssnment5\Assignment5hardeehj\La_Espero.wav");
             simpleSound.Play();
             //Need to make this work no matter file-path/ local link in the project directory
         } 
      
    }
}
