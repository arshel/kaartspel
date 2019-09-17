using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kaarstpel___Form.Properties;

namespace Kaarstpel___Form
{
    public partial class Form1 : Form
    {
        int startpositieX = 0;
        int startpositieY = 0;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
            maakbox(0);
        }

        private void maakbox(int aantal)
        {
            for (int kt = 1; kt <= 4; kt++) 
            {
                for (int i = 1; i <= 13; i++) //card
                {
                    
                    PictureBox pb = new PictureBox();
                    Size sz = new Size(60, 70);
                    pb.Size = sz;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    Point pt = new Point(startpositieX, startpositieY);
   
                    pb.Location = pt;
                    if (kt == 1)
                    {
                        pb.Image = Image.FromFile("D:\\kaartspel\\fotokaart\\" + i + "H.png");
                        pb.Name = i + "H";
                    }
                    else if (kt == 2)
                    {
                        pb.Image = Image.FromFile("D:\\kaartspel\\fotokaart\\" + i + "S.png");
                        pb.Name = i + "S";
                    }
                    else if (kt == 3)
                    {
                        pb.Image = Image.FromFile("D:\\kaartspel\\fotokaart\\" + i + "D.png");
                        pb.Name = i + "D";
                    }
                    else if (kt == 4)
                    {
                        pb.Image = Image.FromFile("D:\\kaartspel\\fotokaart\\" + i + "C.png");
                        pb.Name = i + "C";
                    }

                    pb.Click += new EventHandler(this.PB_Click);
                    this.Controls.Add(pb);
                    startpositieX += 119;
                    if (i == 13 || i == 26 || i == 39 || i >= 52)
                    {
                        startpositieY += 175;
                        startpositieX = 0;
                    }
                }
            }
        }
        bool ShowCard = false;
        private void PB_Click(object sender, EventArgs e)
        {

            PictureBox pb = (PictureBox)sender;
            String card = pb.Name;
            if(ShowCard == true){
                Random rnd = new Random();
                int BgColor = rnd.Next(1, 7);
                pb.Image = Image.FromFile("D:\\kaartspel\\fotokaart\\" + BgColor + ".png");
                ShowCard = false;
            }
            else if(ShowCard == false)
            {
                pb.Image = Image.FromFile("D:\\kaartspel\\fotokaart\\" + card + ".png");
                ShowCard = true;
            }
      
        }
    }
}