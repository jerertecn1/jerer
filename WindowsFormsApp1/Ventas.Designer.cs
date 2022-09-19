namespace WindowsFormsApp1
{
    partial class Ventas
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
            this.panel1_ventas = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.mini_ventas = new System.Windows.Forms.PictureBox();
            this.cerrar_ventas = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1_ventas = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3_ventas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcompro_ventas = new System.Windows.Forms.TextBox();
            this.dateTimePicker2_ventas = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcliente_ventas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdni_ventas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnrorefe_ventas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcod_ventas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcant_ventas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttot_ventas = new System.Windows.Forms.TextBox();
            this.panel1_ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_ventas
            // 
            this.panel1_ventas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1_ventas.Controls.Add(this.cerrar_ventas);
            this.panel1_ventas.Controls.Add(this.mini_ventas);
            this.panel1_ventas.Controls.Add(this.label10);
            this.panel1_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_ventas.Location = new System.Drawing.Point(0, 0);
            this.panel1_ventas.Name = "panel1_ventas";
            this.panel1_ventas.Size = new System.Drawing.Size(1247, 47);
            this.panel1_ventas.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 39);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ventas";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // mini_ventas
            // 
            this.mini_ventas.Image = global::WindowsFormsApp1.Properties.Resources.atras;
            this.mini_ventas.Location = new System.Drawing.Point(1134, 0);
            this.mini_ventas.Margin = new System.Windows.Forms.Padding(4);
            this.mini_ventas.Name = "mini_ventas";
            this.mini_ventas.Size = new System.Drawing.Size(59, 47);
            this.mini_ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini_ventas.TabIndex = 24;
            this.mini_ventas.TabStop = false;
            // 
            // cerrar_ventas
            // 
            this.cerrar_ventas.Image = global::WindowsFormsApp1.Properties.Resources.cancelar__1_;
            this.cerrar_ventas.Location = new System.Drawing.Point(1188, 0);
            this.cerrar_ventas.Margin = new System.Windows.Forms.Padding(4);
            this.cerrar_ventas.Name = "cerrar_ventas";
            this.cerrar_ventas.Size = new System.Drawing.Size(55, 47);
            this.cerrar_ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_ventas.TabIndex = 25;
            this.cerrar_ventas.TabStop = false;
            // 
            // dateTimePicker1_ventas
            // 
            this.dateTimePicker1_ventas.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1_ventas.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker1_ventas.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1_ventas.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1_ventas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_ventas.Location = new System.Drawing.Point(419, 212);
            this.dateTimePicker1_ventas.Name = "dateTimePicker1_ventas";
            this.dateTimePicker1_ventas.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker1_ventas.TabIndex = 1;
            // 
            // label3_ventas
            // 
            this.label3_ventas.AutoSize = true;
            this.label3_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_ventas.Location = new System.Drawing.Point(412, 61);
            this.label3_ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3_ventas.Name = "label3_ventas";
            this.label3_ventas.Size = new System.Drawing.Size(359, 39);
            this.label3_ventas.TabIndex = 16;
            this.label3_ventas.Text = "Comprobante de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Comprobante de pago de: ";
            // 
            // txtcompro_ventas
            // 
            this.txtcompro_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompro_ventas.Location = new System.Drawing.Point(394, 160);
            this.txtcompro_ventas.Name = "txtcompro_ventas";
            this.txtcompro_ventas.Size = new System.Drawing.Size(319, 28);
            this.txtcompro_ventas.TabIndex = 18;
            // 
            // dateTimePicker2_ventas
            // 
            this.dateTimePicker2_ventas.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker2_ventas.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker2_ventas.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker2_ventas.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker2_ventas.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2_ventas.Location = new System.Drawing.Point(588, 212);
            this.dateTimePicker2_ventas.Name = "dateTimePicker2_ventas";
            this.dateTimePicker2_ventas.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker2_ventas.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cliente:";
            // 
            // txtcliente_ventas
            // 
            this.txtcliente_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente_ventas.Location = new System.Drawing.Point(394, 259);
            this.txtcliente_ventas.Name = "txtcliente_ventas";
            this.txtcliente_ventas.Size = new System.Drawing.Size(319, 28);
            this.txtcliente_ventas.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nro Referencia:";
            // 
            // txtdni_ventas
            // 
            this.txtdni_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni_ventas.Location = new System.Drawing.Point(394, 338);
            this.txtdni_ventas.Name = "txtdni_ventas";
            this.txtdni_ventas.Size = new System.Drawing.Size(319, 28);
            this.txtdni_ventas.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "DNI:";
            // 
            // txtnrorefe_ventas
            // 
            this.txtnrorefe_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrorefe_ventas.Location = new System.Drawing.Point(394, 419);
            this.txtnrorefe_ventas.Name = "txtnrorefe_ventas";
            this.txtnrorefe_ventas.Size = new System.Drawing.Size(319, 28);
            this.txtnrorefe_ventas.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Codigo:";
            // 
            // txtcod_ventas
            // 
            this.txtcod_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_ventas.Location = new System.Drawing.Point(394, 497);
            this.txtcod_ventas.Name = "txtcod_ventas";
            this.txtcod_ventas.Size = new System.Drawing.Size(319, 28);
            this.txtcod_ventas.TabIndex = 27;
            this.txtcod_ventas.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 576);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad:";
            // 
            // txtcant_ventas
            // 
            this.txtcant_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcant_ventas.Location = new System.Drawing.Point(394, 576);
            this.txtcant_ventas.Name = "txtcant_ventas";
            this.txtcant_ventas.Size = new System.Drawing.Size(44, 28);
            this.txtcant_ventas.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 654);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total:";
            // 
            // txttot_ventas
            // 
            this.txttot_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot_ventas.Location = new System.Drawing.Point(124, 652);
            this.txttot_ventas.Name = "txttot_ventas";
            this.txttot_ventas.Size = new System.Drawing.Size(83, 28);
            this.txttot_ventas.TabIndex = 31;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1247, 703);
            this.Controls.Add(this.txttot_ventas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcant_ventas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcod_ventas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnrorefe_ventas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdni_ventas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcliente_ventas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2_ventas);
            this.Controls.Add(this.txtcompro_ventas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3_ventas);
            this.Controls.Add(this.dateTimePicker1_ventas);
            this.Controls.Add(this.panel1_ventas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1_ventas.ResumeLayout(false);
            this.panel1_ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1_ventas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox mini_ventas;
        private System.Windows.Forms.PictureBox cerrar_ventas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ventas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcompro_ventas;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_ventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcliente_ventas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdni_ventas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnrorefe_ventas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcod_ventas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcant_ventas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttot_ventas;
    }
}