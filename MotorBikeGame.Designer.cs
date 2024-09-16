
namespace finalProjOOP.Frontend.Forms
{
    partial class MotorBikeGame
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
            this.roadPanel = new System.Windows.Forms.Panel();
            this.lostPictureBox = new System.Windows.Forms.PictureBox();
            this.winPictureBox = new System.Windows.Forms.PictureBox();
            this.brackP2 = new System.Windows.Forms.Panel();
            this.brackP1 = new System.Windows.Forms.Panel();
            this.buttryP = new System.Windows.Forms.Panel();
            this.motorBikeP = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.roadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // roadPanel
            // 
            this.roadPanel.BackColor = System.Drawing.Color.Transparent;
            this.roadPanel.BackgroundImage = global::finalProjOOP.Properties.Resources.road;
            this.roadPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roadPanel.Controls.Add(this.lostPictureBox);
            this.roadPanel.Controls.Add(this.winPictureBox);
            this.roadPanel.Controls.Add(this.brackP2);
            this.roadPanel.Controls.Add(this.brackP1);
            this.roadPanel.Controls.Add(this.buttryP);
            this.roadPanel.Controls.Add(this.motorBikeP);
            this.roadPanel.Controls.Add(this.buttonPlay);
            this.roadPanel.Location = new System.Drawing.Point(0, -5);
            this.roadPanel.Name = "roadPanel";
            this.roadPanel.Size = new System.Drawing.Size(1411, 391);
            this.roadPanel.TabIndex = 1;
            // 
            // lostPictureBox
            // 
            this.lostPictureBox.BackgroundImage = global::finalProjOOP.Properties.Resources.Game_Over;
            this.lostPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lostPictureBox.Location = new System.Drawing.Point(470, 17);
            this.lostPictureBox.Name = "lostPictureBox";
            this.lostPictureBox.Size = new System.Drawing.Size(503, 356);
            this.lostPictureBox.TabIndex = 6;
            this.lostPictureBox.TabStop = false;
            this.lostPictureBox.Visible = false;
            // 
            // winPictureBox
            // 
            this.winPictureBox.BackgroundImage = global::finalProjOOP.Properties.Resources.WIN_GAME_removebg_preview;
            this.winPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winPictureBox.Location = new System.Drawing.Point(339, -11);
            this.winPictureBox.Name = "winPictureBox";
            this.winPictureBox.Size = new System.Drawing.Size(744, 422);
            this.winPictureBox.TabIndex = 5;
            this.winPictureBox.TabStop = false;
            this.winPictureBox.Visible = false;
            // 
            // brackP2
            // 
            this.brackP2.BackgroundImage = global::finalProjOOP.Properties.Resources.brack_removebg_preview;
            this.brackP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brackP2.Location = new System.Drawing.Point(470, 64);
            this.brackP2.Name = "brackP2";
            this.brackP2.Size = new System.Drawing.Size(104, 122);
            this.brackP2.TabIndex = 4;
            // 
            // brackP1
            // 
            this.brackP1.BackgroundImage = global::finalProjOOP.Properties.Resources.brack_removebg_preview;
            this.brackP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brackP1.Location = new System.Drawing.Point(982, 224);
            this.brackP1.Name = "brackP1";
            this.brackP1.Size = new System.Drawing.Size(104, 122);
            this.brackP1.TabIndex = 3;
            // 
            // buttryP
            // 
            this.buttryP.BackgroundImage = global::finalProjOOP.Properties.Resources.buttry;
            this.buttryP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttryP.Location = new System.Drawing.Point(644, 64);
            this.buttryP.Name = "buttryP";
            this.buttryP.Size = new System.Drawing.Size(44, 106);
            this.buttryP.TabIndex = 1;
            // 
            // motorBikeP
            // 
            this.motorBikeP.BackgroundImage = global::finalProjOOP.Properties.Resources.motorbike_removebg_preview;
            this.motorBikeP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.motorBikeP.Location = new System.Drawing.Point(1190, 180);
            this.motorBikeP.Name = "motorBikeP";
            this.motorBikeP.Size = new System.Drawing.Size(219, 208);
            this.motorBikeP.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlay.Location = new System.Drawing.Point(119, 31);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(10, 10);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "buttonPlay";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonPlay_KeyPress);
            // 
            // MotorBikeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 380);
            this.Controls.Add(this.roadPanel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "MotorBikeGame";
            this.Text = "MotorBikeGame";
            this.roadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roadPanel;
        private System.Windows.Forms.PictureBox lostPictureBox;
        private System.Windows.Forms.PictureBox winPictureBox;
        private System.Windows.Forms.Panel brackP2;
        private System.Windows.Forms.Panel brackP1;
        private System.Windows.Forms.Panel buttryP;
        private System.Windows.Forms.Panel motorBikeP;
        private System.Windows.Forms.Button buttonPlay;
    }
}