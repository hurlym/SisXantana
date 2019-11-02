using System;
using System.Collections.Generic;
using System.Data;

namespace ClassBussines
{
    public class TipoDePermiso : IGeneral<TipoDePermiso>
    {
        public const int MODULO = 1;
        public const int REPORTE = 2;
        public const int REGISTRO = 3;
        public const int RUTINA = 4;
        IInternalGeneral<TipoDePermiso> ITP = SingletonFasade.GetInstance;
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public void Add() { throw new NotImplementedException(); }
        public void AddOnline() { throw new NotImplementedException(); }
        public void Erase() { throw new NotImplementedException(); }
        public void Erase2() { throw new NotImplementedException(); }
        public void Find() { ITP.Find(this); }
        public void FindUltimo() { throw new NotImplementedException(); }
        public List<TipoDePermiso> List() { throw new NotImplementedException(); }
        public DataTable Lista() { throw new NotImplementedException(); }
        public DataTable Lista1() { throw new NotImplementedException(); }
        public DataTable Lista2() { throw new NotImplementedException(); }
        public DataTable Lista3() { throw new NotImplementedException(); }
        public DataTable Lista4() { throw new NotImplementedException(); }
        public void Modify() { throw new NotImplementedException(); }
        public int Ultimo() { throw new NotImplementedException(); }
        public bool isModule() { return this.ID == MODULO; }
        public bool isReport() { return this.ID == REPORTE; }
        public bool isRecord() { return this.ID == REGISTRO; }
        public bool isRoutine() { return this.ID == RUTINA; }
    }
}
