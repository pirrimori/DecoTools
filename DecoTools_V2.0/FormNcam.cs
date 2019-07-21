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
using System.Threading;
using System.IO;

namespace DecoTools_V2._0
{
    public partial class FormNcam : Form
    {
        public FormNcam()
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
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Ncam");
                    return;
                }
                if (txbCccam.Lines.Length > 4)
                {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su emuladora.", "Ncam");
                }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "ncam.server";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbNcam1.Text);
                string texto = File.ReadAllText(ruta);
                string textoOrigen = texto;
                string auxiliar = Path.Combine(Application.StartupPath, "auxiliar.txt");
                File.WriteAllText(auxiliar, txbCccam.Text);
                int contador = 1;
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                File.AppendAllText(rutaNueva, "# ncam.server for NCAM" + Environment.NewLine + Environment.NewLine);

                while (cadena != null)
                {
                    cadena = reader.ReadLine();
                    if (cadena == null)
                    {
                        reader.Close();
                        File.Delete(ruta);
                        File.Delete(auxiliar);
                        not.PopupNotificacion(Properties.Resources.info, "Sus clines para el protocolo Ncam están listas para usarse.", "Ncam");
                        return;
                    }
                    try
                    {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Ncam");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Ncam");
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
                        texto = texto.Replace("label=remote_cccam", "label=remote_cccam" + contador);
                        texto = texto.Replace("description=remote_cccam", "description=remote_cccam" + contador);
                        texto = texto.Replace("host,puerto", host + "," + puerto);
                        texto = texto.Replace("user=user", "user=" + user);
                        texto = texto.Replace("password=pass", "password=" + pass);
                        contador++;
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "Ncam");
                    }
                    File.AppendAllText(rutaNueva, texto);
                    File.AppendAllText(rutaNueva, Environment.NewLine + Environment.NewLine);
                    texto = textoOrigen;
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines para el protocolo Ncam están listas para usarse.", "Ncam");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Ncam");
        }

        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Thread.Sleep(1000);
        //        executeCommand();
        //    }
        //}
        //static void executeCommand()
        //{
        //    System.Diagnostics.Process.Start("CMD.exe", "/K help");
        //}

        private void btnTelnet_Click(object sender, EventArgs e)
        {
            //<requestedExecutionLevel level="requireAdministrator" en manifest
            //System.Diagnostics.Process.Start("‪C:\Windows\System32\telnet.exe");
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/k " + "cd/");
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = false;
            // Now we create a process, assign its ProcessStartInfo and start it
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();

        }
    }
}
