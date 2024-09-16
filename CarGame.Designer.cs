
namespace finalProjOOP.Frontend.Forms
{
    partial class CarGame
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.lostPictureBox = new System.Windows.Forms.PictureBox();
            this.bracksPictureBox2 = new System.Windows.Forms.PictureBox();
            this.carPanel = new System.Windows.Forms.Panel();
            this.bracksPictureBox1 = new System.Windows.Forms.PictureBox();
            this.plusPictureBox = new System.Windows.Forms.PictureBox();
            this.roadPictureBox = new System.Windows.Forms.PictureBox();
            this.backGroundPanel = new System.Windows.Forms.Panel();
            this.winPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lostPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracksPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracksPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPlay.Location = new System.Drawing.Point(537, 18);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(150, 44);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "button1";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonPlay_KeyPress);
            // 
            // lostPictureBox
            // 
            this.lostPictureBox.Image = global::finalProjOOP.Properties.Resources.Game_Over;
            this.lostPictureBox.Location = new System.Drawing.Point(51, 64);
            this.lostPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.lostPictureBox.Name = "lostPictureBox";
            this.lostPictureBox.Size = new System.Drawing.Size(1114, 712);
            this.lostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lostPictureBox.TabIndex = 9;
            this.lostPictureBox.TabStop = false;
            this.lostPictureBox.Visible = false;
            // 
            // bracksPictureBox2
            // 
            this.bracksPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.bracksPictureBox2.BackgroundImage = global::finalProjOOP.Properties.Resources.bricks;
            this.bracksPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bracksPictureBox2.Location = new System.Drawing.Point(589, 74);
            this.bracksPictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.bracksPictureBox2.Name = "bracksPictureBox2";
            this.bracksPictureBox2.Size = new System.Drawing.Size(226, 117);
            this.bracksPictureBox2.TabIndex = 15;
            this.bracksPictureBox2.TabStop = false;
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carPanel.BackgroundImage = global::finalProjOOP.Properties.Resources.Cargamphoto_removebg_preview;
            this.carPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carPanel.Location = new System.Drawing.Point(537, 776);
            this.carPanel.Margin = new System.Windows.Forms.Padding(6);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(62, 127);
            this.carPanel.TabIndex = 12;
            // 
            // bracksPictureBox1
            // 
            this.bracksPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bracksPictureBox1.BackgroundImage = global::finalProjOOP.Properties.Resources.bricks;
            this.bracksPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bracksPictureBox1.Location = new System.Drawing.Point(419, 585);
            this.bracksPictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.bracksPictureBox1.Name = "bracksPictureBox1";
            this.bracksPictureBox1.Size = new System.Drawing.Size(226, 117);
            this.bracksPictureBox1.TabIndex = 11;
            this.bracksPictureBox1.TabStop = false;
            // 
            // plusPictureBox
            // 
            this.plusPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.plusPictureBox.BackgroundImage = global::finalProjOOP.Properties.Resources.plus_removebg_preview;
            this.plusPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plusPictureBox.Location = new System.Drawing.Point(505, 412);
            this.plusPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.plusPictureBox.Name = "plusPictureBox";
            this.plusPictureBox.Size = new System.Drawing.Size(76, 67);
            this.plusPictureBox.TabIndex = 14;
            this.plusPictureBox.TabStop = false;
            // 
            // roadPictureBox
            // 
            this.roadPictureBox.BackgroundImage = global::finalProjOOP.Properties.Resources.cvish;
            this.roadPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roadPictureBox.Location = new System.Drawing.Point(399, -5);
            this.roadPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.roadPictureBox.Name = "roadPictureBox";
            this.roadPictureBox.Size = new System.Drawing.Size(466, 908);
            this.roadPictureBox.TabIndex = 10;
            this.roadPictureBox.TabStop = false;
            // 
            // backGroundPanel
            // 
            this.backGroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.backGroundPanel.BackgroundImage = global::finalProjOOP.Properties.Resources.trees;
            this.backGroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backGroundPanel.Location = new System.Drawing.Point(1, -4);
            this.backGroundPanel.Name = "backGroundPanel";
            this.backGroundPanel.Size = new System.Drawing.Size(1214, 905);
            this.backGroundPanel.TabIndex = 16;
            // 
            // winPictureBox
            // 
            this.winPictureBox.BackgroundImage = global::finalProjOOP.Properties.Resources.WIN_GAME_removebg_preview;
            this.winPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winPictureBox.Location = new System.Drawing.Point(124, 140);
            this.winPictureBox.Name = "winPictureBox";
            this.winPictureBox.Size = new System.Drawing.Size(986, 596);
            this.winPictureBox.TabIndex = 17;
            this.winPictureBox.TabStop = false;
            this.winPictureBox.Visible = false;
            // 
            // CarGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1216, 898);
            this.Controls.Add(this.winPictureBox);
            this.Controls.Add(this.lostPictureBox);
            this.Controls.Add(this.bracksPictureBox2);
            this.Controls.Add(this.carPanel);
            this.Controls.Add(this.bracksPictureBox1);
            this.Controls.Add(this.plusPictureBox);
            this.Controls.Add(this.roadPictureBox);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.backGroundPanel);
            this.Name = "CarGame";
            this.Text = "CarGame";
            ((System.ComponentModel.ISupportInitialize)(this.lostPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracksPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bracksPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox lostPictureBox;
        private System.Windows.Forms.PictureBox bracksPictureBox2;
        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.PictureBox bracksPictureBox1;
        private System.Windows.Forms.PictureBox plusPictureBox;
        private System.Windows.Forms.PictureBox roadPictureBox;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel backGroundPanel;
        private System.Windows.Forms.PictureBox winPictureBox;
    }
}