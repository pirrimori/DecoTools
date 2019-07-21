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
    public partial class FormOscam : Form
    {

        public FormOscam()
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

            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Oscam");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su emuladora.", "Oscam");
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "oscam.server";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbOscam.Text);
                string texto = File.ReadAllText(ruta);
                string textoOrigen = texto;
                string auxiliar = Path.Combine(Application.StartupPath, "auxiliar.txt");
                File.WriteAllText(auxiliar, txbCccam.Text);
                int contador = 1;
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                byte[] serverOscam = null;
                serverOscam = Properties.Resources.oscam;
                string plantilla = System.Text.Encoding.UTF8.GetString(serverOscam);
                File.AppendAllText(rutaNueva, plantilla + Environment.NewLine + Environment.NewLine);

                while (cadena != null)
                {
                    cadena = reader.ReadLine();
                    if (cadena == null)
                    {
                        reader.Close();
                        File.Delete(ruta);
                        File.Delete(auxiliar);
                        not.PopupNotificacion(Properties.Resources.info, "Sus clines para el protocolo Oscam están listas para usarse.", "Oscam");
                        return;
                    }
                    try
                    {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Oscam");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Oscam");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        string host = clines[1];
                        string puerto = clines[2];
                        string user = clines[3];
                        string pass = clines[4];
                        texto = texto.Replace("LINEA", "LINEA" + contador);
                        //texto = texto.Replace("description=remote_cccam", "description=remote_cccam" + contador);
                        texto = texto.Replace("HOST,PUERTO", host + "," + puerto);
                        texto = texto.Replace("USUARIO", user);
                        texto = texto.Replace("CONTRASEÑA", pass);
                        contador++;
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "Oscam");
                    }
                    File.AppendAllText(rutaNueva, texto);
                    File.AppendAllText(rutaNueva, Environment.NewLine + Environment.NewLine);
                    texto = textoOrigen;
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines para el protocolo Oscam están listas para usarse.", "Oscam");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Oscam");
        }
    }
}
