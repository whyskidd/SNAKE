namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            this.timer = new System.Windows.Forms.Timer(this.components);
            button1 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1.CausesValidation = false;
            button1.Enabled = false;
            button1.Location = new System.Drawing.Point(-3, -2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(854, 10);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            button4.CausesValidation = false;
            button4.Enabled = false;
            button4.Image = global::Snake.Properties.Resources.image_3;
            button4.Location = new System.Drawing.Point(-7, 751);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(980, 10);
            button4.TabIndex = 3;
            button4.TabStop = false;
            button4.Text = "button4";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            button2.CausesValidation = false;
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(-3, 1);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(10, 758);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            button3.CausesValidation = false;
            button3.Enabled = false;
            button3.Location = new System.Drawing.Point(841, 36);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(10, 719);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 792);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
    }
}

