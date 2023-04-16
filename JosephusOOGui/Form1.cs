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

        private Boolean[] DeadSoldiers;
        private int Countdown;
        private int LastAcessed = 0;


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
                Soldier.Visible = true;
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
            Countdown = (int)numCountdown.Value;

            int deadSoldiers = 0;

            DeadSoldiers = new Boolean[SoldierPics.Count];
            for (int i = 0; i < DeadSoldiers.Length; i++)
            {
                DeadSoldiers[i] = false;
            }
            LastAcessed = DeadSoldiers.Length - 1;

            while (deadSoldiers < (DeadSoldiers.Length - 1))
            {
                for(int i =0; i < Countdown; ++i)
                {
                    if (!DeadSoldiers[LastAcessed])
                    {
                        for (int s = 0; s < DeadSoldiers.Length; s++)
                        {
                            Areana.Controls.Clear();
                            SoldierPics.Clear();
                            PictureBox Soldier = AdjustSoldier(s,DeadSoldiers.Length);
                            Soldier.Visible = true;
                            SoldierPics.Add(Soldier);
                            Areana.Controls.Add(Soldier);
                        }
                    }
                    else
                    {
                        LastAcessed++;
                        if(LastAcessed == DeadSoldiers.Length)
                        {
                            LastAcessed= 0;
                        }
                        i--;
                    }
                    System.Threading.Thread.Sleep(700);
                }
                deadSoldiers++;
            }
        }



        private PictureBox AdjustSoldier(int whichSoldier, int numberOFsoldiers)
        {
            PictureBox tempSoldier = new PictureBox();

            if (whichSoldier == LastAcessed && !DeadSoldiers[LastAcessed])
            {
                tempSoldier.Height = PIC_HIGT;
                tempSoldier.Width = PIC_WITH;
                tempSoldier.Image = soldierSword.Image;
                tempSoldier.Location = CreateLocation(whichSoldier, numberOFsoldiers);
            }
            else if (!DeadSoldiers[LastAcessed])
            {
                tempSoldier.Height = PIC_HIGT;
                tempSoldier.Width = PIC_WITH;
                tempSoldier.Image = soldierImage.Image;
                tempSoldier.Location = CreateLocation(whichSoldier, numberOFsoldiers);
            }
            else if (DeadSoldiers[LastAcessed])
            {
                tempSoldier.Height = 36;
                tempSoldier.Width = 41;
                tempSoldier.Image = soldierDead.Image;
                tempSoldier.Location = CreateLocation(whichSoldier, numberOFsoldiers);
            }

            return tempSoldier;
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