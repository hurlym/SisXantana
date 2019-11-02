using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaXantana
{
    public partial class InicioCliente : Form
    {
        ClassBussines.Cliente C = new ClassBussines.Cliente();

        public InicioCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelFiltrado.Visible = false;
            TraerLista();
        }

        private void TraerLista()
        {
            DataTable dtClientes = C.Lista();
            DGV_Clientes.DataSource = dtClientes;
        }
    }
}
