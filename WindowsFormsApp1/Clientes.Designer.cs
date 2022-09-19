namespace WindowsFormsApp1
{
    partial class Clientes
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
            this.panel1_clientes = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.mini_clientes = new System.Windows.Forms.PictureBox();
            this.cerrar_clientes = new System.Windows.Forms.PictureBox();
            this.txtdni_clientes = new System.Windows.Forms.TextBox();
            this.txtnom_clientes = new System.Windows.Forms.TextBox();
            this.txttel_clientes = new System.Windows.Forms.TextBox();
            this.txtsex_clientes = new System.Windows.Forms.TextBox();
            this.txtcp_clientes = new System.Windows.Forms.TextBox();
            this.txtedad_clientes = new System.Windows.Forms.TextBox();
            this.comboBox_clientes = new System.Windows.Forms.ComboBox();
            this.comboBox1_clientes = new System.Windows.Forms.ComboBox();
            this.comboBox2_clientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscar_clientes = new System.Windows.Forms.Button();
            this.btnalta_clientes = new System.Windows.Forms.Button();
            this.btnmod_clientes = new System.Windows.Forms.Button();
            this.label11_clientes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBDDataSet = new WindowsFormsApp1.VentasBDDataSet();
            this.clientesTableAdapter = new WindowsFormsApp1.VentasBDDataSetTableAdapters.ClientesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_clientes
            // 
            this.panel1_clientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1_clientes.Controls.Add(this.label10);
            this.panel1_clientes.Controls.Add(this.mini_clientes);
            this.panel1_clientes.Controls.Add(this.cerrar_clientes);
            this.panel1_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_clientes.Location = new System.Drawing.Point(0, 0);
            this.panel1_clientes.Name = "panel1_clientes";
            this.panel1_clientes.Size = new System.Drawing.Size(1113, 38);
            this.panel1_clientes.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "Clientes";
            // 
            // mini_clientes
            // 
            this.mini_clientes.Image = global::WindowsFormsApp1.Properties.Resources.atras;
            this.mini_clientes.Location = new System.Drawing.Point(1029, 0);
            this.mini_clientes.Name = "mini_clientes";
            this.mini_clientes.Size = new System.Drawing.Size(44, 38);
            this.mini_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini_clientes.TabIndex = 2;
            this.mini_clientes.TabStop = false;
            // 
            // cerrar_clientes
            // 
            this.cerrar_clientes.Image = global::WindowsFormsApp1.Properties.Resources.cancelar__1_;
            this.cerrar_clientes.Location = new System.Drawing.Point(1070, 0);
            this.cerrar_clientes.Name = "cerrar_clientes";
            this.cerrar_clientes.Size = new System.Drawing.Size(41, 38);
            this.cerrar_clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_clientes.TabIndex = 1;
            this.cerrar_clientes.TabStop = false;
            // 
            // txtdni_clientes
            // 
            this.txtdni_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni_clientes.Location = new System.Drawing.Point(175, 97);
            this.txtdni_clientes.Name = "txtdni_clientes";
            this.txtdni_clientes.Size = new System.Drawing.Size(240, 24);
            this.txtdni_clientes.TabIndex = 1;
            // 
            // txtnom_clientes
            // 
            this.txtnom_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom_clientes.Location = new System.Drawing.Point(175, 161);
            this.txtnom_clientes.Name = "txtnom_clientes";
            this.txtnom_clientes.Size = new System.Drawing.Size(240, 24);
            this.txtnom_clientes.TabIndex = 2;
            this.txtnom_clientes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txttel_clientes
            // 
            this.txttel_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel_clientes.Location = new System.Drawing.Point(175, 225);
            this.txttel_clientes.Name = "txttel_clientes";
            this.txttel_clientes.Size = new System.Drawing.Size(240, 24);
            this.txttel_clientes.TabIndex = 3;
            // 
            // txtsex_clientes
            // 
            this.txtsex_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsex_clientes.Location = new System.Drawing.Point(627, 284);
            this.txtsex_clientes.Name = "txtsex_clientes";
            this.txtsex_clientes.Size = new System.Drawing.Size(240, 24);
            this.txtsex_clientes.TabIndex = 6;
            // 
            // txtcp_clientes
            // 
            this.txtcp_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcp_clientes.Location = new System.Drawing.Point(627, 222);
            this.txtcp_clientes.Name = "txtcp_clientes";
            this.txtcp_clientes.Size = new System.Drawing.Size(240, 24);
            this.txtcp_clientes.TabIndex = 7;
            // 
            // txtedad_clientes
            // 
            this.txtedad_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad_clientes.Location = new System.Drawing.Point(175, 284);
            this.txtedad_clientes.Name = "txtedad_clientes";
            this.txtedad_clientes.Size = new System.Drawing.Size(240, 24);
            this.txtedad_clientes.TabIndex = 9;
            // 
            // comboBox_clientes
            // 
            this.comboBox_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_clientes.FormattingEnabled = true;
            this.comboBox_clientes.Location = new System.Drawing.Point(175, 342);
            this.comboBox_clientes.Name = "comboBox_clientes";
            this.comboBox_clientes.Size = new System.Drawing.Size(240, 26);
            this.comboBox_clientes.TabIndex = 10;
            // 
            // comboBox1_clientes
            // 
            this.comboBox1_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_clientes.FormattingEnabled = true;
            this.comboBox1_clientes.Location = new System.Drawing.Point(627, 100);
            this.comboBox1_clientes.Name = "comboBox1_clientes";
            this.comboBox1_clientes.Size = new System.Drawing.Size(240, 26);
            this.comboBox1_clientes.TabIndex = 11;
            // 
            // comboBox2_clientes
            // 
            this.comboBox2_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2_clientes.FormattingEnabled = true;
            this.comboBox2_clientes.Location = new System.Drawing.Point(627, 158);
            this.comboBox2_clientes.Name = "comboBox2_clientes";
            this.comboBox2_clientes.Size = new System.Drawing.Size(240, 26);
            this.comboBox2_clientes.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "DNI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nacionalidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Provincia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Localidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(519, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Codigo Postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sexo:";
            // 
            // btnbuscar_clientes
            // 
            this.btnbuscar_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar_clientes.Location = new System.Drawing.Point(421, 97);
            this.btnbuscar_clientes.Name = "btnbuscar_clientes";
            this.btnbuscar_clientes.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar_clientes.TabIndex = 22;
            this.btnbuscar_clientes.Text = "Buscar";
            this.btnbuscar_clientes.UseVisualStyleBackColor = true;
            this.btnbuscar_clientes.Click += new System.EventHandler(this.btnbuscar_clientes_Click);
            // 
            // btnalta_clientes
            // 
            this.btnalta_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalta_clientes.Location = new System.Drawing.Point(175, 409);
            this.btnalta_clientes.Name = "btnalta_clientes";
            this.btnalta_clientes.Size = new System.Drawing.Size(240, 49);
            this.btnalta_clientes.TabIndex = 23;
            this.btnalta_clientes.Text = "Alta";
            this.btnalta_clientes.UseVisualStyleBackColor = true;
            this.btnalta_clientes.Click += new System.EventHandler(this.btnalta_clientes_Click);
            // 
            // btnmod_clientes
            // 
            this.btnmod_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod_clientes.Location = new System.Drawing.Point(456, 409);
            this.btnmod_clientes.Name = "btnmod_clientes";
            this.btnmod_clientes.Size = new System.Drawing.Size(240, 49);
            this.btnmod_clientes.TabIndex = 24;
            this.btnmod_clientes.Text = "Modificacion";
            this.btnmod_clientes.UseVisualStyleBackColor = true;
            this.btnmod_clientes.Click += new System.EventHandler(this.btnmod_clientes_Click);
            // 
            // label11_clientes
            // 
            this.label11_clientes.AutoSize = true;
            this.label11_clientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11_clientes.Location = new System.Drawing.Point(315, 39);
            this.label11_clientes.Name = "label11_clientes";
            this.label11_clientes.Size = new System.Drawing.Size(356, 31);
            this.label11_clientes.TabIndex = 23;
            this.label11_clientes.Text = "Registro de datos del cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(13, 522);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 179);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI Cliente";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            this.dNIDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.ventasBDDataSet;
            // 
            // ventasBDDataSet
            // 
            this.ventasBDDataSet.DataSetName = "VentasBDDataSet";
            this.ventasBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(738, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11_clientes);
            this.Controls.Add(this.btnmod_clientes);
            this.Controls.Add(this.btnalta_clientes);
            this.Controls.Add(this.btnbuscar_clientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2_clientes);
            this.Controls.Add(this.comboBox1_clientes);
            this.Controls.Add(this.comboBox_clientes);
            this.Controls.Add(this.txtedad_clientes);
            this.Controls.Add(this.txtcp_clientes);
            this.Controls.Add(this.txtsex_clientes);
            this.Controls.Add(this.txttel_clientes);
            this.Controls.Add(this.txtnom_clientes);
            this.Controls.Add(this.txtdni_clientes);
            this.Controls.Add(this.panel1_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1_clientes.ResumeLayout(false);
            this.panel1_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1_clientes;
        private System.Windows.Forms.PictureBox cerrar_clientes;
        private System.Windows.Forms.PictureBox mini_clientes;
        private System.Windows.Forms.TextBox txtdni_clientes;
        private System.Windows.Forms.TextBox txtnom_clientes;
        private System.Windows.Forms.TextBox txttel_clientes;
        private System.Windows.Forms.TextBox txtsex_clientes;
        private System.Windows.Forms.TextBox txtcp_clientes;
        private System.Windows.Forms.TextBox txtedad_clientes;
        private System.Windows.Forms.ComboBox comboBox_clientes;
        private System.Windows.Forms.ComboBox comboBox1_clientes;
        private System.Windows.Forms.ComboBox comboBox2_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnbuscar_clientes;
        private System.Windows.Forms.Button btnalta_clientes;
        private System.Windows.Forms.Button btnmod_clientes;
        private System.Windows.Forms.Label label11_clientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VentasBDDataSet ventasBDDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private VentasBDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}