
namespace _3inRowGame.Pages
{
    partial class GamePage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.formPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playFieldPanel = new System.Windows.Forms.Panel();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.formPanel.Size = new System.Drawing.Size(628, 486);
            this.formPanel.TabIndex = 3;
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
            // playFieldPanel
            // 
            this.playFieldPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playFieldPanel.Location = new System.Drawing.Point(150, 0);
            this.playFieldPanel.Margin = new System.Windows.Forms.Padding(0);
            this.playFieldPanel.Name = "playFieldPanel";
            this.playFieldPanel.Size = new System.Drawing.Size(208, 100);
            this.playFieldPanel.TabIndex = 0;
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.formPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GamePage";
            this.Size = new System.Drawing.Size(628, 486);
            this.formPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel formPanel;
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private System.Windows.Forms.Panel playFieldPanel;
    }
}
