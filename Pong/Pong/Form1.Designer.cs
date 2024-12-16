namespace Pong
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
            this.Lbat = new System.Windows.Forms.Label();
            this.topBar = new System.Windows.Forms.Label();
            this.botBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rbat = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Label();
            this.TMRup = new System.Windows.Forms.Timer(this.components);
            this.TMRai = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BallTrack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbat
            // 
            this.Lbat.AutoSize = true;
            this.Lbat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbat.Location = new System.Drawing.Point(25, 331);
            this.Lbat.MaximumSize = new System.Drawing.Size(15, 100);
            this.Lbat.Name = "Lbat";
            this.Lbat.Size = new System.Drawing.Size(13, 100);
            this.Lbat.TabIndex = 0;
            this.Lbat.Text = "0000000000000000000000000";
            // 
            // topBar
            // 
            this.topBar.AutoSize = true;
            this.topBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.MaximumSize = new System.Drawing.Size(800, 20);
            this.topBar.MinimumSize = new System.Drawing.Size(1920, 20);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1920, 20);
            this.topBar.TabIndex = 2;
            this.topBar.Text = "0000000000000000000000000";
            // 
            // botBar
            // 
            this.botBar.AutoSize = true;
            this.botBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botBar.Location = new System.Drawing.Point(0, 1061);
            this.botBar.MaximumSize = new System.Drawing.Size(800, 20);
            this.botBar.MinimumSize = new System.Drawing.Size(1920, 80);
            this.botBar.Name = "botBar";
            this.botBar.Size = new System.Drawing.Size(1920, 80);
            this.botBar.TabIndex = 3;
            this.botBar.Text = "0000000000000000000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Rbat
            // 
            this.Rbat.AutoSize = true;
            this.Rbat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rbat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rbat.Location = new System.Drawing.Point(1895, 391);
            this.Rbat.MaximumSize = new System.Drawing.Size(15, 100);
            this.Rbat.Name = "Rbat";
            this.Rbat.Size = new System.Drawing.Size(13, 100);
            this.Rbat.TabIndex = 5;
            this.Rbat.Text = "0000000000000000000000000";
            // 
            // ball
            // 
            this.ball.AutoSize = true;
            this.ball.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ball.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ball.Location = new System.Drawing.Point(858, 381);
            this.ball.MaximumSize = new System.Drawing.Size(18, 18);
            this.ball.MinimumSize = new System.Drawing.Size(18, 18);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(18, 18);
            this.ball.TabIndex = 6;
            this.ball.Text = "0000";
            // 
            // TMRup
            // 
            this.TMRup.Interval = 1;
            this.TMRup.Tick += new System.EventHandler(this.TMRup_Tick);
            // 
            // TMRai
            // 
            this.TMRai.Interval = 10;
            this.TMRai.Tick += new System.EventHandler(this.TMRai_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(933, 20);
            this.label2.MaximumSize = new System.Drawing.Size(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 100);
            this.label2.TabIndex = 7;
            this.label2.Text = "0000000000000000000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(933, 145);
            this.label3.MaximumSize = new System.Drawing.Size(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 100);
            this.label3.TabIndex = 8;
            this.label3.Text = "0000000000000000000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(933, 282);
            this.label4.MaximumSize = new System.Drawing.Size(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 100);
            this.label4.TabIndex = 9;
            this.label4.Text = "0000000000000000000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(933, 431);
            this.label5.MaximumSize = new System.Drawing.Size(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 100);
            this.label5.TabIndex = 10;
            this.label5.Text = "0000000000000000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(933, 563);
            this.label6.MaximumSize = new System.Drawing.Size(15, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 100);
            this.label6.TabIndex = 11;
            this.label6.Text = "0000000000000000000000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(933, 696);
            this.label7.MaximumSize = new System.Drawing.Size(15, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 100);
            this.label7.TabIndex = 12;
            this.label7.Text = "0000000000000000000000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(933, 843);
            this.label8.MaximumSize = new System.Drawing.Size(15, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 100);
            this.label8.TabIndex = 13;
            this.label8.Text = "0000000000000000000000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(933, 997);
            this.label9.MaximumSize = new System.Drawing.Size(15, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 100);
            this.label9.TabIndex = 14;
            this.label9.Text = "0000000000000000000000000";
            // 
            // BallTrack
            // 
            this.BallTrack.AutoSize = true;
            this.BallTrack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BallTrack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BallTrack.Location = new System.Drawing.Point(1895, 721);
            this.BallTrack.MaximumSize = new System.Drawing.Size(18, 18);
            this.BallTrack.MinimumSize = new System.Drawing.Size(18, 18);
            this.BallTrack.Name = "BallTrack";
            this.BallTrack.Size = new System.Drawing.Size(18, 18);
            this.BallTrack.TabIndex = 15;
            this.BallTrack.Text = "0000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.BallTrack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Rbat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botBar);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.Lbat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbat;
        private System.Windows.Forms.Label topBar;
        private System.Windows.Forms.Label botBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Rbat;
        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Timer TMRup;
        private System.Windows.Forms.Timer TMRai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label BallTrack;
    }
}

