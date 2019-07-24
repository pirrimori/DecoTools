namespace DecoTools_V2._0
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOtros = new System.Windows.Forms.Button();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.btnTutoriales = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnWiseplay = new System.Windows.Forms.Button();
            this.btnOpenwebif = new System.Windows.Forms.Button();
            this.btnIptv = new System.Windows.Forms.Button();
            this.btnCccam = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Controls.Add(this.panelBarraTitulo);
            this.panelPrincipal.Controls.Add(this.panelFormularios);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1280, 680);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnOtros);
            this.panelMenu.Controls.Add(this.btnAcercade);
            this.panelMenu.Controls.Add(this.btnTutoriales);
            this.panelMenu.Controls.Add(this.btnListas);
            this.panelMenu.Controls.Add(this.btnWiseplay);
            this.panelMenu.Controls.Add(this.btnOpenwebif);
            this.panelMenu.Controls.Add(this.btnIptv);
            this.panelMenu.Controls.Add(this.btnCccam);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 640);
            this.panelMenu.TabIndex = 1;
            // 
            // btnOtros
            // 
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtros.ForeColor = System.Drawing.Color.White;
            this.btnOtros.Location = new System.Drawing.Point(6, 272);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(244, 42);
            this.btnOtros.TabIndex = 9;
            this.btnOtros.Text = "Otros Decos";
            this.btnOtros.UseVisualStyleBackColor = true;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // btnAcercade
            // 
            this.btnAcercade.FlatAppearance.BorderSize = 0;
            this.btnAcercade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercade.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercade.ForeColor = System.Drawing.Color.White;
            this.btnAcercade.Location = new System.Drawing.Point(6, 356);
            this.btnAcercade.Name = "btnAcercade";
            this.btnAcercade.Size = new System.Drawing.Size(244, 42);
            this.btnAcercade.TabIndex = 8;
            this.btnAcercade.Text = "Acerca de";
            this.btnAcercade.UseVisualStyleBackColor = true;
            this.btnAcercade.Click += new System.EventHandler(this.btnAcercade_Click);
            // 
            // btnTutoriales
            // 
            this.btnTutoriales.FlatAppearance.BorderSize = 0;
            this.btnTutoriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnTutoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutoriales.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutoriales.ForeColor = System.Drawing.Color.White;
            this.btnTutoriales.Location = new System.Drawing.Point(6, 314);
            this.btnTutoriales.Name = "btnTutoriales";
            this.btnTutoriales.Size = new System.Drawing.Size(244, 42);
            this.btnTutoriales.TabIndex = 7;
            this.btnTutoriales.Text = "Tutoriales";
            this.btnTutoriales.UseVisualStyleBackColor = true;
            this.btnTutoriales.Click += new System.EventHandler(this.btnTutoriales_Click);
            // 
            // btnListas
            // 
            this.btnListas.Enabled = false;
            this.btnListas.FlatAppearance.BorderSize = 0;
            this.btnListas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListas.ForeColor = System.Drawing.Color.White;
            this.btnListas.Location = new System.Drawing.Point(3, 579);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(244, 42);
            this.btnListas.TabIndex = 6;
            this.btnListas.Text = "Listas txt";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Visible = false;
            // 
            // btnWiseplay
            // 
            this.btnWiseplay.FlatAppearance.BorderSize = 0;
            this.btnWiseplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnWiseplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiseplay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWiseplay.ForeColor = System.Drawing.Color.White;
            this.btnWiseplay.Location = new System.Drawing.Point(6, 230);
            this.btnWiseplay.Name = "btnWiseplay";
            this.btnWiseplay.Size = new System.Drawing.Size(244, 42);
            this.btnWiseplay.TabIndex = 5;
            this.btnWiseplay.Text = "Wiseplay";
            this.btnWiseplay.UseVisualStyleBackColor = true;
            this.btnWiseplay.Click += new System.EventHandler(this.btnWiseplay_Click);
            // 
            // btnOpenwebif
            // 
            this.btnOpenwebif.FlatAppearance.BorderSize = 0;
            this.btnOpenwebif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnOpenwebif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenwebif.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenwebif.ForeColor = System.Drawing.Color.White;
            this.btnOpenwebif.Location = new System.Drawing.Point(6, 188);
            this.btnOpenwebif.Name = "btnOpenwebif";
            this.btnOpenwebif.Size = new System.Drawing.Size(244, 42);
            this.btnOpenwebif.TabIndex = 4;
            this.btnOpenwebif.Text = "Listas M3u (webif)";
            this.btnOpenwebif.UseVisualStyleBackColor = true;
            this.btnOpenwebif.Click += new System.EventHandler(this.btnOpenwebif_Click);
            // 
            // btnIptv
            // 
            this.btnIptv.FlatAppearance.BorderSize = 0;
            this.btnIptv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnIptv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptv.ForeColor = System.Drawing.Color.White;
            this.btnIptv.Location = new System.Drawing.Point(6, 146);
            this.btnIptv.Name = "btnIptv";
            this.btnIptv.Size = new System.Drawing.Size(244, 42);
            this.btnIptv.TabIndex = 3;
            this.btnIptv.Text = "Iptv Enigma2";
            this.btnIptv.UseVisualStyleBackColor = true;
            this.btnIptv.Click += new System.EventHandler(this.btnIptv_Click);
            // 
            // btnCccam
            // 
            this.btnCccam.FlatAppearance.BorderSize = 0;
            this.btnCccam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCccam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCccam.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCccam.ForeColor = System.Drawing.Color.White;
            this.btnCccam.Location = new System.Drawing.Point(3, 98);
            this.btnCccam.Name = "btnCccam";
            this.btnCccam.Size = new System.Drawing.Size(244, 42);
            this.btnCccam.TabIndex = 0;
            this.btnCccam.Text = "Softcam E2";
            this.btnCccam.UseVisualStyleBackColor = true;
            this.btnCccam.Click += new System.EventHandler(this.btnCccam_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.lblHora);
            this.panelBarraTitulo.Controls.Add(this.lblFecha);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1280, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblHora.Location = new System.Drawing.Point(72, 1);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(95, 39);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(567, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 39);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1230, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1208, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1230, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1252, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1280, 680);
            this.panelFormularios.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelPrincipal.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAcercade;
        private System.Windows.Forms.Button btnTutoriales;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button btnWiseplay;
        private System.Windows.Forms.Button btnOpenwebif;
        private System.Windows.Forms.Button btnIptv;
        private System.Windows.Forms.Button btnCccam;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnOtros;
    }
}

