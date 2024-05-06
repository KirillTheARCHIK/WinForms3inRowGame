
namespace _3inRowGame
{
    partial class PlayForm
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
            this.playFieldPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.formPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playFieldPanel
            // 
            this.playFieldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playFieldPanel.Location = new System.Drawing.Point(150, 0);
            this.playFieldPanel.Margin = new System.Windows.Forms.Padding(0);
            this.playFieldPanel.Name = "playFieldPanel";
            this.playFieldPanel.Size = new System.Drawing.Size(208, 100);
            this.playFieldPanel.TabIndex = 0;
            this.playFieldPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DefaultItem_MouseUp);
            // 
            // leftPanel
            // 
            this.leftPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 450);
            this.leftPanel.TabIndex = 1;
            // 
            // formPanel
            // 
            this.formPanel.AutoSize = true;
            this.formPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formPanel.Controls.Add(this.leftPanel);
            this.formPanel.Controls.Add(this.playFieldPanel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(789, 459);
            this.formPanel.TabIndex = 2;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 459);
            this.Controls.Add(this.formPanel);
            this.Name = "PlayForm";
            this.formPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playFieldPanel;
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private System.Windows.Forms.FlowLayoutPanel formPanel;
    }
}