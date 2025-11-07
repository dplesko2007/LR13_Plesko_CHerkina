namespace LR13_Plesko_CHerkina
{
    partial class Form1
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
            this.buttonHello = new System.Windows.Forms.Button();
            this.buttonGoodbye = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(208, 120);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(128, 70);
            this.buttonHello.TabIndex = 0;
            this.buttonHello.Text = "Привет";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click_1);
            // 
            // buttonGoodbye
            // 
            this.buttonGoodbye.Location = new System.Drawing.Point(383, 120);
            this.buttonGoodbye.Name = "buttonGoodbye";
            this.buttonGoodbye.Size = new System.Drawing.Size(130, 69);
            this.buttonGoodbye.TabIndex = 1;
            this.buttonGoodbye.Text = "До свидания";
            this.buttonGoodbye.UseVisualStyleBackColor = true;
            this.buttonGoodbye.Click += new System.EventHandler(this.buttonGoodbye_Click_1);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessage.Location = new System.Drawing.Point(280, 217);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(149, 29);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "(пока пусто)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonGoodbye);
            this.Controls.Add(this.buttonHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Button buttonGoodbye;
        private System.Windows.Forms.Label labelMessage;
    }
}

