namespace CarRacing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSagSerit2 = new System.Windows.Forms.Label();
            this.labelSagSerit1 = new System.Windows.Forms.Label();
            this.RedCar = new System.Windows.Forms.PictureBox();
            this.labelSagSerit3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelRoad = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSolSerit3 = new System.Windows.Forms.Label();
            this.labelSolSerit1 = new System.Windows.Forms.Label();
            this.labelSolSerit2 = new System.Windows.Forms.Label();
            this.labelSolSerit6 = new System.Windows.Forms.Label();
            this.labelSolSerit4 = new System.Windows.Forms.Label();
            this.labelSolSerit5 = new System.Windows.Forms.Label();
            this.labelSagSerit6 = new System.Windows.Forms.Label();
            this.labelSagSerit4 = new System.Windows.Forms.Label();
            this.labelSagSerit5 = new System.Windows.Forms.Label();
            this.timerSerit = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 691);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(969, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 850);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-6, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(947, 78);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // labelSagSerit2
            // 
            this.labelSagSerit2.BackColor = System.Drawing.Color.White;
            this.labelSagSerit2.Location = new System.Drawing.Point(436, 475);
            this.labelSagSerit2.Name = "labelSagSerit2";
            this.labelSagSerit2.Size = new System.Drawing.Size(13, 94);
            this.labelSagSerit2.TabIndex = 4;
            // 
            // labelSagSerit1
            // 
            this.labelSagSerit1.BackColor = System.Drawing.Color.White;
            this.labelSagSerit1.Location = new System.Drawing.Point(436, 587);
            this.labelSagSerit1.Name = "labelSagSerit1";
            this.labelSagSerit1.Size = new System.Drawing.Size(13, 94);
            this.labelSagSerit1.TabIndex = 6;
            this.labelSagSerit1.Click += new System.EventHandler(this.labelSagSerit4_Click);
            // 
            // RedCar
            // 
            this.RedCar.Image = global::CarRacing.Properties.Resources.car3;
            this.RedCar.Location = new System.Drawing.Point(300, 475);
            this.RedCar.Name = "RedCar";
            this.RedCar.Size = new System.Drawing.Size(114, 206);
            this.RedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedCar.TabIndex = 13;
            this.RedCar.TabStop = false;
            // 
            // labelSagSerit3
            // 
            this.labelSagSerit3.BackColor = System.Drawing.Color.White;
            this.labelSagSerit3.Location = new System.Drawing.Point(436, 364);
            this.labelSagSerit3.Name = "labelSagSerit3";
            this.labelSagSerit3.Size = new System.Drawing.Size(13, 94);
            this.labelSagSerit3.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Maroon;
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(0, -3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(726, 40);
            this.label16.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 23);
            this.label17.TabIndex = 17;
            this.label17.Text = "ARABA YARIŞI";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(-2, 702);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 25);
            this.label18.TabIndex = 18;
            this.label18.Text = "SPEED:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.BackColor = System.Drawing.Color.White;
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.Maroon;
            this.labelSpeed.Location = new System.Drawing.Point(82, 702);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(94, 25);
            this.labelSpeed.TabIndex = 19;
            this.labelSpeed.Text = "0 km/h";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(253, 702);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 25);
            this.label20.TabIndex = 20;
            this.label20.Text = "ROAD:";
            // 
            // labelRoad
            // 
            this.labelRoad.BackColor = System.Drawing.Color.White;
            this.labelRoad.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoad.ForeColor = System.Drawing.Color.Maroon;
            this.labelRoad.Location = new System.Drawing.Point(338, 702);
            this.labelRoad.Name = "labelRoad";
            this.labelRoad.Size = new System.Drawing.Size(60, 25);
            this.labelRoad.TabIndex = 21;
            this.labelRoad.Text = "0 m";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(480, 702);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(164, 25);
            this.label22.TabIndex = 22;
            this.label22.Text = "HİGH SCORE:";
            // 
            // labelHighScore
            // 
            this.labelHighScore.BackColor = System.Drawing.Color.White;
            this.labelHighScore.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.Color.Maroon;
            this.labelHighScore.Location = new System.Drawing.Point(638, 702);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(60, 25);
            this.labelHighScore.TabIndex = 23;
            this.labelHighScore.Text = "0 m";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(666, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 647);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // labelSolSerit3
            // 
            this.labelSolSerit3.BackColor = System.Drawing.Color.White;
            this.labelSolSerit3.Location = new System.Drawing.Point(270, 352);
            this.labelSolSerit3.Name = "labelSolSerit3";
            this.labelSolSerit3.Size = new System.Drawing.Size(13, 94);
            this.labelSolSerit3.TabIndex = 27;
            this.labelSolSerit3.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelSolSerit1
            // 
            this.labelSolSerit1.BackColor = System.Drawing.Color.White;
            this.labelSolSerit1.Location = new System.Drawing.Point(270, 587);
            this.labelSolSerit1.Name = "labelSolSerit1";
            this.labelSolSerit1.Size = new System.Drawing.Size(13, 94);
            this.labelSolSerit1.TabIndex = 26;
            // 
            // labelSolSerit2
            // 
            this.labelSolSerit2.BackColor = System.Drawing.Color.White;
            this.labelSolSerit2.Location = new System.Drawing.Point(270, 465);
            this.labelSolSerit2.Name = "labelSolSerit2";
            this.labelSolSerit2.Size = new System.Drawing.Size(13, 94);
            this.labelSolSerit2.TabIndex = 25;
            // 
            // labelSolSerit6
            // 
            this.labelSolSerit6.BackColor = System.Drawing.Color.White;
            this.labelSolSerit6.Location = new System.Drawing.Point(270, 30);
            this.labelSolSerit6.Name = "labelSolSerit6";
            this.labelSolSerit6.Size = new System.Drawing.Size(13, 94);
            this.labelSolSerit6.TabIndex = 30;
            // 
            // labelSolSerit4
            // 
            this.labelSolSerit4.BackColor = System.Drawing.Color.White;
            this.labelSolSerit4.Location = new System.Drawing.Point(270, 243);
            this.labelSolSerit4.Name = "labelSolSerit4";
            this.labelSolSerit4.Size = new System.Drawing.Size(13, 94);
            this.labelSolSerit4.TabIndex = 29;
            // 
            // labelSolSerit5
            // 
            this.labelSolSerit5.BackColor = System.Drawing.Color.White;
            this.labelSolSerit5.Location = new System.Drawing.Point(270, 138);
            this.labelSolSerit5.Name = "labelSolSerit5";
            this.labelSolSerit5.Size = new System.Drawing.Size(13, 94);
            this.labelSolSerit5.TabIndex = 28;
            this.labelSolSerit5.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelSagSerit6
            // 
            this.labelSagSerit6.BackColor = System.Drawing.Color.White;
            this.labelSagSerit6.Location = new System.Drawing.Point(436, 30);
            this.labelSagSerit6.Name = "labelSagSerit6";
            this.labelSagSerit6.Size = new System.Drawing.Size(13, 94);
            this.labelSagSerit6.TabIndex = 33;
            // 
            // labelSagSerit4
            // 
            this.labelSagSerit4.BackColor = System.Drawing.Color.White;
            this.labelSagSerit4.Location = new System.Drawing.Point(436, 253);
            this.labelSagSerit4.Name = "labelSagSerit4";
            this.labelSagSerit4.Size = new System.Drawing.Size(13, 94);
            this.labelSagSerit4.TabIndex = 32;
            // 
            // labelSagSerit5
            // 
            this.labelSagSerit5.BackColor = System.Drawing.Color.White;
            this.labelSagSerit5.Location = new System.Drawing.Point(436, 138);
            this.labelSagSerit5.Name = "labelSagSerit5";
            this.labelSagSerit5.Size = new System.Drawing.Size(13, 94);
            this.labelSagSerit5.TabIndex = 31;
            // 
            // timerSerit
            // 
            this.timerSerit.Enabled = true;
            this.timerSerit.Interval = 200;
            this.timerSerit.Tick += new System.EventHandler(this.timerSerit_Tick);
            // 
            // timerRandomCar
            // 
            this.timerRandomCar.Interval = 200;
            this.timerRandomCar.Tick += new System.EventHandler(this.timerRandomCar_Tick);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 745);
            this.Controls.Add(this.labelSagSerit6);
            this.Controls.Add(this.labelSagSerit4);
            this.Controls.Add(this.labelSagSerit5);
            this.Controls.Add(this.labelSolSerit6);
            this.Controls.Add(this.labelSolSerit4);
            this.Controls.Add(this.labelSolSerit5);
            this.Controls.Add(this.labelSolSerit3);
            this.Controls.Add(this.labelSolSerit1);
            this.Controls.Add(this.labelSolSerit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.labelRoad);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelSagSerit3);
            this.Controls.Add(this.RedCar);
            this.Controls.Add(this.labelSagSerit1);
            this.Controls.Add(this.labelSagSerit2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RedCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSagSerit2;
        private System.Windows.Forms.Label labelSagSerit1;
        private System.Windows.Forms.PictureBox RedCar;
        private System.Windows.Forms.Label labelSagSerit3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSolSerit3;
        private System.Windows.Forms.Label labelSolSerit1;
        private System.Windows.Forms.Label labelSolSerit2;
        private System.Windows.Forms.Label labelSolSerit6;
        private System.Windows.Forms.Label labelSolSerit4;
        private System.Windows.Forms.Label labelSolSerit5;
        private System.Windows.Forms.Label labelSagSerit6;
        private System.Windows.Forms.Label labelSagSerit4;
        private System.Windows.Forms.Label labelSagSerit5;
        private System.Windows.Forms.Timer timerSerit;
        private System.Windows.Forms.Timer timerRandomCar;
    }
}

