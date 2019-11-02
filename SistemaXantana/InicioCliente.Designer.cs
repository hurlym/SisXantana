namespace SistemaXantana
{
    partial class InicioCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_TitCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelFiltrado = new System.Windows.Forms.Panel();
            this.BT_Filtrar = new System.Windows.Forms.Button();
            this.TB_Filtro = new System.Windows.Forms.TextBox();
            this.LBFiltro = new System.Windows.Forms.Label();
            this.BT_FiltrarPor = new System.Windows.Forms.Button();
            this.DGV_Clientes = new System.Windows.Forms.DataGridView();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditoCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeudaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Salir = new System.Windows.Forms.Button();
            this.BT_Imprimir = new System.Windows.Forms.Button();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.BT_AgCliente = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numListaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefContIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailContIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoContIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefContIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailContIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoContIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContIIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefContIIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailContIIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoContIIIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditoCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deudaCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LB_TitCliente);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 40);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(674, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPRESA";
            // 
            // LB_TitCliente
            // 
            this.LB_TitCliente.AutoSize = true;
            this.LB_TitCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TitCliente.ForeColor = System.Drawing.Color.White;
            this.LB_TitCliente.Location = new System.Drawing.Point(14, 12);
            this.LB_TitCliente.Name = "LB_TitCliente";
            this.LB_TitCliente.Size = new System.Drawing.Size(71, 19);
            this.LB_TitCliente.TabIndex = 0;
            this.LB_TitCliente.Text = "CLIENTES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.PanelFiltrado);
            this.panel2.Controls.Add(this.BT_FiltrarPor);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 55);
            this.panel2.TabIndex = 2;
            // 
            // PanelFiltrado
            // 
            this.PanelFiltrado.Controls.Add(this.BT_Filtrar);
            this.PanelFiltrado.Controls.Add(this.TB_Filtro);
            this.PanelFiltrado.Controls.Add(this.LBFiltro);
            this.PanelFiltrado.Location = new System.Drawing.Point(109, 6);
            this.PanelFiltrado.Name = "PanelFiltrado";
            this.PanelFiltrado.Size = new System.Drawing.Size(441, 46);
            this.PanelFiltrado.TabIndex = 1;
            // 
            // BT_Filtrar
            // 
            this.BT_Filtrar.Location = new System.Drawing.Point(277, 11);
            this.BT_Filtrar.Name = "BT_Filtrar";
            this.BT_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.BT_Filtrar.TabIndex = 2;
            this.BT_Filtrar.Text = "Filtrar";
            this.BT_Filtrar.UseVisualStyleBackColor = true;
            // 
            // TB_Filtro
            // 
            this.TB_Filtro.Location = new System.Drawing.Point(91, 13);
            this.TB_Filtro.Name = "TB_Filtro";
            this.TB_Filtro.Size = new System.Drawing.Size(178, 20);
            this.TB_Filtro.TabIndex = 1;
            // 
            // LBFiltro
            // 
            this.LBFiltro.AutoSize = true;
            this.LBFiltro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFiltro.ForeColor = System.Drawing.Color.White;
            this.LBFiltro.Location = new System.Drawing.Point(5, 14);
            this.LBFiltro.Name = "LBFiltro";
            this.LBFiltro.Size = new System.Drawing.Size(46, 18);
            this.LBFiltro.TabIndex = 0;
            this.LBFiltro.Text = "label2";
            // 
            // BT_FiltrarPor
            // 
            this.BT_FiltrarPor.Location = new System.Drawing.Point(18, 17);
            this.BT_FiltrarPor.Name = "BT_FiltrarPor";
            this.BT_FiltrarPor.Size = new System.Drawing.Size(75, 23);
            this.BT_FiltrarPor.TabIndex = 0;
            this.BT_FiltrarPor.Text = "Filtrar Por";
            this.BT_FiltrarPor.UseVisualStyleBackColor = true;
            // 
            // DGV_Clientes
            // 
            this.DGV_Clientes.AllowUserToAddRows = false;
            this.DGV_Clientes.AllowUserToDeleteRows = false;
            this.DGV_Clientes.AllowUserToResizeRows = false;
            this.DGV_Clientes.AutoGenerateColumns = false;
            this.DGV_Clientes.ColumnHeadersHeight = 34;
            this.DGV_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Provincia,
            this.IVA,
            this.NFiscal,
            this.Telef,
            this.Observ,
            this.NombreVendedor,
            this.DireccionEnvio,
            this.CreditoCC,
            this.DeudaCC,
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn,
            this.cPDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefDataGridViewTextBoxColumn,
            this.nFiscalDataGridViewTextBoxColumn,
            this.observDataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.codEmpresaDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.expresoDataGridViewTextBoxColumn,
            this.ultimaCompraDataGridViewTextBoxColumn,
            this.numListaDataGridViewTextBoxColumn,
            this.condicionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.fantasiaDataGridViewTextBoxColumn,
            this.direccionEnvioDataGridViewTextBoxColumn,
            this.fechaAltaDataGridViewTextBoxColumn,
            this.nombreContIDataGridViewTextBoxColumn,
            this.telefContIDataGridViewTextBoxColumn,
            this.emailContIDataGridViewTextBoxColumn,
            this.cargoContIDataGridViewTextBoxColumn,
            this.nombreContIIDataGridViewTextBoxColumn,
            this.telefContIIDataGridViewTextBoxColumn,
            this.emailContIIDataGridViewTextBoxColumn,
            this.cargoContIIDataGridViewTextBoxColumn,
            this.nombreContIIIDataGridViewTextBoxColumn,
            this.telefContIIIDataGridViewTextBoxColumn,
            this.emailContIIIDataGridViewTextBoxColumn,
            this.cargoContIIIDataGridViewTextBoxColumn,
            this.consultaDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.creditoCCDataGridViewTextBoxColumn,
            this.deudaCCDataGridViewTextBoxColumn});
            this.DGV_Clientes.DataSource = this.clienteBindingSource;
            this.DGV_Clientes.Location = new System.Drawing.Point(70, 94);
            this.DGV_Clientes.Name = "DGV_Clientes";
            this.DGV_Clientes.Size = new System.Drawing.Size(704, 348);
            this.DGV_Clientes.TabIndex = 3;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Pcia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "DescIVA";
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // NFiscal
            // 
            this.NFiscal.DataPropertyName = "CUIT";
            this.NFiscal.HeaderText = "NFiscal";
            this.NFiscal.Name = "NFiscal";
            // 
            // Telef
            // 
            this.Telef.DataPropertyName = "Telefono";
            this.Telef.HeaderText = "Telef";
            this.Telef.Name = "Telef";
            // 
            // Observ
            // 
            this.Observ.DataPropertyName = "Observaciones";
            this.Observ.HeaderText = "Observ";
            this.Observ.Name = "Observ";
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.DataPropertyName = "NombreVendedor";
            this.NombreVendedor.HeaderText = "Nombre Vendedor";
            this.NombreVendedor.Name = "NombreVendedor";
            // 
            // DireccionEnvio
            // 
            this.DireccionEnvio.DataPropertyName = "DirecEnv";
            this.DireccionEnvio.HeaderText = "DireccionEnvio";
            this.DireccionEnvio.Name = "DireccionEnvio";
            // 
            // CreditoCC
            // 
            this.CreditoCC.DataPropertyName = "CreditoCC";
            this.CreditoCC.HeaderText = "CreditoCC";
            this.CreditoCC.Name = "CreditoCC";
            // 
            // DeudaCC
            // 
            this.DeudaCC.DataPropertyName = "DeudaCC";
            this.DeudaCC.HeaderText = "DeudaCC";
            this.DeudaCC.Name = "DeudaCC";
            // 
            // BT_Salir
            // 
            this.BT_Salir.BackgroundImage = global::SistemaXantana.Properties.Resources.salirVerde;
            this.BT_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_Salir.Location = new System.Drawing.Point(12, 387);
            this.BT_Salir.Name = "BT_Salir";
            this.BT_Salir.Size = new System.Drawing.Size(47, 53);
            this.BT_Salir.TabIndex = 11;
            this.BT_Salir.UseVisualStyleBackColor = true;
            // 
            // BT_Imprimir
            // 
            this.BT_Imprimir.BackgroundImage = global::SistemaXantana.Properties.Resources.ImpriVerde;
            this.BT_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Imprimir.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_Imprimir.Location = new System.Drawing.Point(7, 307);
            this.BT_Imprimir.Name = "BT_Imprimir";
            this.BT_Imprimir.Size = new System.Drawing.Size(56, 48);
            this.BT_Imprimir.TabIndex = 10;
            this.BT_Imprimir.UseVisualStyleBackColor = true;
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.BackgroundImage = global::SistemaXantana.Properties.Resources.eliminar1;
            this.BT_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_Eliminar.Location = new System.Drawing.Point(7, 215);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(55, 70);
            this.BT_Eliminar.TabIndex = 9;
            this.BT_Eliminar.UseVisualStyleBackColor = true;
            // 
            // BT_AgCliente
            // 
            this.BT_AgCliente.BackgroundImage = global::SistemaXantana.Properties.Resources.cliente_agregar;
            this.BT_AgCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_AgCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AgCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.BT_AgCliente.Location = new System.Drawing.Point(4, 128);
            this.BT_AgCliente.Name = "BT_AgCliente";
            this.BT_AgCliente.Size = new System.Drawing.Size(60, 71);
            this.BT_AgCliente.TabIndex = 8;
            this.BT_AgCliente.UseVisualStyleBackColor = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ClassBussines.Cliente);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // cPDataGridViewTextBoxColumn
            // 
            this.cPDataGridViewTextBoxColumn.DataPropertyName = "CP";
            this.cPDataGridViewTextBoxColumn.HeaderText = "CP";
            this.cPDataGridViewTextBoxColumn.Name = "cPDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // telefDataGridViewTextBoxColumn
            // 
            this.telefDataGridViewTextBoxColumn.DataPropertyName = "Telef";
            this.telefDataGridViewTextBoxColumn.HeaderText = "Telef";
            this.telefDataGridViewTextBoxColumn.Name = "telefDataGridViewTextBoxColumn";
            // 
            // nFiscalDataGridViewTextBoxColumn
            // 
            this.nFiscalDataGridViewTextBoxColumn.DataPropertyName = "NFiscal";
            this.nFiscalDataGridViewTextBoxColumn.HeaderText = "NFiscal";
            this.nFiscalDataGridViewTextBoxColumn.Name = "nFiscalDataGridViewTextBoxColumn";
            // 
            // observDataGridViewTextBoxColumn
            // 
            this.observDataGridViewTextBoxColumn.DataPropertyName = "Observ";
            this.observDataGridViewTextBoxColumn.HeaderText = "Observ";
            this.observDataGridViewTextBoxColumn.Name = "observDataGridViewTextBoxColumn";
            // 
            // iVADataGridViewTextBoxColumn
            // 
            this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
            this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
            // 
            // codEmpresaDataGridViewTextBoxColumn
            // 
            this.codEmpresaDataGridViewTextBoxColumn.DataPropertyName = "CodEmpresa";
            this.codEmpresaDataGridViewTextBoxColumn.HeaderText = "CodEmpresa";
            this.codEmpresaDataGridViewTextBoxColumn.Name = "codEmpresaDataGridViewTextBoxColumn";
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            // 
            // expresoDataGridViewTextBoxColumn
            // 
            this.expresoDataGridViewTextBoxColumn.DataPropertyName = "Expreso";
            this.expresoDataGridViewTextBoxColumn.HeaderText = "Expreso";
            this.expresoDataGridViewTextBoxColumn.Name = "expresoDataGridViewTextBoxColumn";
            // 
            // ultimaCompraDataGridViewTextBoxColumn
            // 
            this.ultimaCompraDataGridViewTextBoxColumn.DataPropertyName = "UltimaCompra";
            this.ultimaCompraDataGridViewTextBoxColumn.HeaderText = "UltimaCompra";
            this.ultimaCompraDataGridViewTextBoxColumn.Name = "ultimaCompraDataGridViewTextBoxColumn";
            // 
            // numListaDataGridViewTextBoxColumn
            // 
            this.numListaDataGridViewTextBoxColumn.DataPropertyName = "NumLista";
            this.numListaDataGridViewTextBoxColumn.HeaderText = "NumLista";
            this.numListaDataGridViewTextBoxColumn.Name = "numListaDataGridViewTextBoxColumn";
            // 
            // condicionDataGridViewTextBoxColumn
            // 
            this.condicionDataGridViewTextBoxColumn.DataPropertyName = "Condicion";
            this.condicionDataGridViewTextBoxColumn.HeaderText = "Condicion";
            this.condicionDataGridViewTextBoxColumn.Name = "condicionDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // fantasiaDataGridViewTextBoxColumn
            // 
            this.fantasiaDataGridViewTextBoxColumn.DataPropertyName = "Fantasia";
            this.fantasiaDataGridViewTextBoxColumn.HeaderText = "Fantasia";
            this.fantasiaDataGridViewTextBoxColumn.Name = "fantasiaDataGridViewTextBoxColumn";
            // 
            // direccionEnvioDataGridViewTextBoxColumn
            // 
            this.direccionEnvioDataGridViewTextBoxColumn.DataPropertyName = "DireccionEnvio";
            this.direccionEnvioDataGridViewTextBoxColumn.HeaderText = "DireccionEnvio";
            this.direccionEnvioDataGridViewTextBoxColumn.Name = "direccionEnvioDataGridViewTextBoxColumn";
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            this.fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            // 
            // nombreContIDataGridViewTextBoxColumn
            // 
            this.nombreContIDataGridViewTextBoxColumn.DataPropertyName = "NombreContI";
            this.nombreContIDataGridViewTextBoxColumn.HeaderText = "NombreContI";
            this.nombreContIDataGridViewTextBoxColumn.Name = "nombreContIDataGridViewTextBoxColumn";
            // 
            // telefContIDataGridViewTextBoxColumn
            // 
            this.telefContIDataGridViewTextBoxColumn.DataPropertyName = "TelefContI";
            this.telefContIDataGridViewTextBoxColumn.HeaderText = "TelefContI";
            this.telefContIDataGridViewTextBoxColumn.Name = "telefContIDataGridViewTextBoxColumn";
            // 
            // emailContIDataGridViewTextBoxColumn
            // 
            this.emailContIDataGridViewTextBoxColumn.DataPropertyName = "EmailContI";
            this.emailContIDataGridViewTextBoxColumn.HeaderText = "EmailContI";
            this.emailContIDataGridViewTextBoxColumn.Name = "emailContIDataGridViewTextBoxColumn";
            // 
            // cargoContIDataGridViewTextBoxColumn
            // 
            this.cargoContIDataGridViewTextBoxColumn.DataPropertyName = "CargoContI";
            this.cargoContIDataGridViewTextBoxColumn.HeaderText = "CargoContI";
            this.cargoContIDataGridViewTextBoxColumn.Name = "cargoContIDataGridViewTextBoxColumn";
            // 
            // nombreContIIDataGridViewTextBoxColumn
            // 
            this.nombreContIIDataGridViewTextBoxColumn.DataPropertyName = "NombreContII";
            this.nombreContIIDataGridViewTextBoxColumn.HeaderText = "NombreContII";
            this.nombreContIIDataGridViewTextBoxColumn.Name = "nombreContIIDataGridViewTextBoxColumn";
            // 
            // telefContIIDataGridViewTextBoxColumn
            // 
            this.telefContIIDataGridViewTextBoxColumn.DataPropertyName = "TelefContII";
            this.telefContIIDataGridViewTextBoxColumn.HeaderText = "TelefContII";
            this.telefContIIDataGridViewTextBoxColumn.Name = "telefContIIDataGridViewTextBoxColumn";
            // 
            // emailContIIDataGridViewTextBoxColumn
            // 
            this.emailContIIDataGridViewTextBoxColumn.DataPropertyName = "EmailContII";
            this.emailContIIDataGridViewTextBoxColumn.HeaderText = "EmailContII";
            this.emailContIIDataGridViewTextBoxColumn.Name = "emailContIIDataGridViewTextBoxColumn";
            // 
            // cargoContIIDataGridViewTextBoxColumn
            // 
            this.cargoContIIDataGridViewTextBoxColumn.DataPropertyName = "CargoContII";
            this.cargoContIIDataGridViewTextBoxColumn.HeaderText = "CargoContII";
            this.cargoContIIDataGridViewTextBoxColumn.Name = "cargoContIIDataGridViewTextBoxColumn";
            // 
            // nombreContIIIDataGridViewTextBoxColumn
            // 
            this.nombreContIIIDataGridViewTextBoxColumn.DataPropertyName = "NombreContIII";
            this.nombreContIIIDataGridViewTextBoxColumn.HeaderText = "NombreContIII";
            this.nombreContIIIDataGridViewTextBoxColumn.Name = "nombreContIIIDataGridViewTextBoxColumn";
            // 
            // telefContIIIDataGridViewTextBoxColumn
            // 
            this.telefContIIIDataGridViewTextBoxColumn.DataPropertyName = "TelefContIII";
            this.telefContIIIDataGridViewTextBoxColumn.HeaderText = "TelefContIII";
            this.telefContIIIDataGridViewTextBoxColumn.Name = "telefContIIIDataGridViewTextBoxColumn";
            // 
            // emailContIIIDataGridViewTextBoxColumn
            // 
            this.emailContIIIDataGridViewTextBoxColumn.DataPropertyName = "EmailContIII";
            this.emailContIIIDataGridViewTextBoxColumn.HeaderText = "EmailContIII";
            this.emailContIIIDataGridViewTextBoxColumn.Name = "emailContIIIDataGridViewTextBoxColumn";
            // 
            // cargoContIIIDataGridViewTextBoxColumn
            // 
            this.cargoContIIIDataGridViewTextBoxColumn.DataPropertyName = "CargoContIII";
            this.cargoContIIIDataGridViewTextBoxColumn.HeaderText = "CargoContIII";
            this.cargoContIIIDataGridViewTextBoxColumn.Name = "cargoContIIIDataGridViewTextBoxColumn";
            // 
            // consultaDataGridViewTextBoxColumn
            // 
            this.consultaDataGridViewTextBoxColumn.DataPropertyName = "Consulta";
            this.consultaDataGridViewTextBoxColumn.HeaderText = "Consulta";
            this.consultaDataGridViewTextBoxColumn.Name = "consultaDataGridViewTextBoxColumn";
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            // 
            // creditoCCDataGridViewTextBoxColumn
            // 
            this.creditoCCDataGridViewTextBoxColumn.DataPropertyName = "CreditoCC";
            this.creditoCCDataGridViewTextBoxColumn.HeaderText = "CreditoCC";
            this.creditoCCDataGridViewTextBoxColumn.Name = "creditoCCDataGridViewTextBoxColumn";
            // 
            // deudaCCDataGridViewTextBoxColumn
            // 
            this.deudaCCDataGridViewTextBoxColumn.DataPropertyName = "DeudaCC";
            this.deudaCCDataGridViewTextBoxColumn.HeaderText = "DeudaCC";
            this.deudaCCDataGridViewTextBoxColumn.Name = "deudaCCDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 442);
            this.Controls.Add(this.BT_Salir);
            this.Controls.Add(this.BT_Imprimir);
            this.Controls.Add(this.BT_Eliminar);
            this.Controls.Add(this.BT_AgCliente);
            this.Controls.Add(this.DGV_Clientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PanelFiltrado.ResumeLayout(false);
            this.PanelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_TitCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelFiltrado;
        private System.Windows.Forms.Button BT_Filtrar;
        private System.Windows.Forms.TextBox TB_Filtro;
        private System.Windows.Forms.Label LBFiltro;
        private System.Windows.Forms.Button BT_FiltrarPor;
        private System.Windows.Forms.DataGridView DGV_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditoCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeudaCC;
        private System.Windows.Forms.Button BT_Salir;
        private System.Windows.Forms.Button BT_Imprimir;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Button BT_AgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numListaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefContIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailContIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoContIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefContIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailContIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoContIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContIIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefContIIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailContIIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoContIIIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deudaCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}

