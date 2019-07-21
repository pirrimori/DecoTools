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
    public partial class FormOtros : Form
    {
        public FormOtros()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region IPTV OTROS DECOS
        private void btnEngel_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "m3u files (*.m3u)|*.m3u";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoOrigen = @openFileDialog1.FileName;
                StreamReader read = new StreamReader(archivoOrigen);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "IptvEngel.ini";
                saveFileDialog1.Filter = "ini files (*.ini)|*.ini";
                //saveFileDialog1.ShowDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string archivoDestino = saveFileDialog1.FileName;
                    StreamWriter writer = File.AppendText(archivoDestino);
                    //writer.Close();
                    string linea = "linea";
                    int indice1 = 2;
                    while (linea != null)
                    {
                        linea = read.ReadLine();
                        if (linea == null)
                        {
                            writer.Close();
                            read.Close();
                            not.PopupNotificacion(Properties.Resources.info, "Lista iptv para Engel creada correctamente.", "IPTV Engel");
                            return;
                        }
                        if (linea.Contains("#EXTM3U"))
                        {
                            linea = read.ReadLine();
                        }

                        if (linea.Contains(","))
                        {
                            indice1 = linea.LastIndexOf(",") + 1;
                            int indice2 = linea.LastIndexOf("") + 1;
                            int caracteres = indice2 - indice1;
                            string cadena2 = linea.Substring(indice1, caracteres);

                            cadena2 = linea.Substring(indice1, caracteres);
                            linea = read.ReadLine();
                            writer.WriteLine(cadena2 + "," + linea + Environment.NewLine);
                        }

                        else writer.WriteLine(linea);

                    }

                    writer.Close();
                    read.Close();
                    not.PopupNotificacion(Properties.Resources.info, "Lista iptv para Engel creada correctamente.", "IPTV Engel");
                }
                else
                    not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV Engel");
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV Engel");
        }

        private void btnGTMedia_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "m3u files (*.m3u)|*.m3u";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoOrigen = @openFileDialog1.FileName;
                StreamReader read = new StreamReader(archivoOrigen);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "Iptvlist.txt";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                //saveFileDialog1.ShowDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string archivoDestino = saveFileDialog1.FileName;
                    StreamWriter writer = File.AppendText(archivoDestino);
                    //writer.Close();
                    string linea = "linea";
                    int indice1 = 2;
                    while (linea != null)
                    {
                        linea = read.ReadLine();
                        if (linea == null)
                        {
                            writer.Close();
                            read.Close();
                            not.PopupNotificacion(Properties.Resources.info, "Lista iptv para GTMedia creada correctamente.", "IPTV GTMedia");
                            return;
                        }
                        if (linea.Contains("#EXTM3U"))
                        {
                            linea = read.ReadLine();
                        }

                        if (linea.Contains(","))
                        {
                            indice1 = linea.LastIndexOf(",") + 1;
                            int indice2 = linea.LastIndexOf("") + 1;
                            int caracteres = indice2 - indice1;
                            string cadena2 = linea.Substring(indice1, caracteres);

                            cadena2 = linea.Substring(indice1, caracteres);
                            linea = read.ReadLine();
                            writer.WriteLine(cadena2 + "," + linea + Environment.NewLine);
                        }

                        else writer.WriteLine(linea);

                    }

                    writer.Close();
                    read.Close();
                    not.PopupNotificacion(Properties.Resources.info, "Lista iptv para GTMedia creada correctamente.", "IPTV GTMedia");

                }
                else
                    not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV GTMedia");
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV GTMedia");
        }

        private void btnIris_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "m3u files (*.m3u)|*.m3u";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoOrigen = @openFileDialog1.FileName;
                StreamReader read = new StreamReader(archivoOrigen);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "tvlist.txt";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                //saveFileDialog1.ShowDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string archivoDestino = saveFileDialog1.FileName;
                    StreamWriter writer = File.AppendText(archivoDestino);
                    //writer.Close();
                    string linea = "linea";
                    string cadena2 = "null";
                    int indice1 = 2;
                    int indice2 = 2;
                    int caracteres = 1;
                    while (linea != null)
                    {
                        linea = read.ReadLine();
                        if (linea == null)
                        {
                            writer.Close();
                            read.Close();
                            not.PopupNotificacion(Properties.Resources.info, "Lista iptv para Iris creada correctamente.", "IPTV Iris");
                            return;
                        }
                        if (linea.Contains("#EXTM3U"))
                        {
                            linea = read.ReadLine();
                        }
                        if (linea.Contains(","))
                        {
                            indice1 = linea.LastIndexOf("-") + 1;
                            indice2 = linea.LastIndexOf("") + 1;
                            caracteres = indice2 - indice1;
                            cadena2 = linea.Substring(indice1, caracteres);
                            //if(cadena2.Substring(0,1)== " ")
                            //{
                            //    cadena2 = cadena2.Substring(0, 1).Replace(" ", "");
                            //}
                            cadena2 = cadena2.Replace(" ", "_");
                            linea = read.ReadLine();
                            writer.WriteLine(cadena2 + "," + linea + Environment.NewLine);
                        }

                        else writer.WriteLine(linea);

                    }

                    writer.Close();
                    read.Close();
                    not.PopupNotificacion(Properties.Resources.info, "Lista iptv para Iris creada correctamente.", "IPTV Iris");
                }
                else
                    not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV Iris");
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV Iris");
        }

        private void btnGigaTv_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "m3u files (*.m3u)|*.m3u";
            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoOrigen = @openFileDialog1.FileName;
                StreamReader read = new StreamReader(archivoOrigen);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "tvlist.txt";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                //saveFileDialog1.ShowDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string archivoDestino = saveFileDialog1.FileName;
                    StreamWriter writer = File.AppendText(archivoDestino);
                    //writer.Close();
                    string linea = "linea";
                    string cadena2 = "null";
                    int indice1 = 2;
                    int indice2 = 2;
                    int caracteres = 1;
                    while (linea != null)
                    {
                        linea = read.ReadLine();
                        if (linea == null)
                        {
                            writer.Close();
                            read.Close();
                            not.PopupNotificacion(Properties.Resources.info, "Lista iptv para GigaTV creada correctamente.", "IPTV GigaTV");
                            return;
                        }
                        if (linea.Contains("#EXTM3U"))
                        {
                            linea = read.ReadLine();
                        }
                        if (linea.Contains(","))
                        {
                            indice1 = linea.LastIndexOf("-") + 1;
                            indice2 = linea.LastIndexOf("") + 1;
                            caracteres = indice2 - indice1;
                            cadena2 = linea.Substring(indice1, caracteres);
                            //if(cadena2.Substring(0,1)== " ")
                            //{
                            //    cadena2 = cadena2.Substring(0, 1).Replace(" ", "");
                            //}
                            cadena2 = cadena2.Replace(" ", "_");
                            linea = read.ReadLine();
                            writer.WriteLine(cadena2 + " " + linea + Environment.NewLine);
                        }

                        else writer.WriteLine(linea);

                    }

                    writer.Close();
                    read.Close();
                    not.PopupNotificacion(Properties.Resources.info, "Lista iptv para GigaTV creada correctamente.", "IPTV GigaTV");
                }
                else
                    not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV GigaTV");
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "IPTV GigaTV");
        }
        #endregion
        #region Engel Cccam
        private void btnCccamEngel_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == true) panelIris.Visible = false;
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Engel");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "Engel");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "CCcam.cfg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbCccam.Text);
                string cadena = "C: PUERTO HOST USUARIO CONTRASEÑA";
                StreamReader reader = new StreamReader(ruta);
                while (cadena != null)
                {
                    string[] clines = cadena.Split(' ');
                    string valor0 = clines[0];
                    if (clines.Length < 5)
                    {
                        not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Engel");
                        reader.Close();
                        File.Delete(ruta);
                        reader.Close();
                        File.Delete(rutaNueva);
                        return;
                    }
                    if (valor0 != "C:" & valor0 != "c:")
                    {
                        not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Engel");
                        File.Delete(ruta);
                        reader.Close();
                        File.Delete(rutaNueva);
                        return;
                    }
                    cadena = reader.ReadLine();
                }
                string texto = File.ReadAllText(ruta);
                File.WriteAllText(rutaNueva, texto);
                reader.Close();
                File.Delete(ruta);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Engel");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Engel");
        }
        #endregion
        #region GigaTV Cccam
        private void btnCccamGigaTV_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == true) panelIris.Visible = false;
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "GigaTV");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "GigaTV");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "cccam_accounts.txt";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbIris9900.Text);
                string texto = File.ReadAllText(ruta);
                string textoOrigen = texto;
                string auxiliar = Path.Combine(Application.StartupPath, "auxiliar.txt");
                File.WriteAllText(auxiliar, txbCccam.Text);
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                //File.AppendAllText(rutaNueva, "cfg~0~0~00000000" + Environment.NewLine + Environment.NewLine);

                while (cadena != null)
                {
                    cadena = reader.ReadLine();
                    if (cadena == null)
                    {
                        reader.Close();
                        File.Delete(ruta);
                        File.Delete(auxiliar);
                        not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "GigaTV");
                        return;
                    }
                    try
                    {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "GigaTV");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "GigaTV");
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
                        //texto = texto.Replace("description=remote_cccam", "description=remote_cccam" + contador);
                        texto = texto.Replace("PUERTO", puerto);
                        texto = texto.Replace("HOST", host);
                        texto = texto.Replace("USUARIO", user);
                        texto = texto.Replace("CONTRASEÑA", pass);
                        texto = texto.Replace(" ", ",");
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "GigaTV");
                    }
                    File.AppendAllText(rutaNueva, texto);
                    texto = textoOrigen;
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "GigaTV");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "GigaTV");

        }
        #endregion
        #region GTMedia Cccam
        private void btnCccamGTMedia_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == true) panelIris.Visible = false;
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Freesat-GTMedia");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "Freesat-GTMedia");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "CCcam.cfg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbCccam.Text);
                string cadena = "C: PUERTO HOST USUARIO CONTRASEÑA";
                StreamReader reader = new StreamReader(ruta);
                while (cadena != null)
                {
                    string[] clines = cadena.Split(' ');
                    string valor0 = clines[0];
                    if (clines.Length < 5)
                    {
                        not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Freesat-GTMedia");
                        reader.Close();
                        File.Delete(ruta);
                        reader.Close();
                        File.Delete(rutaNueva);
                        return;
                    }
                    if (valor0 != "C:" & valor0 != "c:")
                    {
                        not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Freesat-GTMedia");
                        File.Delete(ruta);
                        reader.Close();
                        File.Delete(rutaNueva);
                        return;
                    }
                    cadena = reader.ReadLine();
                }
                string texto = File.ReadAllText(ruta);
                File.WriteAllText(rutaNueva, texto);
                reader.Close();
                File.Delete(ruta);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Freesat-GTMedia");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Freesat-GTMedia");
        }
        #endregion
        #region Iris Cccam
        private void btnCccamIris_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == false) panelIris.Visible = true;
            else panelIris.Visible = false;
        }

        private void btnIris2600_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == true) panelIris.Visible = false;
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Iris 2600 HD/2700 HD");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "Iris 2600 HD/2700 HD");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "cccam_2600.txt";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbIris9900.Text);
                string texto = File.ReadAllText(ruta);
                string textoOrigen = texto;
                string auxiliar = Path.Combine(Application.StartupPath, "auxiliar.txt");
                File.WriteAllText(auxiliar, txbCccam.Text);
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                //File.AppendAllText(rutaNueva, "cfg~0~0~00000000" + Environment.NewLine + Environment.NewLine);

                while (cadena != null)
                {
                    cadena = reader.ReadLine();
                    if (cadena == null)
                    {
                        reader.Close();
                        File.Delete(ruta);
                        File.Delete(auxiliar);
                        not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Iris 2600 HD/2700 HD");
                        return;
                    }
                    try
                    {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Iris 2600 HD/2700 HD");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Iris 2600 HD/2700 HD");
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
                        //texto = texto.Replace("description=remote_cccam", "description=remote_cccam" + contador);
                        texto = texto.Replace("PUERTO", puerto);
                        texto = texto.Replace("HOST", host);
                        texto = texto.Replace("USUARIO", user);
                        texto = texto.Replace("CONTRASEÑA", pass);
                        texto = texto.Replace(" ", ",");
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "Iris 2600 HD/2700 HD");
                    }
                    File.AppendAllText(rutaNueva, texto);
                    texto = textoOrigen;
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Iris 2600 HD/2700 HD");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Iris 2600 HD/2700 HD");
        }

        private void btnIris9700_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Iris 9700 HD");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "Iris 9700 HD");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "CCcam.cfg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbCccam.Text);
                string cadena = "C: PUERTO HOST USUARIO CONTRASEÑA";
                StreamReader reader = new StreamReader(ruta);
                while (cadena != null)
                {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Iris 9700 HD");
                            reader.Close();
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Iris 9700 HD");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(rutaNueva);
                            return;
                        }
                    cadena = reader.ReadLine();
                }
                string texto = File.ReadAllText(ruta);
                string prefijo = "<NETDBS_TXT_VER_1>" + Environment.NewLine + Environment.NewLine;
                string sufijo = "}{ 2}";
                texto = texto.Replace("C: ", "CCCAM:{");
                texto = texto.Replace("c: ", "CCCAM:{");
                texto = texto.Replace(" ", "}{");
                texto = texto.Replace("\r\n", "}{ 2}" + Environment.NewLine);
                File.WriteAllText(rutaNueva, prefijo + texto + sufijo);
                reader.Close();
                File.Delete(ruta);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Iris 9700 HD");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Iris 9700 HD");
        }

        private void btnIris9900_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == true) panelIris.Visible = false;
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Iris 9900/02/03 HD");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "Iris 9900/02/03 HD");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "cccam_9900.txt";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbIris9900.Text);
                string texto = File.ReadAllText(ruta);
                string textoOrigen = texto;
                string auxiliar = Path.Combine(Application.StartupPath, "auxiliar.txt");
                File.WriteAllText(auxiliar, txbCccam.Text);
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                //File.AppendAllText(rutaNueva, "cfg~0~0~00000000" + Environment.NewLine + Environment.NewLine);

                while (cadena != null)
                {
                    cadena = reader.ReadLine();
                    if (cadena == null)
                    {
                        reader.Close();
                        File.Delete(ruta);
                        File.Delete(auxiliar);
                        not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Iris 9900/02/03 HD");
                        return;
                    }
                    try
                    {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Iris 9900/02/03 HD");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Iris 9900/02/03 HD");
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
                        //texto = texto.Replace("description=remote_cccam", "description=remote_cccam" + contador);
                        texto = texto.Replace("PUERTO", puerto);
                        texto = texto.Replace("HOST", host);
                        texto = texto.Replace("USUARIO", user);
                        texto = texto.Replace("CONTRASEÑA", pass);
                        texto = texto.Replace(" ", ",");
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "Iris 9900/02/03 HD");
                    }
                    File.AppendAllText(rutaNueva, texto);
                    texto = textoOrigen;
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Iris 9900/02/03 HD");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Iris 9900/02/03 HD");
        }
        #endregion
        #region Edison Cccam
        private void btnCccamEdison_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == true) panelIris.Visible = false;
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Edison");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "Edison");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "hsdata.cfg";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbAmiko.Text);
                string texto = File.ReadAllText(ruta);
                string textoOrigen = texto;
                string auxiliar = Path.Combine(Application.StartupPath, "auxiliar.txt");
                File.WriteAllText(auxiliar, txbCccam.Text);
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                File.AppendAllText(rutaNueva, "cfg~0~0~00000000" + Environment.NewLine + Environment.NewLine);

                while (cadena != null)
                {
                    cadena = reader.ReadLine();
                    if (cadena == null)
                    {
                        reader.Close();
                        File.Delete(ruta);
                        File.Delete(auxiliar);
                        not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Edison");
                        return;
                    }
                    try
                    {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Edison");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Edison");
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
                        //texto = texto.Replace("description=remote_cccam", "description=remote_cccam" + contador);
                        texto = texto.Replace("PUERTO", puerto);
                        texto = texto.Replace("HOST", host);
                        texto = texto.Replace("USUARIO", user);
                        texto = texto.Replace("CONTRASEÑA", pass);
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "Edison");
                    }
                    File.AppendAllText(rutaNueva, texto);
                    texto = textoOrigen;
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Edison");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Edison");
        }

        #endregion
        #region Amiko Cccam
        private void btnCccamAmiko_Click(object sender, EventArgs e)
        {
            if (panelIris.Visible == true) panelIris.Visible = false;
            FormPrincipal not = new FormPrincipal();
            if (txbCccam.Text == "")
            {
                not.PopupNotificacion(Properties.Resources.error, "Debe introducir una cline como mínimo.", "Amiko");
                return;
            }
            if (txbCccam.Lines.Length > 4)
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "Mas de 4 lineas puede causar colapso en su decodificador.", "Amiko");
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "hsdata.cfg";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaNueva = saveFileDialog1.FileName;
                string ruta = Path.Combine(Application.StartupPath, "prueba.txt");
                File.WriteAllText(ruta, txbAmiko.Text);
                string texto = File.ReadAllText(ruta);
                string textoOrigen = texto;
                string auxiliar = Path.Combine(Application.StartupPath, "auxiliar.txt");
                File.WriteAllText(auxiliar, txbCccam.Text);
                string cadena = "Mi cadena";
                StreamReader reader = new StreamReader(auxiliar);
                //File.AppendAllText(rutaNueva, "cfg~0~0~00000000" + Environment.NewLine + Environment.NewLine);

                while (cadena != null)
                {
                    cadena = reader.ReadLine();
                    if (cadena == null)
                    {
                        reader.Close();
                        File.Delete(ruta);
                        File.Delete(auxiliar);
                        not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Amiko");
                        return;
                    }
                    try
                    {
                        string[] clines = cadena.Split(' ');
                        string valor0 = clines[0];
                        if (clines.Length < 5)
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben contener 5 elementos.", "Amiko");
                            File.Delete(ruta);
                            reader.Close();
                            File.Delete(auxiliar);
                            File.Delete(rutaNueva);
                            return;
                        }
                        if (valor0 != "C:" & valor0 != "c:")
                        {
                            not.PopupNotificacion(Properties.Resources.error, "Las clines deben empezar por C: en todas sus líneas.", "Amiko");
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
                        //texto = texto.Replace("description=remote_cccam", "description=remote_cccam" + contador);
                        texto = texto.Replace("PUERTO", puerto);
                        texto = texto.Replace("HOST", host);
                        texto = texto.Replace("USUARIO", user);
                        texto = texto.Replace("CONTRASEÑA", pass);
                    }
                    catch
                    {
                        not.PopupNotificacion(Properties.Resources.info, "Falta poco.", "Amiko");
                    }
                    File.AppendAllText(rutaNueva, texto);
                    texto = textoOrigen;
                }

                reader.Close();

                File.Delete(ruta);
                File.Delete(auxiliar);
                not.PopupNotificacion(Properties.Resources.info, "Sus clines están listas para usarse.", "Amiko");
                return;
            }
            else
                not.PopupNotificacion(Properties.Resources.error, "Cancelado por el usuario.", "Amiko");
        }
        #endregion
    }
}
