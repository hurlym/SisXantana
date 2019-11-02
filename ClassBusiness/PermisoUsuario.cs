using System;
using System.Collections.Generic;
using System.Data;

namespace ClassBussines
{
    public class PermisoUsuario : IGeneral<PermisoUsuario>
    {
        IInternalGeneral<PermisoUsuario> IPU = SingletonFasade.GetInstance;
        public Usuario Usuario { get; set; }
        public Permiso Permiso { get; set; }
        public List<PermisoUsuario> List() { return IPU.List(this); }
        public void Add() { IPU.Add(this); }
        public void AddOnline() { throw new NotImplementedException(); }
        public void Erase() { IPU.Erase(this); }
        public void Erase2() { throw new NotImplementedException(); }
        public void Find() { throw new NotImplementedException(); }
        public void FindUltimo() { throw new NotImplementedException(); }
        public DataTable Lista() { throw new NotImplementedException(); }
        public DataTable Lista1() { throw new NotImplementedException(); }
        public DataTable Lista2() { throw new NotImplementedException(); }
        public DataTable Lista3() { throw new NotImplementedException(); }
        public DataTable Lista4() { throw new NotImplementedException(); }
        public void Modify() { throw new NotImplementedException(); }
        public int Ultimo() { throw new NotImplementedException(); }
    }
}
