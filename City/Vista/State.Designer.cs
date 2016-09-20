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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(State));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add.Location = new System.Drawing.Point(12, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(122, 104);
            this.add.TabIndex = 5;
            this.add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(125, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(277, 26);
            this.name.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.countryBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "IdCountry";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(Modelo.Country);
            // 
            // Pais
            // 
            this.Pais.AutoSize = true;
            this.Pais.Location = new System.Drawing.Point(60, 74);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 406);
            this.dataGridView1.TabIndex = 1;
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
            this.addWithCity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addWithCity.BackgroundImage")));
            this.addWithCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addWithCity.Location = new System.Drawing.Point(580, 12);
            this.addWithCity.Name = "addWithCity";
            this.addWithCity.Size = new System.Drawing.Size(119, 104);
            this.addWithCity.TabIndex = 6;
            this.addWithCity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addWithCity.UseVisualStyleBackColor = true;
            this.addWithCity.Click += new System.EventHandler(this.addWithCity_Click);
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(356, 47);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(79, 41);
            this.addCity.TabIndex = 2;
            this.addCity.Text = "+";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciudad";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(100, 54);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(249, 26);
            this.city.TabIndex = 1;
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
            this.dataGridView2.Size = new System.Drawing.Size(461, 406);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.Pais);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addCity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Location = new System.Drawing.Point(580, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 712);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.addWithCity);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}