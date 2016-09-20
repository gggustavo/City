namespace Vista
{
    partial class City
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(City));
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.filterName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remove = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add.Location = new System.Drawing.Point(12, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 106);
            this.add.TabIndex = 3;
            this.add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(137, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(313, 26);
            this.name.TabIndex = 1;
            // 
            // state
            // 
            this.state.DataSource = this.stateBindingSource;
            this.state.DisplayMember = "Name";
            this.state.FormattingEnabled = true;
            this.state.Location = new System.Drawing.Point(137, 88);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(313, 28);
            this.state.TabIndex = 2;
            this.state.ValueMember = "IdState";
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(Modelo.State);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Provincia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCityDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(672, 482);
            this.dataGridView1.TabIndex = 5;
            // 
            // idCityDataGridViewTextBoxColumn
            // 
            this.idCityDataGridViewTextBoxColumn.DataPropertyName = "IdCity";
            this.idCityDataGridViewTextBoxColumn.HeaderText = "Id Ciudad";
            this.idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
            this.idCityDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(Modelo.City);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // filterName
            // 
            this.filterName.Location = new System.Drawing.Point(137, 40);
            this.filterName.Name = "filterName";
            this.filterName.Size = new System.Drawing.Size(313, 26);
            this.filterName.TabIndex = 0;
            this.filterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterName_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.state);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 133);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Transparent;
            this.remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove.BackgroundImage")));
            this.remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remove.Location = new System.Drawing.Point(149, 12);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(120, 106);
            this.remove.TabIndex = 6;
            this.remove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit.BackgroundImage")));
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edit.Location = new System.Drawing.Point(288, 12);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(120, 106);
            this.edit.TabIndex = 7;
            this.edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit.UseVisualStyleBackColor = false;
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 869);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "City";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;
    }
}