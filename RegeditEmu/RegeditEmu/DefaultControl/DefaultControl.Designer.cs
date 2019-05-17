namespace RegeditEmu.UserControls
{
    partial class DefaultControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dflt_button = new System.Windows.Forms.Button();
            this.RgSz = new System.Windows.Forms.Label();
            this.Unknwn = new System.Windows.Forms.Label();
            this.Imya = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imya,
            this.Type,
            this.Value});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // Dflt_button
            // 
            this.Dflt_button.Location = new System.Drawing.Point(43, 23);
            this.Dflt_button.Name = "Dflt_button";
            this.Dflt_button.Size = new System.Drawing.Size(99, 20);
            this.Dflt_button.TabIndex = 1;
            this.Dflt_button.Text = "(по умолчанию)";
            this.Dflt_button.UseVisualStyleBackColor = true;
            // 
            // RgSz
            // 
            this.RgSz.AutoSize = true;
            this.RgSz.Location = new System.Drawing.Point(148, 27);
            this.RgSz.Name = "RgSz";
            this.RgSz.Size = new System.Drawing.Size(50, 13);
            this.RgSz.TabIndex = 2;
            this.RgSz.Text = "REG_SZ";
            // 
            // Unknwn
            // 
            this.Unknwn.AutoSize = true;
            this.Unknwn.Location = new System.Drawing.Point(244, 27);
            this.Unknwn.Name = "Unknwn";
            this.Unknwn.Size = new System.Drawing.Size(132, 13);
            this.Unknwn.TabIndex = 3;
            this.Unknwn.Text = "(значение не присвоено)";
            // 
            // Imya
            // 
            this.Imya.HeaderText = "Имя";
            this.Imya.Name = "Imya";
            this.Imya.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imya.Text = "(По умолчанию)";
            this.Imya.ToolTipText = "(По умолчанию)";
            this.Imya.UseColumnTextForButtonValue = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.ToolTipText = "REG_SZ";
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Value.ToolTipText = "(Значение не присвоено)";
            this.Value.Width = 145;
            // 
            // DefaultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Unknwn);
            this.Controls.Add(this.RgSz);
            this.Controls.Add(this.Dflt_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DefaultControl";
            this.Size = new System.Drawing.Size(752, 311);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Imya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button Dflt_button;
        private System.Windows.Forms.Label RgSz;
        private System.Windows.Forms.Label Unknwn;
    }
}
