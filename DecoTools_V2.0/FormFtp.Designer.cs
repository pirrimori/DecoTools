namespace DecoTools_V2._0
{
    partial class FormFtp
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
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txbRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.panelTituloFtp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTituloFtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(42, 52);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(108, 19);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Direccion ip";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(164, 52);
            this.txbDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(290, 28);
            this.txbDireccion.TabIndex = 1;
            this.txbDireccion.Text = "192.168.0.100:2121";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(164, 88);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(290, 28);
            this.txbUsuario.TabIndex = 3;
            this.txbUsuario.Text = "root";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(42, 88);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(164, 124);
            this.txbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(290, 28);
            this.txbContraseña.TabIndex = 5;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(42, 124);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(103, 19);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Location = new System.Drawing.Point(333, 206);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(121, 35);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(473, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txbRuta
            // 
            this.txbRuta.Location = new System.Drawing.Point(164, 160);
            this.txbRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txbRuta.Name = "txbRuta";
            this.txbRuta.Size = new System.Drawing.Size(290, 28);
            this.txbRuta.TabIndex = 34;
            this.txbRuta.Text = "default";
            this.toolTip1.SetToolTip(this.txbRuta, "Si va a realizar la carga de alguna emuladora o configuración y conincide con la " +
        "ruta defaut, no modifique la ruta.");
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(42, 160);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(44, 19);
            this.lblRuta.TabIndex = 33;
            this.lblRuta.Text = "Ruta";
            // 
            // panelTituloFtp
            // 
            this.panelTituloFtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelTituloFtp.Controls.Add(this.btnCerrar);
            this.panelTituloFtp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloFtp.Location = new System.Drawing.Point(0, 0);
            this.panelTituloFtp.Name = "panelTituloFtp";
            this.panelTituloFtp.Size = new System.Drawing.Size(506, 32);
            this.panelTituloFtp.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "CCcam default: etc/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "oscam.server y oscam.conf default: etc/tuxbox/config\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "ncam.server y ncam.conf default: etc/tuxbox/config";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "gcam.server y gcam.conf default: etc/tuxbox/config";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // FormFtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(506, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTituloFtp);
            this.Controls.Add(this.txbRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ftp";
            this.panelTituloFtp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label lblContraseña;
        public System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txbRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Panel panelTituloFtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}