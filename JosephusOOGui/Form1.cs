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

            int numDeadSoldiers = 0;

            DeadSoldiers = new Boolean[SoldierPics.Count];
            for (int i = 0; i < DeadSoldiers.Length; i++)
            {
                DeadSoldiers[i] = false;
            }
            LastAcessed = 0;
            int numberOFsoldiers = (int)numSoldiers.Value;

            while (numDeadSoldiers < numberOFsoldiers - 1 )
            {
                
                int count = 0;
                while(count < Countdown)
                {
                    if (!DeadSoldiers[LastAcessed])
                    {
                        SoldierPics[LastAcessed].Image = soldierSword.Image;
                        SoldierPics[LastAcessed].Refresh();
                        System.Threading.Thread.Sleep(1000);
                        SoldierPics[LastAcessed].Image = soldierImage.Image;
                        SoldierPics[LastAcessed].Refresh();
                        LastAcessed++;
                        if (LastAcessed == DeadSoldiers.Length)
                        {
                            LastAcessed = 0;
                        }
                        count++;
                    }
                    else
                    {
                        while(DeadSoldiers[LastAcessed])
                        {
                            LastAcessed++;
                            LastAcessed %= numberOFsoldiers;
                        }
                    }
                }
                count = 0;

                while(DeadSoldiers[LastAcessed])
                        {
                    LastAcessed++;
                    LastAcessed %= numberOFsoldiers;
                }

                SoldierPics[LastAcessed].Width = soldierDead.Width;
                SoldierPics[LastAcessed].Height = soldierDead.Height;
                SoldierPics[LastAcessed].Image = soldierDead.Image;
                SoldierPics[LastAcessed].Refresh();
                System.Threading.Thread.Sleep(1000);
                numDeadSoldiers++;
                DeadSoldiers[LastAcessed] = true;
                LastAcessed++;
                LastAcessed %= numberOFsoldiers;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
    }
}