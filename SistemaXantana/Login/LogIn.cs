using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;

namespace SistemaXantana.Login
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void BTMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTLogin_Click(object sender, EventArgs e)
        {
            if (TBUsuario.Text == "USUARIO - EMAIL" || TBUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario o email correcto.");
                return;
            }
            if (TBClave.Text == "CONTRASEÑA" || TBClave.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña.");
                return;
            }
            try
            {
                ClassBussines.Usuario Usuario = new ClassBussines.Usuario();
                Usuario.Apodo = TBUsuario.Text;
                Usuario.Clave = ClassBusiness.SHA.Parse(TBClave.Text);
                Usuario = Usuario.LogIn();
                Usuario.CargarPermisos();
                //_GuardarInformacionXML();
                this.Hide();
                //Inicio Ini = new Inicio(Usuario);
                //Ini.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

        }
    }
}
