using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using Tulpep.NotificationWindow;
using System.IO;

namespace DecoTools_V2._0
{

    public partial class FormTelnetCliente : Form
    {
        //telnet parametros       
        NetworkStream telnetStream_A;
        TcpClient telnet_A;
        Thread t;
        bool telnet_receiving = false;
        string Telnet_out;
        delegate void Display(string s);
        string IP = "192.168.8.107";
        int PORT = 23;
        
        public FormTelnetCliente()

        {
            InitializeComponent();
        }

        private void FormTelnetCliente_Load(object sender, EventArgs e)
        {
        }

        private void ShowMessage(string buf)
        {
            tbxOutput.AppendText(buf);
        }

        private void btnConnectar_Click(object sender, EventArgs e)
        {
            FormPrincipal not = new FormPrincipal();
            IP = tbxIp.Text;
            PORT = Convert.ToInt16(txbPort.Text);

            Telnet_Connect(IP, PORT);
            tbxInput.Focus();
        }

        private void Telnet_Connect(string ip, int port)
        {
            FormPrincipal not = new FormPrincipal();
            try
            {
                tbxOutput.Text = "";

                telnet_A = new TcpClient();
                telnet_A.SendTimeout = 1000;
                telnet_A.ReceiveTimeout = 1000;
                telnet_A.Connect(IP, PORT);

                if (telnet_A.Connected)
                {
                    not.PopupNotificacion(Properties.Resources.info, "Conectado", "Telnet");
                    telnetStream_A = telnet_A.GetStream();
                    //Abrir hilo para recibir datos
                    telnet_receiving = true;
                    t = new Thread(Telnet_Read);
                    t.Start();
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                not.PopupNotificacion(Properties.Resources.error, ex.Message , "Telnet");
                //MessageBox.Show(ex.Message);
            }
        }

        //telnet lectura datos
        private void Telnet_Read()
        {
            FormPrincipal not = new FormPrincipal();
            try
            {
                while (telnet_receiving)
                {
                    if (telnetStream_A.DataAvailable)
                    {
                        byte[] bytes = new byte[telnet_A.ReceiveBufferSize];
                        int numBytesRead = telnetStream_A.Read(bytes, 0, (int)telnet_A.ReceiveBufferSize);
                        Array.Resize(ref bytes, numBytesRead);

                        Telnet_out = Encoding.ASCII.GetString(bytes);
                        Telnet_out = Telnet_out.Replace("??", "");
                        Telnet_out = Telnet_out.Replace("????", "");
                        Telnet_out = Telnet_out.Replace("[1;34m", "");
                        Telnet_out = Telnet_out.Replace("[0m", "");
                        Telnet_out = Telnet_out.Replace("[1;32m", "");
                        Telnet_out = Telnet_out.Replace("[1;36m", "");

                        //Pantalla delegada    
                        Display d = new Display(ShowMessage);
                        this.Invoke(d, new Object[] { Telnet_out });
                    }

                    Thread.Sleep(20);
                }
            }
            catch (Exception ex)
            {
                not.PopupNotificacion(Properties.Resources.error, ex.Message, "Telnet");
                //MessageBox.Show(ex.Message);
            }
        }

        //telnet info
        public void Telnet_SendData(string s)
        {
            FormPrincipal not = new FormPrincipal();
            byte[] bytWrite_telnet_A;

            if (s != null)
            {
                try
                {
                    bytWrite_telnet_A = Encoding.ASCII.GetBytes(s + "\r");
                    //datos
                    telnetStream_A.Write(bytWrite_telnet_A, 0, bytWrite_telnet_A.Length);
                }
                catch (Exception ex)
                {
                    not.PopupNotificacion(Properties.Resources.error, ex.Message, "Telnet");
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Telnet_SendData(tbxInput.Text);
                tbxInput.Clear();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
