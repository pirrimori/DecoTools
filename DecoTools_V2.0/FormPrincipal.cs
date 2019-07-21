using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace DecoTools_V2._0
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            AbrirFormulario<FormAcercade>();
            //Cambiamos el color del boton que dejamos pulsado
            btnAcercade.BackColor = Color.FromArgb(13, 93, 142);
        }
        #region Funcionalidades del Formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //Dibujamos las rayitas inferiores donde se alarga o contrae la aplicacion
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //Capturar posicion y tamaño de maximizar par luego restaurar
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            //El tamaño es igual al tamaño del escritorio,para no ocultar el dock de windows
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //La localizacion sera igual a la de la del escritorio tb
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            //Pasamos como parametro al objeto creado el tamaño y localizacion capturados
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            //En el evento MouseMove del panel titulo metemos los metodos para arrastrar la aplicacion desde la barra
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnCccam_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCccam>();
            //Cambiamos el color del boton que dejamos pulsado
            btnCccam.BackColor = Color.FromArgb(13, 93, 142);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Añadimos hora y fecaha al datatime del timer
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnIptv_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormIptv>();
            //Cambiamos el color del boton que dejamos pulsado
            btnIptv.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnOpenwebif_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormOpenwebif>();
            //Cambiamos el color del boton que dejamos pulsado
            btnOpenwebif.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnWiseplay_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormWiseplay>();
            //Cambiamos el color del boton que dejamos pulsado
            btnWiseplay.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListas>();
            //Cambiamos el color del boton que dejamos pulsado
            btnListas.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnTutoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormTutoriales>();
            //Cambiamos el color del boton que dejamos pulsado
            btnTutoriales.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAcercade>();
            //Cambiamos el color del boton que dejamos pulsado
            btnAcercade.BackColor = Color.FromArgb(13, 93, 142);
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormOtros>();
            //Cambiamos el color del boton que dejamos pulsado
            btnOtros.BackColor = Color.FromArgb(13, 93, 142);
        }

        #endregion
        //METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL
        //Creamos metodo generico con <> sin parametros,donde Miform herede de Form con constructor vacio
        public void AbrirFormulario<Miform>() where Miform : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<Miform>().FirstOrDefault();//Busca en la coleccion el formulario
            //si formulario/instancia no existe
            if (formulario == null)
            {
                //Creamos nueva instancia de formulario
                formulario = new Miform();
                //Formulario no es de tipo nivel superior
                formulario.TopLevel = false;
                //Quitamos los bordes al formulario
                formulario.FormBorderStyle = FormBorderStyle.None;
                //Expandimos formulario sobre todo el panel formularios
                formulario.Dock = DockStyle.Fill;
                //Añadimos formulario al panel de formularios
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                //Traemos al frente
                formulario.BringToFront();
                //llamamos al metodo FormClose desde aqui
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            //si formulario/instancia existe
            else
            {
                //Lo traemos al frente
                formulario.BringToFront();
            }
        }

        //Creamos metodo para que los botones del menu vuelvan a su color original cuando no este el formulario abierto
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            //Si el formulario especificado no está abierto,damos el color por defecto a su botón
            if (Application.OpenForms["FormCccam"] == null)
                btnCccam.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormOpenwebif"] == null)
                btnOpenwebif.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormWiseplay"] == null)
                btnWiseplay.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormListas"] == null)
                btnListas.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormIptv"] == null)
                btnIptv.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormTutoriales"] == null)
                btnTutoriales.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormAcercade"] == null)
                btnAcercade.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["FormOtros"] == null)
                btnOtros.BackColor = Color.FromArgb(4, 41, 68);

        }

        public void PopupNotificacion(Image error, string content,string textoTitulo)
        {
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
            popup.TitleText = textoTitulo + Environment.NewLine + Environment.NewLine;
            popup.Image = error;
            popup.ContentText = content;
            popup.Popup();//show
        }
    }
}
        