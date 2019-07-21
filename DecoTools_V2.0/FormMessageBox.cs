using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoTools_V2._0
{
    public partial class FormMessageBox : Form
    {
        public FormMessageBox()
        {
            InitializeComponent();
           
        }
        //public enum MessageBoxButton
        //{
        //    Ok=0,Aceptar=1,Cancelar=2
        //};
        //public enum MessageBoxIcon
        //{
        //    Información=0,Advertencia=1,Error=2
        //};

        //public void show(string msg)
        //{
        //    lblTitulo.Text = "";
        //    txbMensaje.Text = "";
        //    txbMensaje.Text = msg;
        //    pictureBox1.Visible = false;
        //    btnAceptar.Visible = false;
        //    btnCancelar.Visible = false;
        //}
        //public void show(string msg,string titulo)
        //{
        //    lblTitulo.Text = "";
        //    txbMensaje.Text = "";
        //    txbMensaje.Text = msg;
        //    lblTitulo.Text = titulo;
        //    pictureBox1.Visible = false;
        //    btnAceptar.Visible = false;
        //    btnCancelar.Visible = false;
        //}
        //public void show(string msg,string titulo,MessageBoxButton button)
        //{
        //    lblTitulo.Text = "";
        //    txbMensaje.Text = "";
        //    txbMensaje.Text = msg;
        //    lblTitulo.Text = titulo;
        //    pictureBox1.Visible = false;
        //    if (MessageBoxButton.Ok == button)
        //    {
        //        btnOk.Visible = true;
        //        btnAceptar.Visible = false;
        //        btnCancelar.Visible = false;
        //    }
        //    else
        //    {
        //        btnOk.Visible = false;
        //        btnAceptar.Visible = true;
        //        btnCancelar.Visible = true;
        //    }
            
        //}
        //public void show(string msg,string titulo,MessageBoxButton button,MessageBoxIcon icon)
        //{
        //    lblTitulo.Text = "";
        //    txbMensaje.Text = "";
        //    txbMensaje.Text = msg;
        //    lblTitulo.Text = titulo;
        //    pictureBox1.Visible = true;
        //    if (MessageBoxButton.Ok == button)
        //    {
        //        btnOk.Visible = true;
        //        btnAceptar.Visible = false;
        //        btnCancelar.Visible = false;
        //    }
        //    else if (MessageBoxButton.Aceptar == button)
        //    {
        //        btnOk.Visible = false;
        //        btnAceptar.Visible = true;
        //        btnCancelar.Visible = true;
        //    }
        //    else if (MessageBoxButton.Cancelar == button)
        //    {
        //        btnOk.Visible = false;
        //        btnAceptar.Visible = true;
        //        btnCancelar.Visible = true;
        //    }

        //    if (MessageBoxIcon.Error == icon)
        //    {
        //        pictureBox1.Image = Image.FromFile(@"C:\Users\pirri\Desktop\RECURSOS GUI MODERN\ICONOS BLUE\user.png");
        //    }
        //    else if (MessageBoxIcon.Advertencia == icon)
        //    {
        //        pictureBox1.Image = Image.FromFile(@"C:\Users\pirri\Desktop\RECURSOS GUI MODERN\ICONOS BLUE\user.png");
        //    }
        //    else if (MessageBoxIcon.Información == icon)
        //    {
        //        pictureBox1.Image = Image.FromFile(@"C:\Users\pirri\Desktop\RECURSOS GUI MODERN\ICONOS BLUE\user.png");
        //    }
        //}


        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.OK;
        //}

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
