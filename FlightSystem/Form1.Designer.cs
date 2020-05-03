namespace FlightSystem
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
            this.cpbMPH = new CircularProgressBar.CircularProgressBar();
            this.cpbBearing = new CircularProgressBar.CircularProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // cpbMPH
            // 
            this.cpbMPH.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.cpbMPH.AnimationSpeed = 9000;
            this.cpbMPH.BackColor = System.Drawing.Color.Transparent;
            this.cpbMPH.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbMPH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbMPH.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbMPH.InnerMargin = 2;
            this.cpbMPH.InnerWidth = -1;
            this.cpbMPH.Location = new System.Drawing.Point(12, 12);
            this.cpbMPH.MarqueeAnimationSpeed = 9000;
            this.cpbMPH.Maximum = 1250;
            this.cpbMPH.Minimum = 250;
            this.cpbMPH.Name = "cpbMPH";
            this.cpbMPH.OuterColor = System.Drawing.Color.Gray;
            this.cpbMPH.OuterMargin = -25;
            this.cpbMPH.OuterWidth = 26;
            this.cpbMPH.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbMPH.ProgressWidth = 25;
            this.cpbMPH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cpbMPH.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbMPH.Size = new System.Drawing.Size(179, 171);
            this.cpbMPH.StartAngle = 45;
            this.cpbMPH.Step = 5;
            this.cpbMPH.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbMPH.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbMPH.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbMPH.SubscriptText = "";
            this.cpbMPH.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbMPH.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbMPH.SuperscriptText = "";
            this.cpbMPH.TabIndex = 0;
            this.cpbMPH.Text = "0000";
            this.cpbMPH.TextMargin = new System.Windows.Forms.Padding(8, 8, 15, 0);
            this.cpbMPH.Value = 250;
            this.cpbMPH.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // cpbBearing
            // 
            this.cpbBearing.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.cpbBearing.AnimationSpeed = 9000;
            this.cpbBearing.BackColor = System.Drawing.Color.Transparent;
            this.cpbBearing.Font = new System.Drawing.Font("Times New Roman", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbBearing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbBearing.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbBearing.InnerMargin = 2;
            this.cpbBearing.InnerWidth = -1;
            this.cpbBearing.Location = new System.Drawing.Point(513, 12);
            this.cpbBearing.MarqueeAnimationSpeed = 9000;
            this.cpbBearing.Maximum = 360;
            this.cpbBearing.Name = "cpbBearing";
            this.cpbBearing.OuterColor = System.Drawing.Color.Gray;
            this.cpbBearing.OuterMargin = -25;
            this.cpbBearing.OuterWidth = 26;
            this.cpbBearing.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbBearing.ProgressWidth = 25;
            this.cpbBearing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cpbBearing.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbBearing.Size = new System.Drawing.Size(179, 171);
            this.cpbBearing.StartAngle = 90;
            this.cpbBearing.Step = 5;
            this.cpbBearing.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbBearing.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBearing.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbBearing.SubscriptText = "";
            this.cpbBearing.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBearing.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbBearing.SuperscriptText = "";
            this.cpbBearing.TabIndex = 1;
            this.cpbBearing.Text = "000°";
            this.cpbBearing.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbBearing.Value = 180;
            this.cpbBearing.Click += new System.EventHandler(this.cpbBearing_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Correct Bearing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 161);
            this.label1.MinimumSize = new System.Drawing.Size(179, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "On Course";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 189);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 274);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 531);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpbBearing);
            this.Controls.Add(this.cpbMPH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Flight System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpbMPH;
        private CircularProgressBar.CircularProgressBar cpbBearing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

