namespace WindowsFormsApp1
{
    partial class Productos
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
            this.panel1_prod = new System.Windows.Forms.Panel();
            this.mini_prod = new System.Windows.Forms.PictureBox();
            this.cerrar_prod = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcod_prod = new System.Windows.Forms.TextBox();
            this.txtnom_prod = new System.Windows.Forms.TextBox();
            this.txtcate_prod = new System.Windows.Forms.TextBox();
            this.txtprecio_prod = new System.Windows.Forms.TextBox();
            this.txtprov_prod = new System.Windows.Forms.TextBox();
            this.txtstock_prod = new System.Windows.Forms.TextBox();
            this.btnbuscar_prod = new System.Windows.Forms.Button();
            this.btnalta_prod = new System.Windows.Forms.Button();
            this.btnmod_prod = new System.Windows.Forms.Button();
            this.btnbaja_prod = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_prod
            // 
            this.panel1_prod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1_prod.Controls.Add(this.mini_prod);
            this.panel1_prod.Controls.Add(this.cerrar_prod);
            this.panel1_prod.Controls.Add(this.label7);
            this.panel1_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_prod.Location = new System.Drawing.Point(0, 0);
            this.panel1_prod.Name = "panel1_prod";
            this.panel1_prod.Size = new System.Drawing.Size(935, 38);
            this.panel1_prod.TabIndex = 0;
            // 
            // mini_prod
            // 
            this.mini_prod.Image = global::WindowsFormsApp1.Properties.Resources.atras;
            this.mini_prod.Location = new System.Drawing.Point(856, 0);
            this.mini_prod.Name = "mini_prod";
            this.mini_prod.Size = new System.Drawing.Size(41, 38);
            this.mini_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini_prod.TabIndex = 19;
            this.mini_prod.TabStop = false;
            // 
            // cerrar_prod
            // 
            this.cerrar_prod.Image = global::WindowsFormsApp1.Properties.Resources.cancelar__1_;
            this.cerrar_prod.Location = new System.Drawing.Point(894, 0);
            this.cerrar_prod.Name = "cerrar_prod";
            this.cerrar_prod.Size = new System.Drawing.Size(41, 38);
            this.cerrar_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_prod.TabIndex = 18;
            this.cerrar_prod.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre:";
            // 
            // txtcod_prod
            // 
            this.txtcod_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_prod.Location = new System.Drawing.Point(225, 89);
            this.txtcod_prod.Name = "txtcod_prod";
            this.txtcod_prod.Size = new System.Drawing.Size(240, 24);
            this.txtcod_prod.TabIndex = 7;
            // 
            // txtnom_prod
            // 
            this.txtnom_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom_prod.Location = new System.Drawing.Point(225, 180);
            this.txtnom_prod.Name = "txtnom_prod";
            this.txtnom_prod.Size = new System.Drawing.Size(240, 24);
            this.txtnom_prod.TabIndex = 8;
            // 
            // txtcate_prod
            // 
            this.txtcate_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcate_prod.Location = new System.Drawing.Point(225, 274);
            this.txtcate_prod.Name = "txtcate_prod";
            this.txtcate_prod.Size = new System.Drawing.Size(240, 24);
            this.txtcate_prod.TabIndex = 9;
            // 
            // txtprecio_prod
            // 
            this.txtprecio_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio_prod.Location = new System.Drawing.Point(672, 84);
            this.txtprecio_prod.Name = "txtprecio_prod";
            this.txtprecio_prod.Size = new System.Drawing.Size(240, 24);
            this.txtprecio_prod.TabIndex = 10;
            // 
            // txtprov_prod
            // 
            this.txtprov_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprov_prod.Location = new System.Drawing.Point(672, 181);
            this.txtprov_prod.Name = "txtprov_prod";
            this.txtprov_prod.Size = new System.Drawing.Size(240, 24);
            this.txtprov_prod.TabIndex = 11;
            // 
            // txtstock_prod
            // 
            this.txtstock_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstock_prod.Location = new System.Drawing.Point(672, 274);
            this.txtstock_prod.Name = "txtstock_prod";
            this.txtstock_prod.Size = new System.Drawing.Size(240, 24);
            this.txtstock_prod.TabIndex = 12;
            this.txtstock_prod.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnbuscar_prod
            // 
            this.btnbuscar_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar_prod.Location = new System.Drawing.Point(470, 89);
            this.btnbuscar_prod.Name = "btnbuscar_prod";
            this.btnbuscar_prod.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar_prod.TabIndex = 13;
            this.btnbuscar_prod.Text = "Buscar";
            this.btnbuscar_prod.UseVisualStyleBackColor = true;
            this.btnbuscar_prod.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnalta_prod
            // 
            this.btnalta_prod.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnalta_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalta_prod.Location = new System.Drawing.Point(95, 382);
            this.btnalta_prod.Name = "btnalta_prod";
            this.btnalta_prod.Size = new System.Drawing.Size(187, 39);
            this.btnalta_prod.TabIndex = 14;
            this.btnalta_prod.Text = "Alta";
            this.btnalta_prod.UseVisualStyleBackColor = true;
            this.btnalta_prod.Click += new System.EventHandler(this.btnalta_prod_Click);
            // 
            // btnmod_prod
            // 
            this.btnmod_prod.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnmod_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod_prod.Location = new System.Drawing.Point(388, 382);
            this.btnmod_prod.Name = "btnmod_prod";
            this.btnmod_prod.Size = new System.Drawing.Size(187, 39);
            this.btnmod_prod.TabIndex = 15;
            this.btnmod_prod.Text = "Modificacion";
            this.btnmod_prod.UseVisualStyleBackColor = true;
            // 
            // btnbaja_prod
            // 
            this.btnbaja_prod.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnbaja_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaja_prod.Location = new System.Drawing.Point(672, 382);
            this.btnbaja_prod.Name = "btnbaja_prod";
            this.btnbaja_prod.Size = new System.Drawing.Size(187, 39);
            this.btnbaja_prod.TabIndex = 16;
            this.btnbaja_prod.Text = "Baja";
            this.btnbaja_prod.UseVisualStyleBackColor = true;
            this.btnbaja_prod.Click += new System.EventHandler(this.btnbaja_prod_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(435, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 20;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(935, 571);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnbaja_prod);
            this.Controls.Add(this.btnmod_prod);
            this.Controls.Add(this.btnalta_prod);
            this.Controls.Add(this.btnbuscar_prod);
            this.Controls.Add(this.txtstock_prod);
            this.Controls.Add(this.txtprov_prod);
            this.Controls.Add(this.txtprecio_prod);
            this.Controls.Add(this.txtcate_prod);
            this.Controls.Add(this.txtnom_prod);
            this.Controls.Add(this.txtcod_prod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1_prod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1_prod.ResumeLayout(false);
            this.panel1_prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1_prod;
        private System.Windows.Forms.PictureBox mini_prod;
        private System.Windows.Forms.PictureBox cerrar_prod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcod_prod;
        private System.Windows.Forms.TextBox txtnom_prod;
        private System.Windows.Forms.TextBox txtcate_prod;
        private System.Windows.Forms.TextBox txtprecio_prod;
        private System.Windows.Forms.TextBox txtprov_prod;
        private System.Windows.Forms.TextBox txtstock_prod;
        private System.Windows.Forms.Button btnbuscar_prod;
        private System.Windows.Forms.Button btnalta_prod;
        private System.Windows.Forms.Button btnmod_prod;
        private System.Windows.Forms.Button btnbaja_prod;
        private System.Windows.Forms.Label label9;
    }
}