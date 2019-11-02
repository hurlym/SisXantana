using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassConexion;
using System.Data;

namespace ClassBussines
{
    public class SingletonFasade:Conexion,
        IInternalGeneral<Cliente>,
        IInternalGeneral<Usuario>,
        IInternalGeneral<Permiso>,
        IInternalGeneral<TipoDePermiso>,
        IInternalGeneral<PermisoUsuario>,
        IInternalGeneral<Compras>,
        IInternalGeneral<Depositos>,
        IInternalGeneral<Factura>
    {

        #region Singleton
        public static SingletonFasade _instance = new SingletonFasade();
        public SingletonFasade() { }
        public static SingletonFasade GetInstance { get { return _instance; } }


        #endregion

        #region Cliente

        void IInternalGeneral<Cliente>.Add(Cliente Data)
        {
            CrearComando("Clientes_Insert");
            ParametersAddInt("Id", Data.Id);
            ParametersAddVarchar("Nombre", 50, Data.Nombre);
            ParametersAddVarchar("Direccion", 50, Data.Direccion);
            ParametersAddVarchar("Localidad", 50, Data.Localidad);
            ParametersAddInt("Provincia", Data.Provincia);
            ParametersAddInt("CP", Data.CP);
            ParametersAddVarchar("Mail", 50, Data.Mail);
            ParametersAddVarchar("Telef", 30, Data.Telef);
            ParametersAddVarchar("NFiscal", 30, Data.NFiscal);
            ParametersAddVarchar("Observ", 100, Data.Observ);
            ParametersAddInt("IVA", Data.IVA);
            ParametersAddInt("CodEmpresa", Data.CodEmpresa);
            ParametersAddInt("Vendedor", Data.Vendedor);
            ParametersAddVarchar("Expreso", 50, Data.Expreso);
            ParametersAddVarchar("UltimaCompra", 10, Data.UltimaCompra);
            ParametersAddInt("NumLitsa", Data.NumLista);
            ParametersAddInt("Condicion", Data.Condicion);
            ParametersAddInt("Tipo", Data.Tipo);
            ParametersAddVarchar("Fantasia", 50, Data.Fantasia);
            ParametersAddVarchar("DireccionEnvio", 50, Data.DireccionEnvio);
            ParametersAddVarchar("FechaAlta", 10, Data.FechaAlta);
            ParametersAddVarchar("NombreContI", 30, Data.NombreContI);
            ParametersAddVarchar("TelefContI", 15, Data.TelefContI);
            ParametersAddVarchar("EmailI", 50, Data.EmailContI);
            ParametersAddVarchar("CargoContI", 30, Data.CargoContI);
            ParametersAddVarchar("NombreContII", 30, Data.NombreContII);
            ParametersAddVarchar("TelefContII", 15, Data.TelefContII);
            ParametersAddVarchar("EmailII", 50, Data.EmailContII);
            ParametersAddVarchar("CargoContII", 30, Data.CargoContII);
            ParametersAddVarchar("NombreContIII", 30, Data.NombreContIII);
            ParametersAddVarchar("TelefContIII", 15, Data.TelefContIII);
            ParametersAddVarchar("EmailIII", 50, Data.EmailContIII);
            ParametersAddVarchar("CargoContIII", 30, Data.CargoContIII);
            Data.Id = Insert("No se pudo ingresar el Cliente");
        }

        void IInternalGeneral<Cliente>.Modify(Cliente Data)
        {
            CrearComando("Clientes_Insert");
            ParametersAddInt("Id", Data.Id);
            ParametersAddVarchar("Nombre", 50, Data.Nombre);
            ParametersAddVarchar("Direccion", 50, Data.Direccion);
            ParametersAddVarchar("Localidad", 50, Data.Localidad);
            ParametersAddInt("Provincia", Data.Provincia);
            ParametersAddInt("CP", Data.CP);
            ParametersAddVarchar("Mail", 50, Data.Mail);
            ParametersAddVarchar("Telef", 30, Data.Telef);
            ParametersAddVarchar("NFiscal", 30, Data.NFiscal);
            ParametersAddVarchar("Observ", 100, Data.Observ);
            ParametersAddInt("IVA", Data.IVA);
            ParametersAddInt("CodEmpresa", Data.CodEmpresa);
            ParametersAddInt("Vendedor", Data.Vendedor);
            ParametersAddVarchar("Expreso", 50, Data.Expreso);
            ParametersAddVarchar("UltimaCompra", 10, Data.UltimaCompra);
            ParametersAddInt("NumLitsa", Data.NumLista);
            ParametersAddInt("Condicion", Data.Condicion);
            ParametersAddInt("Tipo", Data.Tipo);
            ParametersAddVarchar("Fantasia", 50, Data.Fantasia);
            ParametersAddVarchar("DireccionEnvio", 50, Data.DireccionEnvio);
            ParametersAddVarchar("FechaAlta", 10, Data.FechaAlta);
            ParametersAddVarchar("NombreContI", 30, Data.NombreContI);
            ParametersAddVarchar("TelefContI", 15, Data.TelefContI);
            ParametersAddVarchar("EmailI", 50, Data.EmailContI);
            ParametersAddVarchar("CargoContI", 30, Data.CargoContI);
            ParametersAddVarchar("NombreContII", 30, Data.NombreContII);
            ParametersAddVarchar("TelefContII", 15, Data.TelefContII);
            ParametersAddVarchar("EmailII", 50, Data.EmailContII);
            ParametersAddVarchar("CargoContII", 30, Data.CargoContII);
            ParametersAddVarchar("NombreContIII", 30, Data.NombreContIII);
            ParametersAddVarchar("TelefContIII", 15, Data.TelefContIII);
            ParametersAddVarchar("EmailIII", 50, Data.EmailContIII);
            ParametersAddVarchar("CargoContIII", 30, Data.CargoContIII);
            this.Update("No se pudo actualizar el Cliente " + Data.Nombre);
        }

        void IInternalGeneral<Cliente>.Erase(Cliente Data)
        {
            CrearComando("Clientes_Delete");
            ParametersAddInt("Id", Data.Id);
            this.Update("No se pudo eliminar el cliente");
        }

        DataTable IInternalGeneral<Cliente>.Lista(Cliente Data)
        {
            CrearComando("Clientes_List");
            DataTable DT = List("No se pudo leer la lista de clientes");
            return DT;
        }

        void IInternalGeneral<Cliente>.Find(Cliente Data)
        {
            CrearComando("Clientes_Find");
            ParametersAddInt("Id", Data.Id);
            DataRow dr = this.Find("No se encontro el cliente");
            CargarCliente(dr, Data);
        }

        private void CargarCliente(DataRow dr, Cliente c)
        {
            
            c.Id = int.Parse(dr["Cliente"].ToString());
            c.Nombre = dr["Razon"].ToString();
            c.Direccion = dr["Direccion"].ToString();
            c.Localidad = dr["Localidad"].ToString();
            c.Provincia = int.Parse(dr["Provincia"].ToString());
            c.CP = int.Parse(dr["Postal"].ToString());
            c.Mail = dr["Email"].ToString();
            c.Telef = dr["Telefono"].ToString();
            c.NFiscal = dr["Cuit"].ToString();
            c.Observ = dr["Observaciones"].ToString();
            c.IVA = int.Parse(dr["Iva"].ToString());
            c.Vendedor = int.Parse(dr["Vendedor"].ToString());
            c.CodEmpresa = int.Parse(dr["CodigoEmpresa"].ToString());
            c.Expreso = dr["Expreso"].ToString();
            c.UltimaCompra = dr["UltimaCompra"].ToString();
            c.NumLista = int.Parse(dr["NroLista"].ToString());
            c.Condicion = int.Parse(dr["Condicion"].ToString());
            c.Tipo = int.Parse(dr["TipoClie"].ToString());
            c.Fantasia = dr["Fantasia"].ToString();
            c.DireccionEnvio = dr["DireccionII"].ToString();
            c.FechaAlta = dr["FechaAlta"].ToString();
            c.NombreContI = dr["NombreI"].ToString();
            c.TelefContI = dr["TelefonoI"].ToString();
            c.EmailContI = dr["EmailI"].ToString();
            c.CargoContI = dr["CargoI"].ToString();
            c.NombreContII = dr["NombreII"].ToString();
            c.TelefContII = dr["TelefonoII"].ToString();
            c.EmailContII = dr["EmailII"].ToString();
            c.CargoContII = dr["CargoII"].ToString();
            c.NombreContIII = dr["NombreIII"].ToString();
            c.TelefContIII = dr["TelefonoIII"].ToString();
            c.EmailContIII = dr["EmailIII"].ToString();
            c.CargoContIII = dr["CargoIII"].ToString();

        }

        int IInternalGeneral<Cliente>.Ultimo(Cliente Data)
        {
            int Ultimo;
            CrearComando("Clientes_FindUltimo");
            DataRow dr = this.Find("No se encontro el numero");
            if (dr[0].ToString() == "")
            {
                Ultimo = 0;
            }
            else
            {
                Ultimo = int.Parse(dr[0].ToString());
            }

            return Ultimo;
        }

        void IInternalGeneral<Cliente>.FindUltimo(Cliente Data)
        {
            throw new NotImplementedException();
        }

        List<Cliente> IInternalGeneral<Cliente>.List(Cliente Data)
        {
            throw new NotImplementedException();
        }

        

        DataTable IInternalGeneral<Cliente>.ListaP(Cliente Data)
        {
            throw new NotImplementedException();
        }






        #endregion

        #region Usuario

        void IInternalGeneral<Usuario>.Add(Usuario Data)
        {
            this.CrearComando("Usuarios_Insert");
            this.ParametersAddVarchar("Apodo", 30, Data.Apodo);
            this.ParametersAddVarchar("Clave", 100, Data.Clave);
            this.ParametersAddVarchar("Nombre", 50, Data.Nombre);
            this.ParametersAddVarchar("Apellido", 50, Data.Apellido);
            this.ParametersAddVarchar("Email", 50, Data.Email);
            this.ParametersAddInt("Sucursal", Data.Sucursal);
            Data.ID = this.Insert("Error: No se pudo agregar el usuario.");
        }

        void IInternalGeneral<Usuario>.Modify(Usuario Data)
        {
            this.CrearComando("Usuarios_Update");
            this.ParametersAddInt("ID", Data.ID);
            this.ParametersAddVarchar("Apodo", 30, Data.Apodo);
            this.ParametersAddVarchar("Clave", 100, Data.Clave);
            this.ParametersAddVarchar("Nombre", 50, Data.Nombre);
            this.ParametersAddVarchar("Apellido", 50, Data.Apellido);
            this.ParametersAddVarchar("Email", 50, Data.Email);
            this.ParametersAddInt("Sucursal", Data.Sucursal);
            this.Update("Error: No se pudo modificar el usuario.");
        }

        void IInternalGeneral<Usuario>.Erase(Usuario Data)
        {
            this.CrearComando("Usuarios_Delete");
            this.ParametersAddInt("ID", Data.ID);
            this.Update("Error: No se pudo eliminar el usuario.");
        }

        List<Usuario> IInternalGeneral<Usuario>.List(Usuario Data)
        {
            this.CrearComando("Usuarios_List");
            DataTable DT = this.List("Error: No se pudo listar los usuarios.");
            List<Usuario> Usuarios = new List<Usuario>();
            foreach (DataRow DR in DT.Rows)
            {
                Usuario U = new Usuario();
                _CargarUsuario(DR, U);
                Usuarios.Add(U);
            }
            return Usuarios;
        }

        void IInternalGeneral<Usuario>.Find(Usuario Data)
        {
            this.CrearComando("Usuarios_Find");
            this.ParametersAddInt("ID", Data.ID);
            DataRow DR = this.Find("Error: No se pudo buscar el usuario.");
            _CargarUsuario(DR, Data);
        }

        private void _CargarUsuario(DataRow DR, Usuario U)
        {
            U.ID = int.Parse(DR["ID"].ToString());
            U.Apodo = DR["Apodo"].ToString();
            U.Clave = DR["Clave"].ToString();
            U.Nombre = DR["Nombre"].ToString();
            U.Apellido = DR["Apellido"].ToString();
            U.Email = DR["Email"].ToString();
            U.FechaDeAlta = DateTime.Parse(DR["FechaDeAlta"].ToString());
            U.Cerrado = Convert.ToBoolean(DR["Cerrado"].ToString());
            U.Sucursal = int.Parse(DR["Sucursal"].ToString());
        }

        int IInternalGeneral<Usuario>.Ultimo(Usuario Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<Usuario>.FindUltimo(Usuario Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<Usuario>.Lista(Usuario Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<Usuario>.ListaP(Usuario Data)
        {
            throw new NotImplementedException();
        }




        #endregion


        #region Permiso

        void IInternalGeneral<Permiso>.Add(Permiso Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<Permiso>.Modify(Permiso Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<Permiso>.Erase(Permiso Data)
        {
            throw new NotImplementedException();
        }

        List<Permiso> IInternalGeneral<Permiso>.List(Permiso Data)
        {
            this.CrearComando("Permisos_List");
            DataTable DT = this.List("Error: No se pudo listar los permisos.");
            List<Permiso> Permisos = new List<Permiso>();
            foreach (DataRow DR in DT.Rows)
            {
                Permiso P = new Permiso();
                _CargarPermiso(DR, P);
                Permisos.Add(P);
            }
            return Permisos;
        }

        void IInternalGeneral<Permiso>.Find(Permiso Data)
        {
            this.CrearComando("Permisos_Find");
            this.ParametersAddInt("ID", Data.ID);
            DataRow DR = this.Find("Error: No se pudo buscar el permiso.");
            _CargarPermiso(DR, Data);
        }

        private void _CargarPermiso(DataRow DR, Permiso P)
        {
            P.ID = int.Parse(DR["ID"].ToString());
            P.Descripcion = DR["Descripcion"].ToString();
            P.TipoDePermiso = new TipoDePermiso();
            P.TipoDePermiso.ID = int.Parse(DR["IDTipoDePermiso"].ToString());
            P.TipoDePermiso.Find();
        }

        int IInternalGeneral<Permiso>.Ultimo(Permiso Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<Permiso>.FindUltimo(Permiso Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<Permiso>.Lista(Permiso Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<Permiso>.ListaP(Permiso Data)
        {
            throw new NotImplementedException();
        }



        #endregion


        #region TipoPermiso

        void IInternalGeneral<TipoDePermiso>.Add(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<TipoDePermiso>.Modify(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<TipoDePermiso>.Erase(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }

        List<TipoDePermiso> IInternalGeneral<TipoDePermiso>.List(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<TipoDePermiso>.Find(TipoDePermiso Data)
        {
            this.CrearComando("TiposDePermiso_Find");
            this.ParametersAddInt("ID", Data.ID);
            DataRow DR = this.Find("Error: No se pudo buscar el tipo de permiso.");
            _CargarTipoDePermiso(DR, Data);
        }

        private void _CargarTipoDePermiso(DataRow DR, TipoDePermiso TP)
        {
            TP.ID = int.Parse(DR["ID"].ToString());
            TP.Descripcion = DR["Descripcion"].ToString();
        }

        int IInternalGeneral<TipoDePermiso>.Ultimo(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<TipoDePermiso>.FindUltimo(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<TipoDePermiso>.Lista(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<TipoDePermiso>.ListaP(TipoDePermiso Data)
        {
            throw new NotImplementedException();
        }



        #endregion


        #region Permiso Usuario

        void IInternalGeneral<PermisoUsuario>.Add(PermisoUsuario Data)
        {
            this.CrearComando("PermisosUsuario_Insert");
            this.ParametersAddInt("IDUsuario", Data.Usuario.ID);
            this.ParametersAddInt("IDPermiso", Data.Permiso.ID);
            this.Insert("Error: No se pudo agregar el permiso de usuario.");
        }

        void IInternalGeneral<PermisoUsuario>.Modify(PermisoUsuario Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<PermisoUsuario>.Erase(PermisoUsuario Data)
        {
            this.CrearComando("PermisosUsuario_Delete");
            this.ParametersAddInt("IDUsuario", Data.Usuario.ID);
            this.ParametersAddInt("IDPermiso", Data.Permiso.ID);
            this.Update("Error: No se pudo eliminar el permiso de usuario.");
        }

        List<PermisoUsuario> IInternalGeneral<PermisoUsuario>.List(PermisoUsuario Data)
        {
            this.CrearComando("PermisosUsuario_List");
            this.ParametersAddInt("IDUsuario", Data.Usuario.ID);
            DataTable DT = this.List("Error: No se pudo listar los permisos de usuario.");
            List<PermisoUsuario> PermisosDeUsuario = new List<PermisoUsuario>();
            foreach (DataRow DR in DT.Rows)
            {
                PermisoUsuario PU = new PermisoUsuario();
                _CargarPermisoDeUsuario(DR, PU);
                PermisosDeUsuario.Add(PU);
            }
            return PermisosDeUsuario;
        }

        private void _CargarPermisoDeUsuario(DataRow DR, PermisoUsuario PU)
        {
            PU.Usuario = new Usuario();
            PU.Usuario.ID = int.Parse(DR["IDUsuario"].ToString());
            PU.Usuario.Find();
            PU.Permiso = new Permiso();
            PU.Permiso.ID = int.Parse(DR["IDPermiso"].ToString());
            PU.Permiso.Find();
        }

        void IInternalGeneral<PermisoUsuario>.Find(PermisoUsuario Data)
        {
            throw new NotImplementedException();
        }

        int IInternalGeneral<PermisoUsuario>.Ultimo(PermisoUsuario Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<PermisoUsuario>.FindUltimo(PermisoUsuario Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<PermisoUsuario>.Lista(PermisoUsuario Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<PermisoUsuario>.ListaP(PermisoUsuario Data)
        {
            throw new NotImplementedException();
        }




        #endregion

        #region Compras
        void IInternalGeneral<Compras>.Add(Compras Data)
        {
            CrearComando("Compras_Insert");
            ParametersAddVarchar("Id", 8, Data.Id);
            ParametersAddInt("Numero", Data.Numero);
            ParametersAddInt("Renglon", Data.Renglon);
            ParametersAddVarchar("Fecha", 10, Data.Fecha);
            ParametersAddVarchar("OrdFecha", 8, Data.OrdFecha);
            ParametersAddInt("Proveedor", Data.Proveedor);
            ParametersAddVarchar("Articulo", 16, Data.Articulo);
            ParametersAddfloat("Cantidad", Data.Cantidad);
            ParametersAddfloat("Costo", Data.Costo);
            ParametersAddVarchar("Observacion", 50, Data.Observacion);
            Data.Numero = Insert("No se pudo ingresar las Compras");
        }

        void IInternalGeneral<Compras>.Modify(Compras Data)
        {
            CrearComando("Compras_Insert");
            ParametersAddVarchar("Id", 8, Data.Id);
            ParametersAddInt("Numero", Data.Numero);
            ParametersAddInt("Renglon", Data.Renglon);
            ParametersAddVarchar("Fecha", 10, Data.Fecha);
            ParametersAddVarchar("OrdFecha", 8, Data.OrdFecha);
            ParametersAddInt("Proveedor", Data.Proveedor);
            ParametersAddVarchar("Articulo", 16, Data.Articulo);
            ParametersAddfloat("Cantidad", Data.Cantidad);
            ParametersAddfloat("Costo", Data.Costo);
            ParametersAddVarchar("Observacion", 50, Data.Observacion);
            this.Update("No se pudo actualizar las Compras " + Data.Numero);
        }

        void IInternalGeneral<Compras>.Erase(Compras Data)
        {
            CrearComando("Compras_Delete");
            ParametersAddVarchar("Id", 8, Data.Id);
            this.Update("No se pudo eliminar el Compras");
        }

        List<Compras> IInternalGeneral<Compras>.List(Compras Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<Compras>.Find(Compras Data)
        {
            CrearComando("Compras_Find");
            ParametersAddVarchar("Id", 8, Data.Id);
            DataRow dr = this.Find("No se encontro el Compras");
            CargarCompras(dr, Data);
        }

        private void CargarCompras(DataRow dr, Compras c)
        {
            c.Id = dr["Clave"].ToString();
            c.Numero = int.Parse(dr["Numero"].ToString());
            c.Renglon = int.Parse(dr["Renglon"].ToString());
            c.Fecha = dr["Fecha"].ToString();
            c.OrdFecha = dr["OrdFecha"].ToString();
            c.Proveedor = int.Parse(dr["Proveedor"].ToString());
            c.Articulo = dr["Articulo"].ToString();
            c.Cantidad = float.Parse(dr["Cantidad"].ToString());
            c.Costo = float.Parse(dr["Costo"].ToString());
            c.Observacion = dr["Observaciones"].ToString();
        }

        int IInternalGeneral<Compras>.Ultimo(Compras Data)
        {
            int Ultimo;
            CrearComando("Compras_FindUltimo");
            DataRow dr = this.Find("No se encontro el numero");
            if (dr[0].ToString() == "")
            {
                Ultimo = 0;
            }
            else
            {
                Ultimo = int.Parse(dr[0].ToString());
            }

            return Ultimo;
        }

        void IInternalGeneral<Compras>.FindUltimo(Compras Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<Compras>.Lista(Compras Data)
        {
            CrearComando("Compras_List");
            DataTable DT = List("No se pudo leer la lista de Compras");
            return DT;
        }

        DataTable IInternalGeneral<Compras>.ListaP(Compras Data)
        {
            throw new NotImplementedException();
        }



        #endregion

        #region Deposito

        void IInternalGeneral<Depositos>.Add(Depositos Data)
        {
            CrearComando("Depositos_Insert");
            ParametersAddVarchar("Id", 8, Data.Id);
            ParametersAddVarchar("Deposito", 6, Data.Deposito);
            ParametersAddVarchar("Renglon", 2, Data.Renglon);
            ParametersAddInt("Banco", Data.Banco);
            ParametersAddVarchar("Fecha", 10, Data.Fecha);
            ParametersAddVarchar("FechaOrd", 10, Data.FechaOrd);
            ParametersAddfloat("Importe", Data.Importe);
            ParametersAddVarchar("AcreditaOrd", 8, Data.AcreditaOrd);
            ParametersAddVarchar("Tipo2", 2, Data.Tipo2);
            ParametersAddVarchar("Numero2", 8, Data.Numero2);
            ParametersAddVarchar("Fecha2", 10, Data.Fecha2);
            ParametersAddfloat("Importe2", Data.Importe2);
            ParametersAddVarchar("Observaciones2", 20, Data.Observaciones2);
            ParametersAddInt("Empresa", Data.Empresa);
            ParametersAddfloat("Impolista", Data.Impolista);
            ParametersAddVarchar("ClaveCheque", 8, Data.ClaveCheque);
            ParametersAddVarchar("ClaveLectora", 31, Data.ClaveLectora);

            
            Data.Banco = Insert("No se pudo ingresar el deposito");
        }

        void IInternalGeneral<Depositos>.Modify(Depositos Data)
        {
            CrearComando("Depositos_Insert");
            ParametersAddVarchar("Id", 8, Data.Id);
            ParametersAddVarchar("Deposito", 6, Data.Deposito);
            ParametersAddVarchar("Renglon", 2, Data.Renglon);
            ParametersAddInt("Banco", Data.Banco);
            ParametersAddVarchar("Fecha", 10, Data.Fecha);
            ParametersAddVarchar("FechaOrd", 10, Data.FechaOrd);
            ParametersAddfloat("Importe", Data.Importe);
            ParametersAddVarchar("AcreditaOrd", 8, Data.AcreditaOrd);
            ParametersAddVarchar("Tipo2", 2, Data.Tipo2);
            ParametersAddVarchar("Numero2", 8, Data.Numero2);
            ParametersAddVarchar("Fecha2", 10, Data.Fecha2);
            ParametersAddfloat("Importe2", Data.Importe2);
            ParametersAddVarchar("Observaciones2", 20, Data.Observaciones2);
            ParametersAddInt("Empresa", Data.Empresa);
            ParametersAddfloat("Impolista", Data.Impolista);
            ParametersAddVarchar("ClaveCheque", 8, Data.ClaveCheque);
            ParametersAddVarchar("ClaveLectora", 31, Data.ClaveLectora);
            this.Update("No se pudo actualizar el repuesto");
        }

        void IInternalGeneral<Depositos>.Erase(Depositos Data)
        {
            CrearComando("Depositos_Delete");
            ParametersAddVarchar("Id", 8, Data.Id);
            this.Update("No se pudo eliminar el deposito");
        }

        List<Depositos> IInternalGeneral<Depositos>.List(Depositos Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<Depositos>.Find(Depositos Data)
        {
            CrearComando("Depositos_Find");
            ParametersAddVarchar("Id", 8, Data.Id);
            DataRow dr = this.Find("No se encontro la factura");
            CargarDepositos(dr, Data);
        }

        private void CargarDepositos(DataRow dr, Depositos c)
        {
            c.Id = dr["Clave"].ToString();
            c.Deposito = dr["Deposito"].ToString();
            c.Renglon = dr["Renglon"].ToString();
            c.Banco = int.Parse(dr["Banco"].ToString());
            c.Fecha = dr["Fecha"].ToString();
            c.FechaOrd = dr["FechaOrd"].ToString();
            c.Importe = float.Parse(dr["Importe"].ToString());
            c.AcreditaOrd = dr["AcreditaOrd"].ToString();
            c.Tipo2 = dr["Tipo2"].ToString();
            c.Numero2 = dr["Numero2"].ToString();
            c.Fecha2 = dr["Fecha2"].ToString();
            c.Importe2 = float.Parse(dr["Importe2"].ToString());
            c.Observaciones2 = dr["Observaciones2"].ToString();
            c.Empresa = int.Parse(dr["Empresa"].ToString());
            c.Impolista = float.Parse(dr["Impolista"].ToString());
            c.ClaveCheque = dr["ClaveCheque"].ToString();
            c.ClaveLectora = dr["ClaveLectora"].ToString();
        }

        int IInternalGeneral<Depositos>.Ultimo(Depositos Data)
        {
            int Ultimo;
            CrearComando("Depositos_FindUltimo");
            DataRow dr = this.Find("No se encontro el numero");
            if (dr[0].ToString() == "")
            {
                Ultimo = 0;
            }
            else
            {
                Ultimo = int.Parse(dr[0].ToString());
            }

            return Ultimo;
        }

        void IInternalGeneral<Depositos>.FindUltimo(Depositos Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<Depositos>.Lista(Depositos Data)
        {
            CrearComando("Depositos_List");
            DataTable DT = List("No se pudo leer la lista de depositos");
            return DT;
        }

        DataTable IInternalGeneral<Depositos>.ListaP(Depositos Data)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Factura
        void IInternalGeneral<Factura>.Add(Factura Data)
        {
            CrearComando("Factura_Insert");
            ParametersAddVarchar("Id", 20, Data.Id);
            ParametersAddVarchar("Letra", 1, Data.Letra);
            ParametersAddInt("Tipo", Data.Tipo);
            ParametersAddVarchar("Punto", 20, Data.Punto);
            ParametersAddVarchar("Factura", 8, Data.factura);
            ParametersAddInt("Renglon", Data.Renglon);
            ParametersAddVarchar("Fecha", 10, Data.Fecha);
            ParametersAddInt("Cliente", Data.Cliente);
            ParametersAddVarchar("Nombre", 50, Data.Nombre);
            ParametersAddVarchar("Direccion", 50, Data.Direccion);
            ParametersAddVarchar("Localidad", 50, Data.Localidad);
            ParametersAddVarchar("Cuit", 20, Data.Cuit);
            ParametersAddVarchar("Remito", 10, Data.Remito);
            ParametersAddVarchar("Descripcion", 50, Data.Descripcion);
            ParametersAddfloat("Importe", Data.Importe);
            ParametersAddfloat("Neto", Data.Neto);
            ParametersAddfloat("Dto", Data.Dto);
            ParametersAddfloat("Neto1", Data.Neto1);
            ParametersAddfloat("Iva1", Data.Iva1);
            ParametersAddfloat("Iva2", Data.Iva2);
            ParametersAddfloat("Total", Data.Total);
            ParametersAddVarchar("Imprepago", 50, Data.Imprepago);
            ParametersAddVarchar("Impre1", 100, Data.Impre1);
            ParametersAddVarchar("Impre2", 100, Data.Impre2);
            ParametersAddVarchar("Condiva", 30, Data.Condiva);
            ParametersAddInt("Item", Data.Item);
            ParametersAddVarchar("Articulo", 25, Data.Articulo);
            ParametersAddfloat("Cantidad", Data.Cantidad);
            ParametersAddfloat("Precio", Data.Precio);
            ParametersAddVarchar("Impre3", 50, Data.Impre3);
            ParametersAddVarchar("Impre4", 50, Data.Impre4);
            ParametersAddfloat("PorceIva", Data.PorceIva);
            ParametersAddfloat("PorceDto", Data.PorceDto);
            ParametersAddVarchar("Cae", 20, Data.Cae);
            ParametersAddVarchar("VtoCae", 20, Data.VtoCae);
            ParametersAddVarchar("ImpreBarra", 50, Data.ImpreBarra);
            ParametersAddVarchar("ImpreBarraII", 50, Data.ImpreBarraII);
            ParametersAddVarchar("ImpreTipo", 2, Data.ImpreTipo);
            ParametersAddVarchar("ImpreNumero", 8, Data.ImpreNumero);
            ParametersAddVarchar("ImpreComprobante", 50, Data.ImpreComprobante);
            ParametersAddVarchar("Descripcion", 100, Data.DescripcionI);
            Data.Tipo = Insert("No se pudo ingresar la Factura");
        }

        void IInternalGeneral<Factura>.Modify(Factura Data)
        {
            CrearComando("Factura_Insert");
            ParametersAddVarchar("Id", 20, Data.Id);
            ParametersAddVarchar("Letra", 1, Data.Letra);
            ParametersAddInt("Tipo", Data.Tipo);
            ParametersAddVarchar("Punto", 20, Data.Punto);
            ParametersAddVarchar("Factura", 8, Data.factura);
            ParametersAddInt("Renglon", Data.Renglon);
            ParametersAddVarchar("Fecha", 10, Data.Fecha);
            ParametersAddInt("Cliente", Data.Cliente);
            ParametersAddVarchar("Nombre", 50, Data.Nombre);
            ParametersAddVarchar("Direccion", 50, Data.Direccion);
            ParametersAddVarchar("Localidad", 50, Data.Localidad);
            ParametersAddVarchar("Cuit", 20, Data.Cuit);
            ParametersAddVarchar("Remito", 10, Data.Remito);
            ParametersAddVarchar("Descripcion", 50, Data.Descripcion);
            ParametersAddfloat("Importe", Data.Importe);
            ParametersAddfloat("Neto", Data.Neto);
            ParametersAddfloat("Dto", Data.Dto);
            ParametersAddfloat("Neto1", Data.Neto1);
            ParametersAddfloat("Iva1", Data.Iva1);
            ParametersAddfloat("Iva2", Data.Iva2);
            ParametersAddfloat("Total", Data.Total);
            ParametersAddVarchar("Imprepago", 50, Data.Imprepago);
            ParametersAddVarchar("Impre1", 100, Data.Impre1);
            ParametersAddVarchar("Impre2", 100, Data.Impre2);
            ParametersAddVarchar("Condiva", 30, Data.Condiva);
            ParametersAddInt("Item", Data.Item);
            ParametersAddVarchar("Articulo", 25, Data.Articulo);
            ParametersAddfloat("Cantidad", Data.Cantidad);
            ParametersAddfloat("Precio", Data.Precio);
            ParametersAddVarchar("Impre3", 50, Data.Impre3);
            ParametersAddVarchar("Impre4", 50, Data.Impre4);
            ParametersAddfloat("PorceIva", Data.PorceIva);
            ParametersAddfloat("PorceDto", Data.PorceDto);
            ParametersAddVarchar("Cae", 20, Data.Cae);
            ParametersAddVarchar("VtoCae", 20, Data.VtoCae);
            ParametersAddVarchar("ImpreBarra", 50, Data.ImpreBarra);
            ParametersAddVarchar("ImpreBarraII", 50, Data.ImpreBarraII);
            ParametersAddVarchar("ImpreTipo", 2, Data.ImpreTipo);
            ParametersAddVarchar("ImpreNumero", 8, Data.ImpreNumero);
            ParametersAddVarchar("ImpreComprobante", 50, Data.ImpreComprobante);
            ParametersAddVarchar("Descripcion", 100, Data.DescripcionI);
            this.Update("No se pudo actualizar la Factura " + Data.Tipo);
        }

        void IInternalGeneral<Factura>.Erase(Factura Data)
        {
            CrearComando("Factura_Delete");
            ParametersAddVarchar("Id", 8, Data.Id);
            this.Update("No se pudo eliminar el Compras");
        }

        List<Factura> IInternalGeneral<Factura>.List(Factura Data)
        {
            throw new NotImplementedException();
        }

        void IInternalGeneral<Factura>.Find(Factura Data)
        {
            CrearComando("Factura_Find");
            ParametersAddVarchar("Id", 8, Data.Id);
            DataRow dr = this.Find("No se encontro el Compras");
            CargarFactura(dr, Data);
        }

        private void CargarFactura(DataRow dr, Factura c)
        {
            c.Id = dr["Clave"].ToString();
            c.Letra = dr["Letra"].ToString();
            c.Tipo = int.Parse(dr["Tipo"].ToString());
            c.Punto = dr["Punto"].ToString();
            c.factura = dr["factura"].ToString();
            c.Renglon = int.Parse(dr["Renglon"].ToString());
            c.Fecha = dr["Fecha"].ToString();
            c.Cliente = int.Parse(dr["Cliente"].ToString());
            c.Nombre = dr["Nombre"].ToString();
            c.Direccion = dr["Direccion"].ToString();
            c.Localidad = dr["Localidad"].ToString();
            c.Cuit = dr["Cuit"].ToString();
            c.Remito = dr["Remito"].ToString();
            c.Descripcion = dr["Descripcion"].ToString();
            c.Importe = float.Parse(dr["Importe"].ToString());
            c.Neto = float.Parse(dr["Neto"].ToString());
            c.Dto = float.Parse(dr["Dto"].ToString());
            c.Neto1 = float.Parse(dr["Neto1"].ToString());
            c.Iva1 = float.Parse(dr["Iva1"].ToString());
            c.Iva2 = float.Parse(dr["Iva2"].ToString());
            c.Total = float.Parse(dr["Total"].ToString());
            c.Imprepago = dr["Imprepago"].ToString();
            c.Impre1 = dr["Impre1"].ToString();
            c.Impre2 = dr["Impre2"].ToString();
            c.Condiva = dr["Condiva"].ToString();
            c.Item = int.Parse(dr["Item"].ToString());
            c.Articulo = dr["Articulo"].ToString();
            c.Cantidad = float.Parse(dr["Cantidad"].ToString());
            c.Precio = float.Parse(dr["Precio"].ToString());
            c.Impre3 = dr["Impre3"].ToString();
            c.Impre4 = dr["Impre4"].ToString();
            c.PorceIva = float.Parse(dr["PorceIva"].ToString());
            c.PorceDto = float.Parse(dr["PorceDto"].ToString());
            c.Cae = dr["Cae"].ToString();
            c.VtoCae = dr["VtoCae"].ToString();
            c.ImpreBarra = dr["ImpreBarra"].ToString();
            c.ImpreBarraII = dr["ImpreBarraII"].ToString();
            c.ImpreTipo = dr["ImpreTipo"].ToString();
            c.ImpreNumero = dr["ImpreNumero"].ToString();
            c.ImpreComprobante = dr["ImpreComprobante"].ToString();
            c.DescripcionI = dr["DescripcionI"].ToString();
        }


        int IInternalGeneral<Factura>.Ultimo(Factura Data)
        {
            int Ultimo;
            CrearComando("Factura_FindUltimo");
            DataRow dr = this.Find("No se encontro el numero");
            if (dr[0].ToString() == "")
            {
                Ultimo = 0;
            }
            else
            {
                Ultimo = int.Parse(dr[0].ToString());
            }

            return Ultimo;
        }

        void IInternalGeneral<Factura>.FindUltimo(Factura Data)
        {
            throw new NotImplementedException();
        }

        DataTable IInternalGeneral<Factura>.Lista(Factura Data)
        {
            CrearComando("Factura_List");
            DataTable DT = List("No se pudo leer la lista de Compras");
            return DT;
        }

        DataTable IInternalGeneral<Factura>.ListaP(Factura Data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
