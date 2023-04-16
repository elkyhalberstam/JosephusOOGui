namespace JosephusOOGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSoldiers = new System.Windows.Forms.NumericUpDown();
            this.numCountdown = new System.Windows.Forms.NumericUpDown();
            this.soldierImage = new System.Windows.Forms.PictureBox();
            this.startKilling = new System.Windows.Forms.Button();
            this.Areana = new System.Windows.Forms.Panel();
            this.soldierDead = new System.Windows.Forms.PictureBox();
            this.soldierSword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSoldiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierSword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Soldiers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Countdown Number";
            // 
            // numSoldiers
            // 
            this.numSoldiers.Location = new System.Drawing.Point(242, 34);
            this.numSoldiers.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSoldiers.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSoldiers.Name = "numSoldiers";
            this.numSoldiers.Size = new System.Drawing.Size(77, 31);
            this.numSoldiers.TabIndex = 2;
            this.numSoldiers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSoldiers.ValueChanged += new System.EventHandler(this.numSoldiers_ValueChanged);
            // 
            // numCountdown
            // 
            this.numCountdown.Location = new System.Drawing.Point(242, 97);
            this.numCountdown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCountdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountdown.Name = "numCountdown";
            this.numCountdown.Size = new System.Drawing.Size(77, 31);
            this.numCountdown.TabIndex = 3;
            this.numCountdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // soldierImage
            // 
            this.soldierImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soldierImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("soldierImage.ErrorImage")));
            this.soldierImage.Image = ((System.Drawing.Image)(resources.GetObject("soldierImage.Image")));
            this.soldierImage.Location = new System.Drawing.Point(218, 148);
            this.soldierImage.Name = "soldierImage";
            this.soldierImage.Size = new System.Drawing.Size(25, 60);
            this.soldierImage.TabIndex = 4;
            this.soldierImage.TabStop = false;
            this.soldierImage.Visible = false;
            this.soldierImage.WaitOnLoad = true;
            this.soldierImage.Click += new System.EventHandler(this.soldierImage_Click);
            // 
            // startKilling
            // 
            this.startKilling.Image = ((System.Drawing.Image)(resources.GetObject("startKilling.Image")));
            this.startKilling.Location = new System.Drawing.Point(45, 139);
            this.startKilling.Name = "startKilling";
            this.startKilling.Size = new System.Drawing.Size(79, 78);
            this.startKilling.TabIndex = 5;
            this.startKilling.UseVisualStyleBackColor = true;
            this.startKilling.Click += new System.EventHandler(this.startKilling_Click);
            // 
            // Areana
            // 
            this.Areana.Location = new System.Drawing.Point(354, 32);
            this.Areana.Name = "Areana";
            this.Areana.Size = new System.Drawing.Size(500, 500);
            this.Areana.TabIndex = 6;
            this.Areana.Paint += new System.Windows.Forms.PaintEventHandler(this.Areana_Paint);
            // 
            // soldierDead
            // 
            this.soldierDead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soldierDead.ErrorImage = ((System.Drawing.Image)(resources.GetObject("soldierDead.ErrorImage")));
            this.soldierDead.Image = ((System.Drawing.Image)(resources.GetObject("soldierDead.Image")));
            this.soldierDead.Location = new System.Drawing.Point(164, 157);
            this.soldierDead.Name = "soldierDead";
            this.soldierDead.Size = new System.Drawing.Size(48, 31);
            this.soldierDead.TabIndex = 7;
            this.soldierDead.TabStop = false;
            this.soldierDead.Visible = false;
            this.soldierDead.WaitOnLoad = true;
            // 
            // soldierSword
            // 
            this.soldierSword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soldierSword.ErrorImage = ((System.Drawing.Image)(resources.GetObject("soldierSword.ErrorImage")));
            this.soldierSword.Image = ((System.Drawing.Image)(resources.GetObject("soldierSword.Image")));
            this.soldierSword.Location = new System.Drawing.Point(249, 148);
            this.soldierSword.Name = "soldierSword";
            this.soldierSword.Size = new System.Drawing.Size(25, 60);
            this.soldierSword.TabIndex = 8;
            this.soldierSword.TabStop = false;
            this.soldierSword.Visible = false;
            this.soldierSword.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.soldierSword);
            this.Controls.Add(this.soldierDead);
            this.Controls.Add(this.Areana);
            this.Controls.Add(this.startKilling);
            this.Controls.Add(this.soldierImage);
            this.Controls.Add(this.numCountdown);
            this.Controls.Add(this.numSoldiers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSoldiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierSword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numSoldiers;
        private NumericUpDown numCountdown;
        private PictureBox soldierImage;
        private Button startKilling;
        private Panel Areana;
        private PictureBox soldierDead;
        private PictureBox soldierSword;
    }
}