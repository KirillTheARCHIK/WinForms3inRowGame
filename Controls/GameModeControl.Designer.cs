namespace _3inRowGame.Controls
{
    partial class GameModeControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonModeUnique = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonModePlaceUnique = new System.Windows.Forms.Button();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonModeFields = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.buttonDefault);
            this.flowLayoutPanel1.Controls.Add(this.buttonModeUnique);
            this.flowLayoutPanel1.Controls.Add(this.buttonModePlaceUnique);
            this.flowLayoutPanel1.Controls.Add(this.buttonModeFields);
            this.flowLayoutPanel1.Controls.Add(this.buttonBack);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 327);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // buttonModeUnique
            // 
            this.buttonModeUnique.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonModeUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModeUnique.Location = new System.Drawing.Point(3, 103);
            this.buttonModeUnique.Name = "buttonModeUnique";
            this.buttonModeUnique.Size = new System.Drawing.Size(250, 56);
            this.buttonModeUnique.TabIndex = 0;
            this.buttonModeUnique.Text = "Сбор уникальных\r\n элементов";
            this.buttonModeUnique.UseVisualStyleBackColor = true;
            this.buttonModeUnique.Click += new System.EventHandler(this.buttonModeUnique_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(3, 289);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(250, 35);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonModePlaceUnique
            // 
            this.buttonModePlaceUnique.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonModePlaceUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModePlaceUnique.Location = new System.Drawing.Point(3, 165);
            this.buttonModePlaceUnique.Name = "buttonModePlaceUnique";
            this.buttonModePlaceUnique.Size = new System.Drawing.Size(250, 56);
            this.buttonModePlaceUnique.TabIndex = 2;
            this.buttonModePlaceUnique.Text = "Падение уникальных\r\n элементов";
            this.buttonModePlaceUnique.UseVisualStyleBackColor = true;
            this.buttonModePlaceUnique.Click += new System.EventHandler(this.buttonModePlaceUnique_Click);
            // 
            // buttonDefault
            // 
            this.buttonDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDefault.Location = new System.Drawing.Point(3, 41);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(250, 56);
            this.buttonDefault.TabIndex = 3;
            this.buttonDefault.Text = "Стандартный";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonModeFields
            // 
            this.buttonModeFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonModeFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonModeFields.Location = new System.Drawing.Point(3, 227);
            this.buttonModeFields.Name = "buttonModeFields";
            this.buttonModeFields.Size = new System.Drawing.Size(250, 56);
            this.buttonModeFields.TabIndex = 4;
            this.buttonModeFields.Text = "Сбор элементов на определённых полях";
            this.buttonModeFields.UseVisualStyleBackColor = true;
            this.buttonModeFields.Click += new System.EventHandler(this.buttonModeFields_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбор режима";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameModeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GameModeControl";
            this.Size = new System.Drawing.Size(259, 330);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonModeUnique;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonModePlaceUnique;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonModeFields;
        private System.Windows.Forms.Label label1;
    }
}
