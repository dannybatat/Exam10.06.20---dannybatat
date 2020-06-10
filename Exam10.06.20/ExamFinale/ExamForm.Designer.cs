namespace ExamFinale
{
    partial class ExamForm
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
            this.TextBoxNub = new System.Windows.Forms.TextBox();
            this.TextBoxLeb = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progresLeb = new System.Windows.Forms.Label();
            this.progressBt = new System.Windows.Forms.Button();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.BoardPn = new System.Windows.Forms.Panel();
            this.ballPbox = new System.Windows.Forms.PictureBox();
            this.leftBt = new System.Windows.Forms.Button();
            this.rightBt = new System.Windows.Forms.Button();
            this.downBt = new System.Windows.Forms.Button();
            this.upBt = new System.Windows.Forms.Button();
            this.BallGamePn = new System.Windows.Forms.Panel();
            this.BoardPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballPbox)).BeginInit();
            this.BallGamePn.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxNub
            // 
            this.TextBoxNub.Location = new System.Drawing.Point(32, 51);
            this.TextBoxNub.Name = "TextBoxNub";
            this.TextBoxNub.Size = new System.Drawing.Size(128, 20);
            this.TextBoxNub.TabIndex = 0;
            this.TextBoxNub.TextChanged += new System.EventHandler(this.TextBoxNub_TextChanged);
            // 
            // TextBoxLeb
            // 
            this.TextBoxLeb.AutoSize = true;
            this.TextBoxLeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxLeb.Location = new System.Drawing.Point(198, 51);
            this.TextBoxLeb.Name = "TextBoxLeb";
            this.TextBoxLeb.Size = new System.Drawing.Size(17, 18);
            this.TextBoxLeb.TabIndex = 1;
            this.TextBoxLeb.Text = "?";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 525);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(369, 27);
            this.progressBar.TabIndex = 2;
            // 
            // progresLeb
            // 
            this.progresLeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.progresLeb.Location = new System.Drawing.Point(117, 481);
            this.progresLeb.Name = "progresLeb";
            this.progresLeb.Size = new System.Drawing.Size(126, 41);
            this.progresLeb.TabIndex = 3;
            this.progresLeb.Text = "?";
            this.progresLeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBt
            // 
            this.progressBt.Location = new System.Drawing.Point(463, 525);
            this.progressBt.Name = "progressBt";
            this.progressBt.Size = new System.Drawing.Size(91, 26);
            this.progressBt.TabIndex = 4;
            this.progressBt.Text = "Start";
            this.progressBt.UseVisualStyleBackColor = true;
            this.progressBt.Click += new System.EventHandler(this.progressBt_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // BoardPn
            // 
            this.BoardPn.BackColor = System.Drawing.Color.White;
            this.BoardPn.Controls.Add(this.ballPbox);
            this.BoardPn.Location = new System.Drawing.Point(371, 4);
            this.BoardPn.Name = "BoardPn";
            this.BoardPn.Size = new System.Drawing.Size(450, 450);
            this.BoardPn.TabIndex = 5;
            // 
            // ballPbox
            // 
            this.ballPbox.Image = global::ExamFinale.Properties.Resources.ball;
            this.ballPbox.InitialImage = null;
            this.ballPbox.Location = new System.Drawing.Point(180, 190);
            this.ballPbox.Name = "ballPbox";
            this.ballPbox.Size = new System.Drawing.Size(60, 60);
            this.ballPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballPbox.TabIndex = 0;
            this.ballPbox.TabStop = false;
            // 
            // leftBt
            // 
            this.leftBt.BackgroundImage = global::ExamFinale.Properties.Resources.key4;
            this.leftBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftBt.Location = new System.Drawing.Point(103, 369);
            this.leftBt.Name = "leftBt";
            this.leftBt.Size = new System.Drawing.Size(70, 70);
            this.leftBt.TabIndex = 9;
            this.leftBt.UseVisualStyleBackColor = true;
            this.leftBt.Click += new System.EventHandler(this.leftBt_Click);
            // 
            // rightBt
            // 
            this.rightBt.BackgroundImage = global::ExamFinale.Properties.Resources.key3;
            this.rightBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightBt.Location = new System.Drawing.Point(262, 369);
            this.rightBt.Name = "rightBt";
            this.rightBt.Size = new System.Drawing.Size(70, 70);
            this.rightBt.TabIndex = 8;
            this.rightBt.UseVisualStyleBackColor = true;
            this.rightBt.Click += new System.EventHandler(this.rightBt_Click);
            // 
            // downBt
            // 
            this.downBt.BackgroundImage = global::ExamFinale.Properties.Resources.key;
            this.downBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downBt.Location = new System.Drawing.Point(186, 369);
            this.downBt.Name = "downBt";
            this.downBt.Size = new System.Drawing.Size(70, 70);
            this.downBt.TabIndex = 7;
            this.downBt.UseVisualStyleBackColor = true;
            this.downBt.Click += new System.EventHandler(this.downBt_Click);
            // 
            // upBt
            // 
            this.upBt.BackgroundImage = global::ExamFinale.Properties.Resources.key2;
            this.upBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upBt.Location = new System.Drawing.Point(186, 293);
            this.upBt.Name = "upBt";
            this.upBt.Size = new System.Drawing.Size(70, 70);
            this.upBt.TabIndex = 6;
            this.upBt.UseVisualStyleBackColor = true;
            this.upBt.Click += new System.EventHandler(this.upBt_Click);
            // 
            // BallGamePn
            // 
            this.BallGamePn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BallGamePn.Controls.Add(this.leftBt);
            this.BallGamePn.Controls.Add(this.rightBt);
            this.BallGamePn.Controls.Add(this.downBt);
            this.BallGamePn.Controls.Add(this.upBt);
            this.BallGamePn.Controls.Add(this.BoardPn);
            this.BallGamePn.Location = new System.Drawing.Point(427, 8);
            this.BallGamePn.Name = "BallGamePn";
            this.BallGamePn.Size = new System.Drawing.Size(894, 486);
            this.BallGamePn.TabIndex = 10;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 588);
            this.Controls.Add(this.BallGamePn);
            this.Controls.Add(this.progressBt);
            this.Controls.Add(this.progresLeb);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.TextBoxLeb);
            this.Controls.Add(this.TextBoxNub);
            this.Name = "ExamForm";
            this.Text = "ExamWin";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExamForm_KeyDown);
            this.BoardPn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballPbox)).EndInit();
            this.BallGamePn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNub;
        private System.Windows.Forms.Label TextBoxLeb;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progresLeb;
        private System.Windows.Forms.Button progressBt;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Panel BoardPn;
        private System.Windows.Forms.Button upBt;
        private System.Windows.Forms.Button downBt;
        private System.Windows.Forms.Button rightBt;
        private System.Windows.Forms.Button leftBt;
        private System.Windows.Forms.PictureBox ballPbox;
        private System.Windows.Forms.Panel BallGamePn;
    }
}

