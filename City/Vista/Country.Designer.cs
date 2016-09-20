namespace Vista
{
    partial class Country
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Country));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCountryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.countryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(477, 464);
            this.dataGridView1.TabIndex = 7;
            // 
            // idCountryDataGridViewTextBoxColumn
            // 
            this.idCountryDataGridViewTextBoxColumn.DataPropertyName = "IdCountry";
            this.idCountryDataGridViewTextBoxColumn.HeaderText = "Id Pais";
            this.idCountryDataGridViewTextBoxColumn.Name = "idCountryDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(Modelo.Country);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(100, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(315, 26);
            this.name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit.BackgroundImage")));
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edit.Location = new System.Drawing.Point(292, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(120, 106);
            this.edit.TabIndex = 10;
            this.edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit.UseVisualStyleBackColor = false;
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Transparent;
            this.remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove.BackgroundImage")));
            this.remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remove.Location = new System.Drawing.Point(153, 12);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(120, 106);
            this.remove.TabIndex = 9;
            this.remove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add.Location = new System.Drawing.Point(16, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 106);
            this.add.TabIndex = 8;
            this.add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 738);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Country";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paises";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}