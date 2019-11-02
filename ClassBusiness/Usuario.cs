using System;
using System.Collections.Generic;
using System.Data;

namespace ClassBussines
{
    public class Usuario : IGeneral<Usuario>
    {
        #region Propiedades
        IInternalGeneral<Usuario> IU = SingletonFasade.GetInstance;
        public int ID { get; set; }
        public string Directory { get; set; }
        public string Prefix { get; set; }
        public string Path { get; set; }
        public string Apodo { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public bool Cerrado { get; set; }
        public int Sucursal { get; set; }
        public List<Permiso> Permisos = new List<Permiso>();
        #endregion

        #region Metodos
        public void Add() { IU.Add(this); }
        public void Erase() { IU.Erase(this); }
        public void Find() { IU.Find(this); }
        public List<Usuario> List() { return IU.List(this); }
        public void Modify() { IU.Modify(this); }
        public Usuario LogIn()
        {
            List<Usuario> Usuarios = this.List();
            foreach (Usuario U in Usuarios)
            {
                if (U.Clave == this.Clave && (U.Apodo == this.Apodo || U.Email == this.Apodo))
                {
                    return U;
                }
            }
            throw new Exception("La combinación de usuario y clave no existe.");
        }
        public void CargarPermisos()
        {
            PermisoUsuario PermisoUsuario = new PermisoUsuario();
            PermisoUsuario.Usuario = new Usuario();
            PermisoUsuario.Usuario.ID = this.ID;
            List<PermisoUsuario> PermisosUsuario = PermisoUsuario.List();
            foreach (PermisoUsuario P in PermisosUsuario)
            {
                Permisos.Add(P.Permiso);
            }
        }
        public void EliminarPermisos()
        {
            foreach (Permiso P in Permisos)
            {
                PermisoUsuario PU = new PermisoUsuario();
                PU.Usuario = this;
                PU.Permiso = P;
                PU.Erase();
            }
        }
        public bool TienePermiso(string NombreDePermiso)
        {
            foreach (Permiso P in Permisos)
            {
                if (P.Descripcion == NombreDePermiso)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region NoImplementado
        public int Ultimo() { throw new NotImplementedException(); }
        public DataTable Lista() { throw new NotImplementedException(); }
        public DataTable Lista1() { throw new NotImplementedException(); }
        public DataTable Lista2() { throw new NotImplementedException(); }
        public DataTable Lista3() { throw new NotImplementedException(); }
        public DataTable Lista4() { throw new NotImplementedException(); }
        public void FindUltimo() { throw new NotImplementedException(); }
        public void Erase2() { throw new NotImplementedException(); }
        public void AddOnline() { throw new NotImplementedException(); }
        #endregion

    }
}
