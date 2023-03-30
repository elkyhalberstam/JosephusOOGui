using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Windows.Forms;

namespace JosephusOOGui
{
    public partial class Form1 : Form
    {
        readonly int DIST_CENTER = 200;
        readonly int HALF_SIDE = 200;
        readonly int PIC_WITH = 25;
        readonly int PIC_HIGT = 60;

        private List<PictureBox> SoldierPics;
     
        public Form1()
        {
            InitializeComponent();
            CreateSoldiers();

        }

        private void CreateSoldiers()
        {
            Areana.Controls.Clear();
            int numberOFsoldiers = (int)numSoldiers.Value;
            SoldierPics = new List<PictureBox>();
            for (int s = 0; s < numberOFsoldiers; s++)
            {
                PictureBox Soldier = PostSoldier(s, numberOFsoldiers);
                Soldier.Visible= true;
                SoldierPics.Add(Soldier);
                Areana.Controls.Add(Soldier);
            }
        }

        private PictureBox PostSoldier(int whichSoldier, int numberOFsoldiers)
        {
            PictureBox tempSoldier = new PictureBox();
            tempSoldier.Height = PIC_HIGT;
            tempSoldier.Width = PIC_WITH;
            tempSoldier.Image = soldierImage.Image;
            tempSoldier.Location = CreateLocation(whichSoldier, numberOFsoldiers);
            return tempSoldier;
        }

        private Point CreateLocation(int which, int Nsoldiers)
        {
            double angleDeg = which * 360.0 / Nsoldiers;
            double angleRad = angleDeg * Math.PI / 180.0;
            int xCord = (int)(HALF_SIDE + DIST_CENTER * Math.Cos(angleRad));
            int yCord = (int)(HALF_SIDE - DIST_CENTER * Math.Sin(angleRad));
            Point Location = new Point(xCord, yCord);
            return Location;
        }

        private void goCountdown()
        {
            int countdown = (int)numCountdown.Value;

            int deadSoldiers = 0;
            int counter = 0;

            while (deadSoldiers < (countdown - 1))
            {
                foreach (PictureBox Soldier in SoldierPics)
                {
                    while(counter <= countdown)
                    {
                        CheckAndSetSoldier(Soldier, counter, countdown);
                        counter++;
                    }
                }
            }
        }

        private void CheckAndSetSoldier(PictureBox Soldier, int counter, int countdown)
        {
            if(Soldier.Image.Equals(soldierImage.Image))
            { 
                if(counter == countdown)
                {
                    Soldier.Height = soldierDead.Height;
                    Soldier.Width = soldierDead.Width;
                    Soldier.Image = soldierDead.Image;
                }
                else
                {
                    Soldier.Image = soldierSword.Image;
                }                
                //System.Threading.Thread.Sleep(10);
            }else
            {
                //do nothing
            }
        }

        private void startKilling_Click(object sender, EventArgs e)
        {
            goCountdown();
        }
        private void numSoldiers_ValueChanged(object sender, EventArgs e)
        {
            CreateSoldiers();
        }

        private void Areana_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void soldierImage_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //
        }
    }
}