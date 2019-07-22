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
        FormPrincipal not = new FormPrincipal();
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTituloFtp_MouseMove(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void FtpUpload( string archivoFtp, string archivoOrigen)
        {      
            string direccion = txbDireccion.Text;
            string usuario = txbUsuario.Text;
            string contraseña = txbContraseña.Text;
            string folderName = txbRuta.Text;
            string absoluteFileName = archivoFtp;
            string fileName = archivoOrigen;
            //string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + archivoOrigen;
            FtpWebRequest request;
            try
            {
                request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/{2}", direccion, folderName, absoluteFileName))) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Credentials = new NetworkCredential(usuario, contraseña);
                request.ConnectionGroupName = "group";

            }
            catch (System.UriFormatException)
            {
                not.PopupNotificacion(Properties.Resources.error, "No puede dejar los recuadros en blanco", archivoFtp);
                return;
            }
            
            using (FileStream fs = File.OpenRead(fileName))
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
                    not.PopupNotificacion(Properties.Resources.error, "Archivo cargado correctamente", archivoFtp);
                }
                catch (System.Net.WebException)
                {
                    not.PopupNotificacion(Properties.Resources.error, "No se puede conectar con el servidor,revise dirección ip,usuario y contraseña.", archivoFtp);
                    return;
                }

            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFtp_Load(object sender, EventArgs e)
        {

        }
        //metodo para comprobar que existe el directorio
        public Boolean existeObjeto(string direccion,string dir, string user, string pass)
        {
            FtpWebRequest peticionFTP;
            //Creamos una peticion FTP con la dirección del objeto que queremos saber si existe 
            peticionFTP = (FtpWebRequest)WebRequest.Create(new Uri(String.Format(@"ftp://{0}/{1}", direccion, dir)));
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
                //si el objeto no existe, se producirá un error y al entrar por el Catch 
                //se devolvera falso 
                return false;
                
            }
            
        }
        // metodo para crear directorio
        public String creaDirectorio(string direccion,string dir,string user,string pass)
        {

            FtpWebRequest peticionFTP;

            // Creamos una peticion FTP con la dirección del directorio que queremos crear 
            peticionFTP = (FtpWebRequest)WebRequest.Create(new Uri(String.Format(@"ftp://{0}{1}", direccion, dir)));
            peticionFTP.KeepAlive = true;

            // Fijamos el usuario y la contraseña de la petición 
            peticionFTP.Credentials = new NetworkCredential(user, pass);

            // Seleccionamos el comando que vamos a utilizar: Crear un directorio 
            peticionFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
            //(FtpWebResponse) request.GetResponse(); 

            try
            {
                FtpWebResponse respuesta;
                respuesta = (FtpWebResponse)peticionFTP.GetResponse();
                respuesta.Close();
                // Si todo ha ido bien, se devolverá String.Empty 
                return string.Empty;

            }
            catch (Exception ex)
            {
                // Si se produce algún fallo, se devolverá el mensaje del error 
                return ex.Message;
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
 
        {
            FormMessageBox pregunta = new FormMessageBox();
            string direccion = txbDireccion.Text;
            string dir = txbRuta.Text;
            string user = txbUsuario.Text;
            string pass = txbContraseña.Text;
            //string[] carpetas = dir.Split('/');
            bool resultado = existeObjeto(direccion,dir,user,pass);
            if (resultado == false)
            {
                
                //pregunta.ShowDialog();
                pregunta.MostrarBotonesAceptar(true);
                pregunta.MensajeDeco("El directorio marcado no existe, ¿desea crearlo?", "Precaución");
                pregunta.ShowDialog();
                //Capturar si o no de la pregunta
                bool respuesta = pregunta.Aceptar();
                if (respuesta == true)
                {
                    creaDirectorio(direccion, dir, user, pass); 
                }
                not.PopupNotificacion(Properties.Resources.error, "Directorio " + dir + " creado correctamente.", "");
            }
            //FormMessageBox pregunta = new FormMessageBox();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = @openFileDialog1.FileName;
                openFileDialog1.Multiselect = false;
                FileInfo info = new FileInfo(rutaArchivo);
                string archivo = info.Name;
                FtpUpload(archivo, rutaArchivo);

            }
            return;
        }
    }
}

