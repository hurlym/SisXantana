using System;
using System.Collections.Generic;
using System.Data;

namespace ClassBussines
{
    public class Permiso : IGeneral<Permiso>
    {
        IInternalGeneral<Permiso> IP = SingletonFasade.GetInstance;
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public TipoDePermiso TipoDePermiso { get; set; }
        public List<Permiso> List() { return IP.List(this); }
        public void Find() { IP.Find(this); }
        public void Add() { throw new NotImplementedException(); }
        public void AddOnline() { throw new NotImplementedException(); }
        public void Erase() { throw new NotImplementedException(); }
        public void Erase2() { throw new NotImplementedException(); }
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
