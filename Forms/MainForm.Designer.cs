
namespace _3inRowGame
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigatorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // navigatorPanel
            // 
            this.navigatorPanel.AutoSize = true;
            this.navigatorPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navigatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigatorPanel.Location = new System.Drawing.Point(0, 0);
            this.navigatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigatorPanel.Name = "navigatorPanel";
            this.navigatorPanel.Size = new System.Drawing.Size(784, 461);
            this.navigatorPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.navigatorPanel);
            this.Name = "MainForm";
            this.Text = "Три в ряд";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigatorPanel;
    }
}

