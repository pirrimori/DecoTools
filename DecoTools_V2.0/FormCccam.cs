using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tulpep.NotificationWindow;
using System.Diagnostics;

namespace DecoTools_V2._0
{
    public partial class FormCccam : Form
    {
        public FormCccam()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            while (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe comer una cline como mínimo.", "CCcam");
                return;
            }

            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su emuladora.", "CCcam");
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = DecoTools_V2._0.Program.nombreArchivo;
            //saveFileDialog1.ShowDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DecoTools_V2._0.Program.rutaArchivo = saveFileDialog1.FileName;
                File.WriteAllText(DecoTools_V2._0.Program.rutaArchivo, txbCccam.Text);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines para el protocolo CCcam están listas para usarse.", "CCcam");

            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "CCcam");
        }
    }
}
