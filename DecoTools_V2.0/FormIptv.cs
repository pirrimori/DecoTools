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
    public partial class FormIptv : Form
    {
        public FormIptv()
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
            if (txbListaIptv.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "El campo Nombre de lista no puede estar vacío.", "IPTV Enigma");
                return;
            }

            if (txbPuertoIptv.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "El campo Puerto no puede estar vacío.", "IPTV Enigma");
                return;
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "m3u files (*.m3u)|*.m3u|m3u8 files (*.m3u8)|*.m3u8";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = @openFileDialog1.FileName;
                StreamReader read = new StreamReader(rutaArchivo);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "userbouquet." + txbListaIptv.Text + ".tv";
                saveFileDialog1.Filter = "tv files (*.tv)|*.tv";
                //saveFileDialog1.ShowDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string archivoDestino = saveFileDialog1.FileName;
                    StreamWriter writer = File.AppendText(archivoDestino);
                    //writer.Close();
                    //string linea = "linea";
                    string buffer = null;
                    if (rbtnBufferAct.Checked == true)
                        buffer = ":0:0:0:0:0:0:";
                    if (rbtnBufferDes.Checked == true)
                        buffer = ":0:0:0:0:0:1:";
                    if (rbtnBufferActProg.Checked == true)
                        buffer = ":0:0:0:0:0:3:";

                    string cadena2 = "null";
                    string cadena3 = "null";
                    int contador = 2;
                    int indice = 2;
                    string linea = read.ReadLine();

                    while (linea != null)
                    {

                        if (linea == null)
                        {
                            writer.Close();
                            read.Close();
                            not.PopupNotificacion(Properties.Resources.info, "Lista iptv para Enigma2 creada correctamente.", "IPTV Enigma");
                            return;
                        }
                        else if (linea.Contains("#EXTM3U"))
                        {
                            writer.WriteLine("#NAME " + txbListaIptv.Text);
                            linea = read.ReadLine();
                        }

                        else if (linea.Contains("#EXTINF"))
                        {
                            indice = linea.LastIndexOf(",") + 1;
                            int indice0 = linea.LastIndexOf("") + 1;
                            int caracteres = indice0 - indice;
                            cadena2 = linea.Substring(indice, caracteres);

                            cadena3 = "#DESCRIPTION " + cadena2.Trim();
                            linea = read.ReadLine();
                            //writer.WriteLine(cadena2 + "," + linea + Environment.NewLine);
                        }
                        else if (linea.Substring(0, 4) == "http")
                        {
                            string lineaMod = linea.Replace(":", "%3a");
                            writer.WriteLine("#SERVICE " + txbPuertoIptv.Text + ":0:1:" + contador + buffer +
                                lineaMod + ":" + cadena2.Trim() + Environment.NewLine + cadena3);
                            contador += 2;
                            linea = read.ReadLine();

                            //writer.WriteLine(linea);
                        }

                        else linea = read.ReadLine();
                        //else writer.WriteLine("URL:" + linea);

                    }

                    writer.Close();
                    read.Close();
                    not.PopupNotificacion(Properties.Resources.info, "Lista iptv para Enigma2 creada correctamente.", "IPTV Enigma");
                    return;

                }
                else
                    not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV Enigma");
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV Enigma");
        }

        private void txbPuertoIptv_TextChanged(object sender, EventArgs e)
        {
            if (txbPuertoIptv.Text == "4097")
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;
        }
    }
}
