namespace DiceGame
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
            this.valueTxt = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueTxt
            // 
            this.valueTxt.AutoSize = true;
            this.valueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTxt.Location = new System.Drawing.Point(173, 82);
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.Size = new System.Drawing.Size(0, 24);
            this.valueTxt.TabIndex = 0;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(12, 77);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(101, 23);
            this.Draw.TabIndex = 1;
            this.Draw.Text = "Бросить куб";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 167);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.valueTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valueTxt;
        private System.Windows.Forms.Button Draw;
    }
}

