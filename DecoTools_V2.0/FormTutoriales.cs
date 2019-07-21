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
        FormPrincipal not = new FormPrincipal();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblVti.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/vti-tutorials/");

            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "VTI");
            }
        }

        private void lblOpenpli_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblOpenpli.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/openpli/");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "OPENPLI");
            }
        }

        private void lblOpenspa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblOpenspa.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/openspa/");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "OPENSPA");
            }
        }
        private void lblOpenvix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                try
                {
                // marcar link como visitado
                this.lblOpenvix.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/openvix/");
                }
                catch
                {
                    not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "OPENVIX");
                }
            }

        private void lblBlackhole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblBlackhole.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/blackhole-tutorials/");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "BLACKHOLE");
            }
        }

        private void lblOpenatv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblOpenatv.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/openatv-tutorials/");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "OPENATV");
            }
        }

        private void lblOpenplus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblOpenplus.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/openplus/");;
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "OPENPLUS");
            }
        }

        private void lblOpenesi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblOpenesi.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/category/tutorials/openesi/");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "OPENESI");
            }
        }

        private void lblOscamEmu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblOscamEmu.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/?s=OSCAM");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "EMULADORA OSCAM");
            }
        }

        private void lblNcamEmu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblNcamEmu.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/?s=NCAM");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "EMULADORA NCAM");
            }
        }

        private void lblCCcamEmu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // marcar link como visitado
                this.lblCCcamEmu.LinkVisited = true;

                // Abrir url en navegador predeterminado
                System.Diagnostics.Process.Start("https://www.vuplus4k.com/?s=CCCAM");
            }
            catch
            {
                not.PopupNotificacion(Properties.Resources.error, "No se pudo abrir el enlace.", "EMULADORA CCCAM");
            }
        }

        private void btnEdison_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo hsdata.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
               "    - Ahora vamos a Menú/Conditional acces/ip Share\r\n" +
               "    - En la siguiente pantalla seleccionamos net client config\r\n" +
               "    - Pulsamos sobre la lupa del mando para importar el archivo\r\n" +
               "    - Por último pulsamos aceptar\r\n" +
               "    - Listo!! ya tenemos funcionando nuestro decodificador.", "Edision picollino s2");
        }

        private void btnEngelMini_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo CCcam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
                "   - Abrimos MENÚ y vamos a la opción Actualizar SW.\r\n" +
                "   - Una vez dentro buscamos nuestro archivo CCcam.cfg.\r\n" +
                "   - Elegimos la opción dbusuario y le damos al OK.\r\n" +
                "   - Si nos pregunta por importar datos, damos a SI.\r\n" +
                "   - Listo!! ya tenemos funcionando nuestro Engel rs4800s mini.", "Engel Mini");
        }

        private void btnEngel4800y_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo CCcam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
                "   - Ahora vamos a Menú/Actualiza/Actualizar por usb\r\n" +
                "   - En el menú de la derecha, en el apartado Modo act. elegimos Cccam Newcam\r\n" +
                "   - Ya nos saldrá nuestro archivo CCcam.cfg y damos a comenzar\r\n" +
                "   - Si no reconoce el archivo lo renombraremos a cccam_newcamd.cfg y damos a comenzar\r\n" +
                "   - Nos saldrá el mensaje ¿Está seguro de quemar flash?\r\n" +
                "   - Daremos a si y en unos segundos nos pondrá actualización OK\r\n" +
                "   - Damos atrás en el mando para ir al menú principal y marcamos 7777 para habilitar el menú oculto\r\n" +
                "   - Ya en ese menú, en la opción de modo activamos cccam y damos a aplicar\r\n" +
                "   - Listo!! ya tenemos funcionando nuestro decodificador.", "Engel 4800y");
        }

        private void btnEngel8100y_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo CCcam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
                "   - Ahora vamos a Menú/Herramientas/Actualizar por usb\r\n" +
                "   - Pulsamos sobre el Usb, seguido pulsamos sobre el archivo CCcam.cfg y damos a OK\r\n" +
                "   - Nos saldrá el mensaje ¿Está seguro de actualizar?\r\n" +
                "   - Daremos a reemplazar si queremos borrar las que hay o añadir para si no queremos borrarlas\r\n" +
                "   - Para ver el estado de las lineas,nos dirigimos a Menú/Configuración/Información y pulsamos 7777\r\n" +
                "   - Listo!! ya tenemos funcionando nuestro decodificador.", "Engel 8100y");
        }

        private void btnFreesatV7_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo CCcam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
                "   - Ahora vamos a Menú/Red/\r\n" + 
                "   - Pulsamos 6666 en el mando para activar la opción Protocolo CS.\r\n" +
                "   - Nos metemos dentro del menú Protocolo CS.\r\n" +
                "   - Marcamos tipo de protocolo CCcam y en cuenta USB damos a OK.\r\n" +
                "   - Nos aparece un mensaje de si queremos importar datos, pulsamos que SI.\r\n" +
                "   - En aplicar pulsamos sobre OK." +
                "   - Listo!! ya tenemos funcionando nuestro decodificador.", "Freesat V7/V7s");
        }

        private void btnFreesatV8_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo CCcam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
               "    - Ahora vamos a Menú/Red/\r\n" +
               "    - Pulsamos 6666 en el mando para activar la opción Protocolo CS.\r\n" +
               "    - Nos metemos dentro del menú Protocolo CS.\r\n" +
               "    - Marcamos tipo de protocolo CCcam y en cuenta USB damos a OK.\r\n" +
               "    - Nos aparece un mensaje de si queremos importar datos, pulsamos que SI.\r\n" +
               "    - En aplicar pulsamos sobre OK.\r\n" +
               "    - Listo!! ya tenemos funcionando nuestro decodificador.","Freesat V8 Super/GOLDEN/COMBO");
        }

        private void btnGigaTv360_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo cccam_acounts.txg en la raiz del pendrive y lo conectamos al decodificador.\r\n" +
                "   - Pulsamos en menú.\r\n" +
                "   - Pulsamos 9999.\r\n" +
                "   - Ahora le damos a OK y entramos dentro de CCCam\r\n" +
                "   - Le damos a Explorador de archivos (botón verde)\r\n" +
                "   - Por último en estado veremos si están conectadas las clines.\r\n" +
                "   - Listo!! ya tenemos nuestro decodificador funcionando con Cccam.", "GigaTV HD360 IPS");
        }

        private void btnGigaTv460_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo cccam_acounts.txg en la raiz del pendrive y lo conectamos al decodificador.\r\n" +
                "   - Pulsamos en menú.\r\n" +
                "   - Pulsamos 9999.\r\n" +
                "   - Ahora le damos a OK y entramos dentro de CCcam\r\n" +
                "   - Le damos a Explorador de archivos (botón verde).\r\n" +
                "   - Por último en estado veremos si están conectadas las clines.\r\n" +
                "   - Listo!! ya tenemos nuestro decodificador funcionando con Cccam.", "GigaTV HD460s");
        }

        private void btnIris2_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Pulsamos el botón MENÚ.\r\n" +
                "   - Pulsamos 6666.\r\n" +
                "   - Nos colocamos sobre la opción CCcam y lo marcamos con el botón azúl para activarlo.\r\n" +
                "   - Pulsamos a OK y entramos dentro de CCcam.\r\n" + 
                "   - Le damos a explorador de archivos (Botón verde).\r\n" +
                "   - Seleccionamos nuestro archivo cccam_acounts.txt y le damos a OK.\r\n" +
                "   - Las clines se habrán cargado en el decodificador y volveréis de nuevo a la pantalla de ajustes de CCCam.\r\n" +
                "   - Por último pulsar sobre conectar.\r\n" +
                "   - Listo!! ya tenemos nuestro decodificador funcionando con protocolo CCcam.", "Iris 2600HD/2700HD");
        }

        private void btnIris9700_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo Cccam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
                "   - Pulsamos el botón MENÚ.\r\n" +
                "   - Vamos a ACTUALIZAR y entramos en actualización USB.\r\n" +
                "   - Nos situamos en la raiz del pendrive, pulsamos sobre el archivo Cccam.cfg y presionamos OK.\r\n" +
                "   - La configuración de CCcam se copiará en nuestro decodificador.\r\n" +
                "   - Una vez metidas las clines en nuestro receptor, pulsamos el botón MENÚ del mando.\r\n" +
                "   - Pulsamos 6666 y OK\r\n" +
                "   - Seleccionamos CCcam y pulsamos OK.\r\n" +
                "   - Listo!! ya tenemos nuestro decodificador funcionando con el protocolo CCcam.", "Iris 9700 HD");
        }

        private void btnIris9900_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo cccam_acounts.txt en la raiz del pendrive y lo conectamos al decodificador.\r\n" +
                "   - Pulsamos el botón MENÚ.\r\n" +
                "   - Pulsamos 6666.\r\n" +
                "   - Nos colocamos sobre la opción CCCam y lo marcamos con el botón azúl para activarlo.\r\n" +
                "   - Pulsamos a OK y entramos dentro de CCCam.\r\n" +
                "   - Le damos a explorador de archivos (Botón verde).\r\n" +
                "   - Seleccionamos nuestro archivo cccam_acounts.txt y le damos a OK.\r\n" +
                "   - Las clines se habrán cargado en el decodificador y volveréis de nuevo a la pantalla de ajustes de CCCam.\r\n" +
                "   - Por último pulsar sobre conectar.\r\n" +
                "   - Listo!! ya tenemos nuestro decodificador funcionando con protocolo CCCam.", "Iris 9900HD/9900HD 02/9900HD 03");
        }

        private void btnGTMedia8_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo CCcam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
               "    - Ahora vamos a Menú/Red\r\n" +
               "    - Pulsamos 6666 en el mando para activar la opción Protocolo CS.\r\n" +
               "    - Nos metemos dentro del menú Protocolo CS.\r\n" +
               "    - Marcamos tipo de protocolo CCcam y en cuenta USB damos a OK.\r\n" +
               "    - Nos aparece un mensaje de si queremos importar datos, pulsamos que SI.\r\n" +
               "    - En aplicar pulsamos sobre OK." +
               "    - Listo!! ya tenemos funcionando nuestro decodificador.", "Freesat Nova V8");
        }

        private void btnGTMedia9_Click(object sender, EventArgs e)
        {
            FormMessageBox mensaje = new FormMessageBox();
            mensaje.Show();
            mensaje.MensajeDeco("   - Metemos el archivo CCcam.cfg en la raiz del pendrive y lo conectamos al deco.\r\n" +
               "    - Ahora vamos al menú configuración de red\r\n" +
               "    - Bajamos y nos posicionamos sobre net elegir y pulsamos 6666\r\n" +
               "    - Se nos habilitará la opción Protocolo más abajo y pulsamos sobre ella\r\n" +
               "    - En tipo de red elegimos cccam y sobre importar damos a OK\r\n" +
               "    - Seguido pulsamos sobre aplicar y daremos que si para reiniciar el protocolo\r\n" +
               "    - Listo!! ya tenemos funcionando nuestro decodificador.", "Freesat Nova V9 Super");
        }
    }
}
