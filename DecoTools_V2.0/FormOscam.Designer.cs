namespace DecoTools_V2._0
{
    partial class FormOscam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOscam));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txbOscam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txbCccam = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCccam = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "X";
            this.toolTip1.SetToolTip(this.btnCerrar, "Cierra Oscam");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txbOscam
            // 
            this.txbOscam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOscam.Location = new System.Drawing.Point(1083, 309);
            this.txbOscam.Multiline = true;
            this.txbOscam.Name = "txbOscam";
            this.txbOscam.Size = new System.Drawing.Size(167, 248);
            this.txbOscam.TabIndex = 32;
            this.txbOscam.Text = resources.GetString("txbOscam.Text");
            this.txbOscam.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "Oscam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // txbCccam
            // 
            this.txbCccam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCccam.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCccam.Location = new System.Drawing.Point(496, 309);
            this.txbCccam.Multiline = true;
            this.txbCccam.Name = "txbCccam";
            this.txbCccam.Size = new System.Drawing.Size(419, 156);
            this.txbCccam.TabIndex = 37;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(652, 500);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 32);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCccam
            // 
            this.lblCccam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCccam.AutoSize = true;
            this.lblCccam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.lblCccam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCccam.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCccam.ForeColor = System.Drawing.Color.White;
            this.lblCccam.Location = new System.Drawing.Point(409, 94);
            this.lblCccam.Name = "lblCccam";
            this.lblCccam.Size = new System.Drawing.Size(647, 154);
            this.lblCccam.TabIndex = 36;
            this.lblCccam.Text = resources.GetString("lblCccam.Text");
            // 
            // FormOscam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1262, 633);
            this.Controls.Add(this.txbCccam);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCccam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOscam);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormOscam";
            this.Text = "Oscam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txbOscam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txbCccam;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCccam;
    }
}