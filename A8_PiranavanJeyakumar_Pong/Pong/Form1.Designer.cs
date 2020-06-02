namespace Pong
{
    partial class frmPong
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
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picTopBorder = new System.Windows.Forms.PictureBox();
            this.picBottomBorder = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.picBall = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.picLeftBounds = new System.Windows.Forms.PictureBox();
            this.picRightBounds = new System.Windows.Forms.PictureBox();
            this.tmrComputerMoves = new System.Windows.Forms.Timer(this.components);
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.btnRematch = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBounds)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Crimson;
            this.picPlayer.Location = new System.Drawing.Point(32, 204);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(25, 149);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picComputer
            // 
            this.picComputer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picComputer.Location = new System.Drawing.Point(1007, 200);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(25, 149);
            this.picComputer.TabIndex = 1;
            this.picComputer.TabStop = false;
            // 
            // picTopBorder
            // 
            this.picTopBorder.BackColor = System.Drawing.Color.Indigo;
            this.picTopBorder.Location = new System.Drawing.Point(1, 1);
            this.picTopBorder.Name = "picTopBorder";
            this.picTopBorder.Size = new System.Drawing.Size(1064, 23);
            this.picTopBorder.TabIndex = 2;
            this.picTopBorder.TabStop = false;
            // 
            // picBottomBorder
            // 
            this.picBottomBorder.BackColor = System.Drawing.Color.Indigo;
            this.picBottomBorder.Location = new System.Drawing.Point(-9, 544);
            this.picBottomBorder.Name = "picBottomBorder";
            this.picBottomBorder.Size = new System.Drawing.Size(1074, 33);
            this.picBottomBorder.TabIndex = 3;
            this.picBottomBorder.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Location = new System.Drawing.Point(530, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox2.Location = new System.Drawing.Point(530, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 34);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox3.Location = new System.Drawing.Point(530, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(11, 34);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox4.Location = new System.Drawing.Point(530, 198);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(11, 34);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox5.Location = new System.Drawing.Point(530, 261);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(11, 34);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox6.Location = new System.Drawing.Point(530, 317);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(11, 34);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox7.Location = new System.Drawing.Point(530, 375);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(11, 34);
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox8.Location = new System.Drawing.Point(530, 439);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(11, 34);
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Gold;
            this.picBall.Location = new System.Drawing.Point(530, 204);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(23, 20);
            this.picBall.TabIndex = 13;
            this.picBall.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox9.Location = new System.Drawing.Point(530, 502);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(11, 34);
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(434, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 84);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "FIGHT!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picLeftBounds
            // 
            this.picLeftBounds.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picLeftBounds.Location = new System.Drawing.Point(1038, 1);
            this.picLeftBounds.Name = "picLeftBounds";
            this.picLeftBounds.Size = new System.Drawing.Size(27, 576);
            this.picLeftBounds.TabIndex = 15;
            this.picLeftBounds.TabStop = false;
            // 
            // picRightBounds
            // 
            this.picRightBounds.BackColor = System.Drawing.Color.Crimson;
            this.picRightBounds.Location = new System.Drawing.Point(-11, 1);
            this.picRightBounds.Name = "picRightBounds";
            this.picRightBounds.Size = new System.Drawing.Size(27, 576);
            this.picRightBounds.TabIndex = 16;
            this.picRightBounds.TabStop = false;
            // 
            // tmrComputerMoves
            // 
            this.tmrComputerMoves.Interval = 15;
            this.tmrComputerMoves.Tick += new System.EventHandler(this.tmrComputerMoves_Tick);
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLevel.ForeColor = System.Drawing.Color.White;
            this.btnNextLevel.Location = new System.Drawing.Point(547, 450);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(203, 82);
            this.btnNextLevel.TabIndex = 17;
            this.btnNextLevel.Text = "NEXT OPPONENT";
            this.btnNextLevel.UseVisualStyleBackColor = false;
            this.btnNextLevel.Visible = false;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // btnRematch
            // 
            this.btnRematch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRematch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRematch.ForeColor = System.Drawing.Color.White;
            this.btnRematch.Location = new System.Drawing.Point(321, 450);
            this.btnRematch.Name = "btnRematch";
            this.btnRematch.Size = new System.Drawing.Size(203, 84);
            this.btnRematch.TabIndex = 18;
            this.btnRematch.Text = "REMATCH";
            this.btnRematch.UseVisualStyleBackColor = false;
            this.btnRematch.Visible = false;
            this.btnRematch.Click += new System.EventHandler(this.btnRematch_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(434, 301);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(203, 84);
            this.btnInstructions.TabIndex = 19;
            this.btnInstructions.Text = "INSTRUCTIONS";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Round:";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.White;
            this.lblRoundNumber.Location = new System.Drawing.Point(542, 544);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(51, 23);
            this.lblRoundNumber.TabIndex = 21;
            this.lblRoundNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayerScore.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(309, 31);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(102, 76);
            this.lblPlayerScore.TabIndex = 22;
            this.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerScore.Visible = false;
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblComputerScore.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.ForeColor = System.Drawing.Color.White;
            this.lblComputerScore.Location = new System.Drawing.Point(648, 31);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(102, 76);
            this.lblComputerScore.TabIndex = 23;
            this.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComputerScore.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(74, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 82);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::Pong.Resource1.Space_Hd_3d_Wallpaper_1440x1050;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1065, 573);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picTopBorder);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBottomBorder);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnRematch);
            this.Controls.Add(this.btnNextLevel);
            this.Controls.Add(this.picRightBounds);
            this.Controls.Add(this.picLeftBounds);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.picPlayer);
            this.KeyPreview = true;
            this.Name = "frmPong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBounds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picTopBorder;
        private System.Windows.Forms.PictureBox picBottomBorder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picLeftBounds;
        private System.Windows.Forms.PictureBox picRightBounds;
        private System.Windows.Forms.Timer tmrComputerMoves;
        private System.Windows.Forms.Button btnNextLevel;
        private System.Windows.Forms.Button btnRematch;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Button btnExit;
    }
}

