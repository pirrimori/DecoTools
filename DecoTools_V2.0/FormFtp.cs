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
using System.Net;
using System.Runtime.InteropServices;

namespace DecoTools_V2._0
{
    public partial class FormFtp : Form
    {
        public FormFtp()
        {
            InitializeComponent();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTituloFtp_MouseMove(object sender, MouseEventArgs e)
        {
            //En el evento MouseMove del panel titulo metemos los metodos para arrastrar la aplicacion desde la barra
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        FormPrincipal not = new FormPrincipal();
        public void FtpUpload(string NombreArchivoFtp, string NombreArchivo,string destPath)
        {
            string user = txbUsuario.Text;
            string pass = txbContraseña.Text;
            string ip = txbDireccion.Text;

                FtpWebRequest request;
                try
                {
                    //Abrimos conexion con la ruta ftp"
                    request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/{2}", ip, destPath, NombreArchivoFtp))) as FtpWebRequest;
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.UseBinary = true;
                    request.UsePassive = true;
                    request.KeepAlive = true;
                    request.Credentials = new NetworkCredential(user, pass);
                    request.ConnectionGroupName = "group";
                }

                catch (System.UriFormatException)
                {
                    not.PopupNotificacion(Properties.Resources.error, "No puede dejar los recuadros en blanco", "Error");
                    return;
                }

                using (FileStream fs = File.OpenRead(NombreArchivo))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    fs.Close();

                    try
                    {
                        Stream requestStream = request.GetRequestStream();
                        requestStream.Write(buffer, 0, buffer.Length);
                        requestStream.Flush();
                        requestStream.Close();
                        not.PopupNotificacion(Properties.Resources.info, "Archivo " + NombreArchivoFtp + " cargado correctamente", "Información");
                    }
                    catch (System.Net.WebException)
                    {
                        not.PopupNotificacion(Properties.Resources.error, "No se puede conectar con el servidor,revise dirección ip,usuario y contraseña.", "Error");
                        return;
                    }

                }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        //metodo para comprobar que existe el directorio
        public Boolean existeObjeto(string ip, string destPath, string user, string pass)
        {
            FtpWebRequest peticionFTP;
            //Creamos una peticion FTP con la dirección del objeto que queremos saber si existe 
            peticionFTP = (FtpWebRequest)WebRequest.Create(new Uri(String.Format(@"ftp://{0}/{1}", ip, destPath)));
            //Fijamos el usuario y la contraseña de la petición 
            peticionFTP.Credentials = new NetworkCredential(user, pass);
            //Para saber si el objeto existe, solicitamos la fecha de creación del mismo 
            peticionFTP.Method = WebRequestMethods.Ftp.GetDateTimestamp;
            peticionFTP.UsePassive = false;
            peticionFTP.KeepAlive = true;
            try
            {
                //si el objeto existe, se devolvera true 
                FtpWebResponse respuestaFTP;
                //respuestaFTP = CType(peticionFTP.GetResponse(), FtpWebResponse) 
                respuestaFTP = (FtpWebResponse)peticionFTP.GetResponse();

                return true;
            }
            catch (Exception ex)
                {
                    not.PopupNotificacion(Properties.Resources.error, "Erro: " + ex.Message.ToString(), "Error");
                    return false;
                }
            

        }
    
       
        // Crear varios directorios con bucle
        public static void MakeFTPDir(string ip, string destPath, string user, string pass)
        {
            
            FormPrincipal not = new FormPrincipal();
            FtpWebRequest reqFTP = null;
            Stream ftpStream = null;

            string[] subDirs = destPath.Split('/');

            string currentDir = string.Format("ftp://{0}", ip);

            foreach (string subDir in subDirs)
            {
                try
                {
                    currentDir = currentDir + "/" + subDir;
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(currentDir);
                    reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                    reqFTP.UseBinary = true;
                    reqFTP.Credentials = new NetworkCredential(user, pass);
                    FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                    ftpStream = response.GetResponseStream();
                    ftpStream.Close();
                    response.Close();
                    not.PopupNotificacion(Properties.Resources.info, "Directorio creado satisfactoriamente.", "Información");
                }
                catch (Exception ex)
                {
                    not.PopupNotificacion(Properties.Resources.error, "Erro: " + ex.Message.ToString(), "Error");
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)

        {
            string destPath = txbRuta.Text;
            string user = txbUsuario.Text;
            string pass = txbContraseña.Text;
            string ip = txbDireccion.Text;
            string NombreArchivo = "";
            string NombreArchivoFtp = "";

            //Elegimos el archivo que vamos a subir al ftp
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                NombreArchivo = @openFileDialog1.FileName;
                openFileDialog1.Multiselect = false;
                FileInfo info = new FileInfo(NombreArchivo);
                NombreArchivoFtp = info.Name;

            }
            else
            {
                not.PopupNotificacion(Properties.Resources.advertencia, "No se ha elegido archivo,otra vez será.", "Advertencia");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            if (destPath == "default")
            {
                if (NombreArchivoFtp == "CCcam.cfg") { destPath = "etc"; }
                if (NombreArchivoFtp == "oscam.server") { destPath = "etc/tuxbox/config"; }
                if (NombreArchivoFtp == "oscam.conf") { destPath = "etc/tuxbox/config"; }
                if (NombreArchivoFtp == "ncam.server") { destPath = "etc/tuxbox/config"; }
                if (NombreArchivoFtp == "ncam.conf") { destPath = "etc/tuxbox/config"; }
                if (NombreArchivoFtp == "gcam.server") { destPath = "etc/tuxbox/config"; }
                if (NombreArchivoFtp == "gcam.conf") { destPath = "etc/tuxbox/config"; }
            }

            bool resultado = existeObjeto(ip, destPath, user, pass);
            Cursor.Current = Cursors.Default;
                if (resultado == false)
                {
                    btnCargar.Enabled = false;
                    FormMensajeAceptar pregunta = new FormMensajeAceptar();
                    pregunta.CuadroPregunta("El directorio no existe, ¿desea crearlo?", "Información");
                    pregunta.ShowDialog();
                    //Capturar si o no de la pregunta
                    bool respuesta = pregunta.AceptarPregunta();
                    btnCargar.Enabled = true;
                    if (respuesta == true)
                    {
                    Cursor.Current = Cursors.WaitCursor;
                        MakeFTPDir(ip, destPath, user, pass);
                    Cursor.Current = Cursors.Default;
                }
                    else
                    {
                        not.PopupNotificacion(Properties.Resources.advertencia, "No se ha creado el directorio,otra vez será.", "Advertencia");
                        return;
                    }
                }
                else
                {
                    not.PopupNotificacion(Properties.Resources.info, "Directorio encontrado,espere unos segundos", "Información");
                }
            Cursor.Current = Cursors.WaitCursor;
            btnCargar.Enabled = false;
            //credenciales.TopLevel = true;
            FtpUpload(NombreArchivoFtp, NombreArchivo, destPath);
            btnCargar.Enabled = true;
            Cursor.Current = Cursors.WaitCursor;
        }
    }
}

