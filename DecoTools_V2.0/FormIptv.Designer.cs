namespace DecoTools_V2._0
{
    partial class FormIptv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIptv));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txbPuertoIptv = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbListaIptv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBufferActProg = new System.Windows.Forms.RadioButton();
            this.rbtnBufferAct = new System.Windows.Forms.RadioButton();
            this.rbtnBufferDes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            // 
            // txbPuertoIptv
            // 
            this.txbPuertoIptv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPuertoIptv.Location = new System.Drawing.Point(728, 331);
            this.txbPuertoIptv.Name = "txbPuertoIptv";
            this.txbPuertoIptv.Size = new System.Drawing.Size(117, 22);
            this.txbPuertoIptv.TabIndex = 47;
            this.txbPuertoIptv.Text = "4097";
            this.toolTip1.SetToolTip(this.txbPuertoIptv, "Si vas a usar buffer,deja este puerto por defecto para el reproductor de Enigma.\r" +
        "\nSi usas el puerto 5001 ó 5002 para otro reproductor,deja el buffer en desactiva" +
        "do.");
            this.txbPuertoIptv.TextChanged += new System.EventHandler(this.txbPuertoIptv_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1220, 52);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 44;
            this.btnCerrar.Text = "X";
            this.toolTip1.SetToolTip(this.btnCerrar, "Cierra Iptv");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(291, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(923, 110);
            this.label5.TabIndex = 52;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(291, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(640, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Convertir lista de iptv(m3u,m3u8) a bouquet para tu deco enigma2.";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(926, 367);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 32);
            this.btnAceptar.TabIndex = 50;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(725, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(725, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombre lista (bouquet)";
            // 
            // txbListaIptv
            // 
            this.txbListaIptv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbListaIptv.Location = new System.Drawing.Point(728, 250);
            this.txbListaIptv.MaxLength = 30000;
            this.txbListaIptv.Name = "txbListaIptv";
            this.txbListaIptv.Size = new System.Drawing.Size(230, 22);
            this.txbListaIptv.TabIndex = 46;
            this.txbListaIptv.Text = "ListaIPTV";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rbtnBufferActProg);
            this.groupBox1.Controls.Add(this.rbtnBufferAct);
            this.groupBox1.Controls.Add(this.rbtnBufferDes);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(295, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 195);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buffer";
            // 
            // rbtnBufferActProg
            // 
            this.rbtnBufferActProg.AutoSize = true;
            this.rbtnBufferActProg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBufferActProg.ForeColor = System.Drawing.Color.White;
            this.rbtnBufferActProg.Location = new System.Drawing.Point(7, 136);
            this.rbtnBufferActProg.Name = "rbtnBufferActProg";
            this.rbtnBufferActProg.Size = new System.Drawing.Size(355, 25);
            this.rbtnBufferActProg.TabIndex = 2;
            this.rbtnBufferActProg.Text = "Descarga progresiva y buffer activado";
            this.rbtnBufferActProg.UseVisualStyleBackColor = true;
            // 
            // rbtnBufferAct
            // 
            this.rbtnBufferAct.AutoSize = true;
            this.rbtnBufferAct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBufferAct.ForeColor = System.Drawing.Color.White;
            this.rbtnBufferAct.Location = new System.Drawing.Point(7, 88);
            this.rbtnBufferAct.Name = "rbtnBufferAct";
            this.rbtnBufferAct.Size = new System.Drawing.Size(162, 25);
            this.rbtnBufferAct.TabIndex = 1;
            this.rbtnBufferAct.Text = "Buffer activado";
            this.rbtnBufferAct.UseVisualStyleBackColor = true;
            // 
            // rbtnBufferDes
            // 
            this.rbtnBufferDes.AutoSize = true;
            this.rbtnBufferDes.Checked = true;
            this.rbtnBufferDes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBufferDes.ForeColor = System.Drawing.Color.White;
            this.rbtnBufferDes.Location = new System.Drawing.Point(7, 42);
            this.rbtnBufferDes.Name = "rbtnBufferDes";
            this.rbtnBufferDes.Size = new System.Drawing.Size(192, 25);
            this.rbtnBufferDes.TabIndex = 0;
            this.rbtnBufferDes.TabStop = true;
            this.rbtnBufferDes.Text = "Buffer desactivado";
            this.rbtnBufferDes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 34);
            this.label1.TabIndex = 43;
            this.label1.Text = "Iptv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormIptv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1262, 633);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPuertoIptv);
            this.Controls.Add(this.txbListaIptv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormIptv";
            this.Text = "FormIptv";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPuertoIptv;
        private System.Windows.Forms.TextBox txbListaIptv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBufferActProg;
        private System.Windows.Forms.RadioButton rbtnBufferAct;
        private System.Windows.Forms.RadioButton rbtnBufferDes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}