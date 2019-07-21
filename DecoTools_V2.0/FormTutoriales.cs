using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoTools_V2._0
{
    public partial class FormTutoriales : Form
    {
        public FormTutoriales()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisitLink(bool visitado, string link)
        {
            // Cambiar el color del texto del enlace configurando LinkVisited a true
            lblVti.LinkVisited = visitado;
            //Llame al método Process.Start para abrir el navegador predeterminado con una URL:   
            System.Diagnostics.Process.Start(link);
        }

        private void lblVti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-vti.122/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void lblOpenpli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-openpli.115/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void lblOpenspa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-openspa.136/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void lblOpenvix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-openvix.133/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void lblTeamblu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-teamblue.135/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void lblBlackhole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-blackhole.121/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void lblEgami_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-egami.134/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void lblOpenatv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(true, "http://spaine2.es/forums/imagen-openatv.114/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace en el que se hizo clic.");
            }
        }

        private void btnCccam_Click(object sender, EventArgs e)
        {
            //WebClient myWebClient = new WebClient();
            //string destino = Path.Combine("c:\\Protocolos", "CCcam.ipk");
            //string url = "http://spaine2.es/attachments/spaine2-es-cccam-arm_vti-2-3-2_all-ipk.157/";
            //myWebClient.DownloadFile(url, destino);
        }
    }
}
