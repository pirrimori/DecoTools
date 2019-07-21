using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//para acceder a la web
using System.IO;

namespace DecoTools_V2._0
{
    public partial class FormDescargas : Form
    {
        public FormDescargas()
        {
            InitializeComponent();
        }

        WebClient cliente = new WebClient();

        private void cargando(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblStatus.Text = progressBar1.Value.ToString() + "%";
        }

        private void descargado(object sender,AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            lblStatus.Text = "0%";

        }

        private void FormDescargas_Load(object sender, EventArgs e)
        {
            cliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler(cargando);
            cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(descargado);
        }

        //public void downloader(string url)
        //{
        //    FormPrincipal not = new FormPrincipal();
        //    SaveFileDialog dialog = new SaveFileDialog();
        //    dialog.Filter = "Todos los archivos|*.*";
        //    dialog.FileName = url.Substring(url.LastIndexOf("/") + 1);
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        ruta = dialog.FileName;
        //        cliente.DownloadFileAsync(new Uri(url), dialog.FileName);
        //    }
        //    not.PopupNotificacion(Properties.Resources.info, "Archivo descargado correctamente.", "Completado");
        //}

        //private void btnDescargar_Click(object sender, EventArgs e)
        //{
        //    FormPrincipal not = new FormPrincipal();
        //    SaveFileDialog dialog = new SaveFileDialog();
        //    dialog.Filter = "Todos los archivos|*.*";
        //    dialog.FileName = txburl.Text.Substring(txburl.Text.LastIndexOf("/") + 1);
        //    if (dialog.ShowDialog()== DialogResult.OK)
        //    {
        //        ruta = dialog.FileName;
        //        cliente.DownloadFileAsync(new Uri(txburl.Text), dialog.FileName);
        //    }
        //    not.PopupNotificacion(Properties.Resources.info, "Archivo descargado correctamente.", "Completado");
        //}
    }
}
