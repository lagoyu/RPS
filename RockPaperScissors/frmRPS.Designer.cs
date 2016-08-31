namespace RockPaperScissors
{
    partial class frmRPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPS));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picComp = new System.Windows.Forms.PictureBox();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblCompScore = new System.Windows.Forms.Label();
            this.tmrChoiceRotator = new System.Windows.Forms.Timer(this.components);
            this.lblMessages = new System.Windows.Forms.Label();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.tmrReadingDelay = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComp)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.AccessibleDescription = "";
            this.btnRock.AccessibleName = "";
            this.btnRock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRock.Location = new System.Drawing.Point(19, 19);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(59, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.TabStop = false;
            this.btnRock.Text = "&Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(19, 48);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(59, 23);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.TabStop = false;
            this.btnPaper.Text = "&Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(19, 77);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(59, 23);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.TabStop = false;
            this.btnScissors.Text = "&Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computer";
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(44, 52);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(158, 164);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 5;
            this.picUser.TabStop = false;
            // 
            // picComp
            // 
            this.picComp.InitialImage = null;
            this.picComp.Location = new System.Drawing.Point(208, 52);
            this.picComp.Name = "picComp";
            this.picComp.Size = new System.Drawing.Size(158, 164);
            this.picComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComp.TabIndex = 6;
            this.picComp.TabStop = false;
            // 
            // lblUserScore
            // 
            this.lblUserScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserScore.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.Location = new System.Drawing.Point(62, 224);
            this.lblUserScore.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(126, 38);
            this.lblUserScore.TabIndex = 7;
            this.lblUserScore.Text = "0";
            this.lblUserScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompScore
            // 
            this.lblCompScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompScore.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompScore.Location = new System.Drawing.Point(226, 224);
            this.lblCompScore.Margin = new System.Windows.Forms.Padding(0);
            this.lblCompScore.Name = "lblCompScore";
            this.lblCompScore.Size = new System.Drawing.Size(118, 38);
            this.lblCompScore.TabIndex = 8;
            this.lblCompScore.Text = "0";
            this.lblCompScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrChoiceRotator
            // 
            this.tmrChoiceRotator.Enabled = true;
            this.tmrChoiceRotator.Interval = 200;
            this.tmrChoiceRotator.Tick += new System.EventHandler(this.tmrChoiceRotator_Tick);
            // 
            // lblMessages
            // 
            this.lblMessages.BackColor = System.Drawing.SystemColors.Info;
            this.lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblMessages.Location = new System.Drawing.Point(236, 271);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(95, 110);
            this.lblMessages.TabIndex = 9;
            this.lblMessages.Text = "It\'s time to choose...";
            this.lblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnRock);
            this.grpButtons.Controls.Add(this.btnPaper);
            this.grpButtons.Controls.Add(this.btnScissors);
            this.grpButtons.Location = new System.Drawing.Point(75, 263);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(96, 118);
            this.grpButtons.TabIndex = 10;
            this.grpButtons.TabStop = false;
            // 
            // tmrReadingDelay
            // 
            this.tmrReadingDelay.Interval = 2500;
            this.tmrReadingDelay.Tick += new System.EventHandler(this.tmrReadingDelay_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 399);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.toolTip1.SetToolTip(this.btnHelp, "How to play");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(321, 398);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.toolTip1.SetToolTip(this.btnAbout, "Program details");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(408, 434);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lblCompScore);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.picComp);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRPS";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.frmRPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComp)).EndInit();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picComp;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblCompScore;
        private System.Windows.Forms.Timer tmrChoiceRotator;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Timer tmrReadingDelay;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

