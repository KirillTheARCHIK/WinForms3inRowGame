
namespace _3inRowGame
{
    partial class StartGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGame));
            this.background = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(12, 12);
            this.background.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.background.MinimumSize = new System.Drawing.Size(776, 426);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(776, 426);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.Location = new System.Drawing.Point(341, 341);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 42);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(23, 25);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(51, 42);
            this.settings.TabIndex = 3;
            this.settings.Text = "(0)";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startButton.Location = new System.Drawing.Point(341, 282);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 42);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "START GAME";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.background);
            this.Name = "StartGame";
            this.Text = "StartGame";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button startButton;
    }
}