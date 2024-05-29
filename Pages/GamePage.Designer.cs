
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
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.formPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
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
            this.leftPanel.Controls.Add(this.labelScore);
            this.leftPanel.Controls.Add(this.buttonRestart);
            this.leftPanel.Controls.Add(this.buttonExit);
            this.leftPanel.Controls.Add(this.buttonSettings);
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
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(3, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(74, 24);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Счёт: 0";
            // 
            // buttonRestart
            // 
            this.buttonRestart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(3, 27);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(144, 35);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Заново";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(3, 68);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(144, 35);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(3, 109);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(144, 35);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
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
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel formPanel;
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private System.Windows.Forms.Panel playFieldPanel;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
    }
}
