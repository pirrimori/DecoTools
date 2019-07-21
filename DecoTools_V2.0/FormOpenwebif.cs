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

namespace DecoTools_V2._0
{
    public partial class FormOpenwebif : Form
    {
        public FormOpenwebif()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "m3u files (*.m3u)|*.m3u";
            //openFileDialog1.ShowDialog();
            //string archivoOrigen = @openFileDialog1.FileName;
            byte[] openwebif = Properties.Resources.Plantilla_Openwebif;
            string archivoOrigen = System.Text.Encoding.UTF8.GetString(openwebif);

            //StreamReader read = new StreamReader(archivoOrigen);
            //Añado todo el texto del archivo abierto en la variable texto
            try
            {
                //string texto = File.ReadAllText(archivoOrigen);
                //Meto en la variable openwebifIp el contenido del textbox
                string openwebifIp = textBox1.Text;
                //Reemplazo en la variable texto la palabra direccion1 por el contenido del textbox
                archivoOrigen = archivoOrigen.Replace("direccion1", openwebifIp);
                // Creo un nuevo objeto de la clase savefildialog para que me salga elegir ruta para guardar


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //Le doy las extensiones que quiero que tenga el archivo a guardar
                saveFileDialog1.Filter = "m3u files (*.m3u)|*.m3u";
                //Muestro el explorador de carpetas para que el usuario ponga el nombre del archivo a guardar
                saveFileDialog1.ShowDialog();
                //Guardo en una variable string la ruta del archivo guardado
                string archivoDestino = @saveFileDialog1.FileName;
                try { File.WriteAllText(archivoDestino, archivoOrigen);
                not.PopupNotificacion(Properties.Resources.info, "Su archivo se ha guardado correctamente.", "Ncam");
                }
                catch
                {
                    not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario", "Ncam");
                    return;
                }
                //cierro el formulario activo
                return;
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Openwebif");
                return;
            }

            //Creo un objeto de la clase streamwriter con la ruta del archivo guardado
            //StreamWriter writer = new StreamWriter(archivoDestino);
            //cierro el objeto writer para poder escribir en el 
            //writer.Close();
            //Escribo en el archivo guardado "archivoDestino" el contenido de texto
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
