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
            PopupNotifier popup = new PopupNotifier();
            popup.AnimationDuration = 500;
            //popup.Image = Properties.Resources.info;
            popup.TitleColor = System.Drawing.Color.FromArgb(255, 255, 255);
            popup.BodyColor = System.Drawing.Color.FromArgb(49, 66, 82);
            popup.BorderColor = System.Drawing.Color.FromArgb(4, 41, 68);
            popup.ContentColor = System.Drawing.Color.FromArgb(255, 255, 255);
            popup.TitleFont = new System.Drawing.Font("Tahoa", 20F);
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.ContentHoverColor = System.Drawing.Color.FromArgb(4, 41, 68);
            popup.ContentHoverColor = System.Drawing.Color.FromArgb(4, 41, 68);
            popup.TitleText = "Wiseplay info" + Environment.NewLine + Environment.NewLine;

                if (txbCccam.Text == "")
                {
                not.PopupNotificacion(Properties.Resources.error, "Debe comer una cline como mínimo.","Oscam");
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
                //string textoAuxiliar = File.ReadAllText(auxiliar);
                int contador = 1;
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                //string[] clines = cadena.Split(' ');
                //File.ReadLines(auxiliar);

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
                        texto = texto.Replace("label=MiCccam", "label=MiCccam" + contador);
                        texto = texto.Replace("description=MiCccam", "description=MiCccam" + contador);
                        texto = texto.Replace("host,puerto", host + "," + puerto);
                        texto = texto.Replace("user=user", "user=" + user);
                        texto = texto.Replace("password=pass", "password=" + pass);
                        contador++;
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "Oscam");

                    }
                    File.AppendAllText(rutaNueva, texto);
                    File.AppendAllText(rutaNueva, Environment.NewLine + Environment.NewLine);
                    texto = textoOrigen;

                    //}
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines para el protocolo Oscam están listas para usarse.", "Oscam");

            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Oscam");
        }
    }
}
