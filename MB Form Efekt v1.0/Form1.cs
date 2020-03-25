using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MB_Form_Efekt_v1._0
{
    public partial class Form1 : Form
    {
        Random rast = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Opacity = 0;
            timer1.Start();
            timer1.Interval += 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            this.Opacity += 0.1; 

            this.Left += 5; 

            this.Top += 5;

            this.Width += 10;

            this.Height += 9;

            label1.Text = this.Width.ToString();

            if (this.Width >= 500) 
            {
                timer1.Stop(); 
                timer2.Start(); 

            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            int kirmizi = rast.Next(0, 256);  

            int yesil = rast.Next(0, 256);

            int mavi = rast.Next(0, 256);

            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);

            label1.Text = this.Width.ToString();
         
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            timer2.Stop(); 
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
