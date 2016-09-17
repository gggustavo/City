namespace Vista
{
    partial class State
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
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pais = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addWithCity = new System.Windows.Forms.Button();
            this.addCity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(30, 31);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(121, 105);
            this.add.TabIndex = 0;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(143, 177);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(277, 26);
            this.name.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.countryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "IdCountry";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(Modelo.Country);
            // 
            // Pais
            // 
            this.Pais.AutoSize = true;
            this.Pais.Location = new System.Drawing.Point(38, 234);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(39, 20);
            this.Pais.TabIndex = 4;
            this.Pais.Text = "Pais";
            this.Pais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(496, 406);
            this.dataGridView1.TabIndex = 5;
            // 
            // idStateDataGridViewTextBoxColumn
            // 
            this.idStateDataGridViewTextBoxColumn.DataPropertyName = "IdState";
            this.idStateDataGridViewTextBoxColumn.HeaderText = "Id Provincia";
            this.idStateDataGridViewTextBoxColumn.Name = "idStateDataGridViewTextBoxColumn";
            this.idStateDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(Modelo.State);
            // 
            // addWithCity
            // 
            this.addWithCity.Location = new System.Drawing.Point(580, 31);
            this.addWithCity.Name = "addWithCity";
            this.addWithCity.Size = new System.Drawing.Size(121, 105);
            this.addWithCity.TabIndex = 6;
            this.addWithCity.Text = "Agregar";
            this.addWithCity.UseVisualStyleBackColor = true;
            this.addWithCity.Click += new System.EventHandler(this.addWithCity_Click);
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(936, 167);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(79, 41);
            this.addCity.TabIndex = 7;
            this.addCity.Text = "+";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ciudad";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(664, 182);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(249, 26);
            this.city.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCityDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.cityBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(580, 280);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(435, 203);
            this.dataGridView2.TabIndex = 10;
            // 
            // idCityDataGridViewTextBoxColumn
            // 
            this.idCityDataGridViewTextBoxColumn.DataPropertyName = "IdCity";
            this.idCityDataGridViewTextBoxColumn.HeaderText = "Id Ciudad";
            this.idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
            this.idCityDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(Modelo.City);
            // 
            // State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 712);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.addWithCity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "State";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provinicas";
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.Label Pais;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addWithCity;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource cityBindingSource;
    }
}