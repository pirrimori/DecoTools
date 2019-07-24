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
    public partial class FormMensajeAceptar : Form
    {
        public FormMensajeAceptar()
        {
            InitializeComponent();
        }

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AceptarPregunta();
            this.Close();
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

        public void CuadroPregunta(string msg, string titulo)
        {
            this.lblPregunta.Text = msg;
            this.lblTitulo.Text = titulo;
        }

        public bool AceptarPregunta()
        {
            return true;
        }
    }
}
