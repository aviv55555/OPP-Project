
namespace finalProjOOP.Frontend.Forms
{
    partial class MarineGame1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarineGame1));
            this.backGroundP = new System.Windows.Forms.Panel();
            this.winPictureBox = new System.Windows.Forms.PictureBox();
            this.lostPictureBox = new System.Windows.Forms.PictureBox();
            this.boatPanel = new System.Windows.Forms.Panel();
            this.icePanel = new System.Windows.Forms.Panel();
            this.TruserePanel = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.backGroundP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lostPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backGroundP
            // 
            this.backGroundP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backGroundP.BackgroundImage")));
            this.backGroundP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backGroundP.Controls.Add(this.winPictureBox);
            this.backGroundP.Controls.Add(this.lostPictureBox);
            this.backGroundP.Controls.Add(this.boatPanel);
            this.backGroundP.Controls.Add(this.icePanel);
            this.backGroundP.Controls.Add(this.TruserePanel);
            this.backGroundP.Location = new System.Drawing.Point(-5, -37);
            this.backGroundP.Margin = new System.Windows.Forms.Padding(4);
            this.backGroundP.Name = "backGroundP";
            this.backGroundP.Size = new System.Drawing.Size(1352, 835);
            this.backGroundP.TabIndex = 7;
            // 
            // winPictureBox
            // 
            this.winPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.winPictureBox.BackgroundImage = global::finalProjOOP.Properties.Resources.WIN_GAME_removebg_preview;
            this.winPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winPictureBox.Location = new System.Drawing.Point(31, 33);
            this.winPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.winPictureBox.Name = "winPictureBox";
            this.winPictureBox.Size = new System.Drawing.Size(1282, 783);
            this.winPictureBox.TabIndex = 4;
            this.winPictureBox.TabStop = false;
            this.winPictureBox.Visible = false;
            // 
            // lostPictureBox
            // 
            this.lostPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.lostPictureBox.BackgroundImage = global::finalProjOOP.Properties.Resources.Game_Over;
            this.lostPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lostPictureBox.Location = new System.Drawing.Point(186, 103);
            this.lostPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.lostPictureBox.Name = "lostPictureBox";
            this.lostPictureBox.Size = new System.Drawing.Size(998, 641);
            this.lostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lostPictureBox.TabIndex = 4;
            this.lostPictureBox.TabStop = false;
            this.lostPictureBox.Visible = false;
            // 
            // boatPanel
            // 
            this.boatPanel.BackColor = System.Drawing.Color.Transparent;
            this.boatPanel.BackgroundImage = global::finalProjOOP.Properties.Resources.shipgamephoto_removebg_preview;
            this.boatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boatPanel.Location = new System.Drawing.Point(4, 365);
            this.boatPanel.Margin = new System.Windows.Forms.Padding(4);
            this.boatPanel.Name = "boatPanel";
            this.boatPanel.Size = new System.Drawing.Size(270, 244);
            this.boatPanel.TabIndex = 2;
            // 
            // icePanel
            // 
            this.icePanel.BackColor = System.Drawing.Color.Transparent;
            this.icePanel.BackgroundImage = global::finalProjOOP.Properties.Resources.antarctica_removebg_preview;
            this.icePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icePanel.Location = new System.Drawing.Point(638, 352);
            this.icePanel.Margin = new System.Windows.Forms.Padding(4);
            this.icePanel.Name = "icePanel";
            this.icePanel.Size = new System.Drawing.Size(308, 315);
            this.icePanel.TabIndex = 2;
            // 
            // TruserePanel
            // 
            this.TruserePanel.BackColor = System.Drawing.Color.Transparent;
            this.TruserePanel.BackgroundImage = global::finalProjOOP.Properties.Resources.Cartoon_treasure_removebg_preview1;
            this.TruserePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TruserePanel.Location = new System.Drawing.Point(56, 604);
            this.TruserePanel.Margin = new System.Windows.Forms.Padding(4);
            this.TruserePanel.Name = "TruserePanel";
            this.TruserePanel.Size = new System.Drawing.Size(176, 190);
            this.TruserePanel.TabIndex = 3;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.Location = new System.Drawing.Point(95, 49);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(166, 46);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "button1";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonPlay_KeyPress);
            // 
            // MarineGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 760);
            this.Controls.Add(this.backGroundP);
            this.Controls.Add(this.buttonPlay);
            this.Name = "MarineGame1";
            this.Text = "MarineGame1";
            this.backGroundP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lostPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backGroundP;
        private System.Windows.Forms.PictureBox winPictureBox;
        private System.Windows.Forms.PictureBox lostPictureBox;
        private System.Windows.Forms.Panel boatPanel;
        private System.Windows.Forms.Panel icePanel;
        private System.Windows.Forms.Panel TruserePanel;
        private System.Windows.Forms.Button buttonPlay;
    }
}