using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // need to added
using System.Diagnostics;
using System.Net.Sockets;

namespace DecoTools_V2._0
{
    public partial class FormFtp : Form
    {
        public string Username;
        public string Filename;
        public string Fullname;
        public string Server;
        public string Password;
        public string path;
        public string localdest;

        public FormFtp()

        {
            InitializeComponent();

        }
    }
}
