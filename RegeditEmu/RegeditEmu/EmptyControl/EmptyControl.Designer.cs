namespace RegeditEmu.UserControls
{
    partial class EmptyControl
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
            this.Imya = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Imya
            // 
            this.Imya.AutoSize = true;
            this.Imya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Imya.Location = new System.Drawing.Point(3, 0);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(32, 15);
            this.Imya.TabIndex = 0;
            this.Imya.Text = "Имя";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.Location = new System.Drawing.Point(143, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(28, 15);
            this.Type.TabIndex = 1;
            this.Type.Text = "Тип";
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Value.Location = new System.Drawing.Point(291, 0);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(63, 15);
            this.Value.TabIndex = 2;
            this.Value.Text = "Значение";
            // 
            // EmptyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Imya);
            this.Name = "EmptyControl";
            this.Size = new System.Drawing.Size(717, 420);
            this.Load += new System.EventHandler(this.EmptyControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Imya;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Value;
    }
}
