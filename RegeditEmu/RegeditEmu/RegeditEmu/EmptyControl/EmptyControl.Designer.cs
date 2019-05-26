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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Imya = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowExt = new System.Windows.Forms.Button();
            this.Dflt_button = new System.Windows.Forms.Button();
            this.RgSz = new System.Windows.Forms.Label();
            this.Unknwn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cnflct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.info_1 = new System.Windows.Forms.Label();
            this.NoDocs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Size = new System.Drawing.Size(717, 420);
            this.dataGridView1.TabIndex = 1;
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
            // ShowExt
            // 
            this.ShowExt.Location = new System.Drawing.Point(42, 49);
            this.ShowExt.Name = "ShowExt";
            this.ShowExt.Size = new System.Drawing.Size(100, 23);
            this.ShowExt.TabIndex = 2;
            this.ShowExt.Text = "AlwaysShowExt";
            this.ShowExt.UseVisualStyleBackColor = true;
            // 
            // Dflt_button
            // 
            this.Dflt_button.Location = new System.Drawing.Point(43, 23);
            this.Dflt_button.Name = "Dflt_button";
            this.Dflt_button.Size = new System.Drawing.Size(99, 20);
            this.Dflt_button.TabIndex = 3;
            this.Dflt_button.Text = "(по умолчанию)";
            this.Dflt_button.UseVisualStyleBackColor = true;
            // 
            // RgSz
            // 
            this.RgSz.AutoSize = true;
            this.RgSz.Location = new System.Drawing.Point(148, 27);
            this.RgSz.Name = "RgSz";
            this.RgSz.Size = new System.Drawing.Size(50, 13);
            this.RgSz.TabIndex = 4;
            this.RgSz.Text = "REG_SZ";
            // 
            // Unknwn
            // 
            this.Unknwn.AutoSize = true;
            this.Unknwn.Location = new System.Drawing.Point(242, 27);
            this.Unknwn.Name = "Unknwn";
            this.Unknwn.Size = new System.Drawing.Size(132, 13);
            this.Unknwn.TabIndex = 5;
            this.Unknwn.Text = "(значение не присвоено)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "REG_SZ";
            // 
            // Cnflct
            // 
            this.Cnflct.Location = new System.Drawing.Point(43, 79);
            this.Cnflct.Name = "Cnflct";
            this.Cnflct.Size = new System.Drawing.Size(99, 23);
            this.Cnflct.TabIndex = 7;
            this.Cnflct.Text = "ConflictPrompt";
            this.Cnflct.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "REG_SZ";
            // 
            // info_1
            // 
            this.info_1.AutoSize = true;
            this.info_1.Location = new System.Drawing.Point(245, 88);
            this.info_1.Name = "info_1";
            this.info_1.Size = new System.Drawing.Size(396, 13);
            this.info_1.TabIndex = 9;
            this.info_1.Text = "prop:System.ItemTypeText;System.Size;System.DateModified;System.DateCreated";
            // 
            // NoDocs
            // 
            this.NoDocs.Location = new System.Drawing.Point(43, 109);
            this.NoDocs.Name = "NoDocs";
            this.NoDocs.Size = new System.Drawing.Size(99, 23);
            this.NoDocs.TabIndex = 10;
            this.NoDocs.Text = "NoRecentDocs";
            this.NoDocs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "REG_SZ";
            // 
            // EmptyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NoDocs);
            this.Controls.Add(this.info_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cnflct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unknwn);
            this.Controls.Add(this.RgSz);
            this.Controls.Add(this.Dflt_button);
            this.Controls.Add(this.ShowExt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmptyControl";
            this.Size = new System.Drawing.Size(717, 420);
            this.Load += new System.EventHandler(this.EmptyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Imya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button ShowExt;
        private System.Windows.Forms.Button Dflt_button;
        private System.Windows.Forms.Label RgSz;
        private System.Windows.Forms.Label Unknwn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cnflct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label info_1;
        private System.Windows.Forms.Button NoDocs;
        private System.Windows.Forms.Label label3;
    }
}
