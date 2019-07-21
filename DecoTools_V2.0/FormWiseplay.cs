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
using System.Reflection;

namespace DecoTools_V2._0
{
    public partial class FormWiseplay : Form
    {
        public FormWiseplay()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWiseplay_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "w3u files (*.w3u)|*.w3u";
            //openFileDialog1.ShowDialog();
            //string archivoOrigen = @openFileDialog1.FileName;
            //StreamReader read = new StreamReader(archivoOrigen);
            byte[] wiseplay = Properties.Resources.PLANTILLA_WISEPLAY;
            string archivoOrigen = System.Text.Encoding.UTF8.GetString(wiseplay);
            try
            {
                //string texto = File.ReadAllText(archivoOrigen);
                string wiseNombre = textBox1.Text;
                string wiseUno = textBox2.Text;
                string wiseDos = textBox3.Text;
                string wiseTres = textBox4.Text;
                archivoOrigen = archivoOrigen.Replace("autor_lista", wiseNombre);
                archivoOrigen = archivoOrigen.Replace("direccion1", wiseUno);
                archivoOrigen = archivoOrigen.Replace("direccion2", wiseDos);
                archivoOrigen = archivoOrigen.Replace("direccion3", wiseTres);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "w3u files (*.w3u)|*.w3u";
                saveFileDialog1.ShowDialog();
                try
                {
                    string archivoDestino = saveFileDialog1.FileName;
                    //StreamWriter writer = new StreamWriter(archivoDestino);
                    //writer.Close();
                    File.WriteAllText(archivoDestino, archivoOrigen);
                    not.PopupNotificacion(Properties.Resources.info, "Su archivo se ha guardado correctamente.", "Wiseplay");
                }
                catch
                {
                    not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Wiseplay");
                    return;
                }

                return;
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Wiseplay");
            return;
            }
        }
    }
}
