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
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDownloader = new System.Windows.Forms.Button();
            this.btnCmdTelnet = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.btnTutoriales = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnWiseplay = new System.Windows.Forms.Button();
            this.btnOpenwebif = new System.Windows.Forms.Button();
            this.btnIptv = new System.Windows.Forms.Button();
            this.btnNcam = new System.Windows.Forms.Button();
            this.btnOscam = new System.Windows.Forms.Button();
            this.btnCccam = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelFormularios.SuspendLayout();
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
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrincipal.Controls.Add(this.panelFormularios);
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Controls.Add(this.panelBarraTitulo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1280, 680);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.Controls.Add(this.lblHora);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(250, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1030, 640);
            this.panelFormularios.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.lblHora.Location = new System.Drawing.Point(868, 579);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(95, 40);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnDownloader);
            this.panelMenu.Controls.Add(this.btnCmdTelnet);
            this.panelMenu.Controls.Add(this.btnClient);
            this.panelMenu.Controls.Add(this.btnAcercade);
            this.panelMenu.Controls.Add(this.btnTutoriales);
            this.panelMenu.Controls.Add(this.btnListas);
            this.panelMenu.Controls.Add(this.btnWiseplay);
            this.panelMenu.Controls.Add(this.btnOpenwebif);
            this.panelMenu.Controls.Add(this.btnIptv);
            this.panelMenu.Controls.Add(this.btnNcam);
            this.panelMenu.Controls.Add(this.btnOscam);
            this.panelMenu.Controls.Add(this.btnCccam);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 640);
            this.panelMenu.TabIndex = 1;
            // 
            // btnDownloader
            // 
            this.btnDownloader.FlatAppearance.BorderSize = 0;
            this.btnDownloader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnDownloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloader.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloader.ForeColor = System.Drawing.Color.White;
            this.btnDownloader.Location = new System.Drawing.Point(3, 494);
            this.btnDownloader.Name = "btnDownloader";
            this.btnDownloader.Size = new System.Drawing.Size(244, 42);
            this.btnDownloader.TabIndex = 13;
            this.btnDownloader.Text = "Downloader";
            this.btnDownloader.UseVisualStyleBackColor = true;
            this.btnDownloader.Visible = false;
            this.btnDownloader.Click += new System.EventHandler(this.btnDownloader_Click);
            // 
            // btnCmdTelnet
            // 
            this.btnCmdTelnet.FlatAppearance.BorderSize = 0;
            this.btnCmdTelnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCmdTelnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmdTelnet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdTelnet.ForeColor = System.Drawing.Color.White;
            this.btnCmdTelnet.Location = new System.Drawing.Point(3, 450);
            this.btnCmdTelnet.Name = "btnCmdTelnet";
            this.btnCmdTelnet.Size = new System.Drawing.Size(244, 42);
            this.btnCmdTelnet.TabIndex = 12;
            this.btnCmdTelnet.Text = "Cmd Telnet";
            this.btnCmdTelnet.UseVisualStyleBackColor = true;
            this.btnCmdTelnet.Visible = false;
            this.btnCmdTelnet.Click += new System.EventHandler(this.btnFtp_Click);
            // 
            // btnClient
            // 
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(3, 538);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(244, 42);
            this.btnClient.TabIndex = 11;
            this.btnClient.Text = "Telnet";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Visible = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnAcercade
            // 
            this.btnAcercade.FlatAppearance.BorderSize = 0;
            this.btnAcercade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercade.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercade.ForeColor = System.Drawing.Color.White;
            this.btnAcercade.Location = new System.Drawing.Point(3, 406);
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
            this.btnTutoriales.Location = new System.Drawing.Point(3, 362);
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
            this.btnListas.Location = new System.Drawing.Point(3, 582);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(244, 42);
            this.btnListas.TabIndex = 6;
            this.btnListas.Text = "Listas txt";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Visible = false;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnWiseplay
            // 
            this.btnWiseplay.FlatAppearance.BorderSize = 0;
            this.btnWiseplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnWiseplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiseplay.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWiseplay.ForeColor = System.Drawing.Color.White;
            this.btnWiseplay.Location = new System.Drawing.Point(3, 318);
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
            this.btnOpenwebif.Location = new System.Drawing.Point(3, 274);
            this.btnOpenwebif.Name = "btnOpenwebif";
            this.btnOpenwebif.Size = new System.Drawing.Size(244, 42);
            this.btnOpenwebif.TabIndex = 4;
            this.btnOpenwebif.Text = "Openwebif";
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
            this.btnIptv.Location = new System.Drawing.Point(3, 230);
            this.btnIptv.Name = "btnIptv";
            this.btnIptv.Size = new System.Drawing.Size(244, 42);
            this.btnIptv.TabIndex = 3;
            this.btnIptv.Text = "Iptv";
            this.btnIptv.UseVisualStyleBackColor = true;
            this.btnIptv.Click += new System.EventHandler(this.btnIptv_Click);
            // 
            // btnNcam
            // 
            this.btnNcam.FlatAppearance.BorderSize = 0;
            this.btnNcam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnNcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNcam.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNcam.ForeColor = System.Drawing.Color.White;
            this.btnNcam.Location = new System.Drawing.Point(3, 186);
            this.btnNcam.Name = "btnNcam";
            this.btnNcam.Size = new System.Drawing.Size(244, 42);
            this.btnNcam.TabIndex = 2;
            this.btnNcam.Text = "Ncam";
            this.btnNcam.UseVisualStyleBackColor = true;
            this.btnNcam.Click += new System.EventHandler(this.btnNcam_Click);
            // 
            // btnOscam
            // 
            this.btnOscam.FlatAppearance.BorderSize = 0;
            this.btnOscam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnOscam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOscam.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOscam.ForeColor = System.Drawing.Color.White;
            this.btnOscam.Location = new System.Drawing.Point(3, 142);
            this.btnOscam.Name = "btnOscam";
            this.btnOscam.Size = new System.Drawing.Size(244, 42);
            this.btnOscam.TabIndex = 1;
            this.btnOscam.Text = "Oscam";
            this.btnOscam.UseVisualStyleBackColor = true;
            this.btnOscam.Click += new System.EventHandler(this.btnOscam_Click);
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
            this.btnCccam.Text = "Cccam";
            this.btnCccam.UseVisualStyleBackColor = true;
            this.btnCccam.Click += new System.EventHandler(this.btnCccam_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
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
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(567, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 40);
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
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
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
        private System.Windows.Forms.Button btnNcam;
        private System.Windows.Forms.Button btnOscam;
        private System.Windows.Forms.Button btnCccam;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnCmdTelnet;
        private System.Windows.Forms.Button btnDownloader;
    }
}

