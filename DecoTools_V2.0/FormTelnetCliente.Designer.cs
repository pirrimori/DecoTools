namespace DecoTools_V2._0
{
    partial class FormTelnetCliente
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
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbxOutput
            // 
            this.tbxOutput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxOutput.Location = new System.Drawing.Point(227, 115);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(568, 398);
            this.tbxOutput.TabIndex = 61;
            this.toolTip1.SetToolTip(this.tbxOutput, "Ventana eventos de solo lectura.");
            // 
            // tbxInput
            // 
            this.tbxInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxInput.Location = new System.Drawing.Point(227, 64);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(568, 22);
            this.tbxInput.TabIndex = 59;
            this.toolTip1.SetToolTip(this.tbxInput, "Introduzca el comando a enviar y pulse intro.");
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // tbxIp
            // 
            this.tbxIp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxIp.Location = new System.Drawing.Point(295, 24);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(150, 22);
            this.tbxIp.TabIndex = 58;
            this.tbxIp.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Host:";
            // 
            // btnConnectar
            // 
            this.btnConnectar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnConnectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectar.FlatAppearance.BorderSize = 0;
            this.btnConnectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectar.ForeColor = System.Drawing.Color.White;
            this.btnConnectar.Location = new System.Drawing.Point(691, 20);
            this.btnConnectar.Name = "btnConnectar";
            this.btnConnectar.Size = new System.Drawing.Size(104, 33);
            this.btnConnectar.TabIndex = 56;
            this.btnConnectar.Text = "Conectar";
            this.btnConnectar.UseVisualStyleBackColor = false;
            this.btnConnectar.Click += new System.EventHandler(this.btnConnectar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(469, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Puerto:";
            // 
            // txbPort
            // 
            this.txbPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPort.Location = new System.Drawing.Point(549, 25);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(117, 22);
            this.txbPort.TabIndex = 54;
            this.txbPort.Text = "23";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(970, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 62;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // FormTelnetCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1012, 593);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.tbxIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPort);
            this.Name = "FormTelnetCliente";
            this.Text = "FormTelnetCliente";
            this.Load += new System.EventHandler(this.FormTelnetCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}