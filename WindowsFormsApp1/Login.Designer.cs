namespace WindowsFormsApp1
{
    partial class Login
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
            this.panel1_login = new System.Windows.Forms.Panel();
            this.pictureBox1_login = new System.Windows.Forms.PictureBox();
            this.cerrar_login = new System.Windows.Forms.PictureBox();
            this.mini_login = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcontr = new System.Windows.Forms.TextBox();
            this.btningreso = new System.Windows.Forms.Button();
            this.linkLabel1_login = new System.Windows.Forms.LinkLabel();
            this.panel1_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_login
            // 
            this.panel1_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1_login.Controls.Add(this.pictureBox1_login);
            this.panel1_login.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1_login.Location = new System.Drawing.Point(0, 0);
            this.panel1_login.Name = "panel1_login";
            this.panel1_login.Size = new System.Drawing.Size(293, 273);
            this.panel1_login.TabIndex = 1;
            this.panel1_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1_login
            // 
            this.pictureBox1_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1_login.Image = global::WindowsFormsApp1.Properties.Resources.avatar;
            this.pictureBox1_login.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1_login.Name = "pictureBox1_login";
            this.pictureBox1_login.Size = new System.Drawing.Size(267, 249);
            this.pictureBox1_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_login.TabIndex = 0;
            this.pictureBox1_login.TabStop = false;
            // 
            // cerrar_login
            // 
            this.cerrar_login.Image = global::WindowsFormsApp1.Properties.Resources.cancelar__1_;
            this.cerrar_login.Location = new System.Drawing.Point(578, 0);
            this.cerrar_login.Name = "cerrar_login";
            this.cerrar_login.Size = new System.Drawing.Size(56, 50);
            this.cerrar_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar_login.TabIndex = 3;
            this.cerrar_login.TabStop = false;
            this.cerrar_login.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // mini_login
            // 
            this.mini_login.Image = global::WindowsFormsApp1.Properties.Resources.minimizar;
            this.mini_login.Location = new System.Drawing.Point(528, 0);
            this.mini_login.Name = "mini_login";
            this.mini_login.Size = new System.Drawing.Size(49, 50);
            this.mini_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini_login.TabIndex = 2;
            this.mini_login.TabStop = false;
            this.mini_login.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese su usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese su clave";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(303, 85);
            this.txtusu.MaxLength = 20;
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(169, 20);
            this.txtusu.TabIndex = 7;
            // 
            // txtcontr
            // 
            this.txtcontr.Location = new System.Drawing.Point(303, 152);
            this.txtcontr.MaxLength = 20;
            this.txtcontr.Name = "txtcontr";
            this.txtcontr.Size = new System.Drawing.Size(173, 20);
            this.txtcontr.TabIndex = 8;
            this.txtcontr.UseSystemPasswordChar = true;
            // 
            // btningreso
            // 
            this.btningreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btningreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btningreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningreso.Location = new System.Drawing.Point(323, 190);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(132, 31);
            this.btningreso.TabIndex = 9;
            this.btningreso.Text = "Ingresar";
            this.btningreso.UseVisualStyleBackColor = true;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // linkLabel1_login
            // 
            this.linkLabel1_login.AutoSize = true;
            this.linkLabel1_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1_login.Location = new System.Drawing.Point(308, 246);
            this.linkLabel1_login.Name = "linkLabel1_login";
            this.linkLabel1_login.Size = new System.Drawing.Size(164, 18);
            this.linkLabel1_login.TabIndex = 10;
            this.linkLabel1_login.TabStop = true;
            this.linkLabel1_login.Text = "¿Olvido su contraseña?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(633, 273);
            this.Controls.Add(this.linkLabel1_login);
            this.Controls.Add(this.btningreso);
            this.Controls.Add(this.txtcontr);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cerrar_login);
            this.Controls.Add(this.mini_login);
            this.Controls.Add(this.panel1_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_login;
        private System.Windows.Forms.Panel panel1_login;
        private System.Windows.Forms.PictureBox mini_login;
        private System.Windows.Forms.PictureBox cerrar_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtcontr;
        private System.Windows.Forms.Button btningreso;
        private System.Windows.Forms.LinkLabel linkLabel1_login;
    }
}