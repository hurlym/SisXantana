using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ClassBussines
{
    public class Compras : IGeneral<Compras>
    {
        IInternalGeneral<Compras> IG = SingletonFasade.GetInstance;
        //IInternalGeneral<Cliente> IGC = SingletonFasade.GetInstance;

        private string _Id;

        public string Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        private int _Numero;

        public int Numero
        {
            set { _Numero = value; }
            get { return _Numero; }
        }

        private int _Renglon;

        public int Renglon
        {
            set { _Renglon = value; }
            get { return _Renglon; }
        }

        private string _Fecha;

        public string Fecha
        {
            set { _Fecha = value; }
            get { return _Fecha; }
        }

        private string _OrdFecha;

        public string OrdFecha
        {
            set { _OrdFecha = value; }
            get { return _OrdFecha; }
        }

        private int _Proveedor;

        public int Proveedor
        {
            set { _Proveedor = value; }
            get { return _Proveedor; }
        }

        private string _Articulo;

        public string Articulo
        {
            set { _Articulo = value; }
            get { return _Articulo; }

        }

        private float _Cantidad;

        public float Cantidad
        {
            set { _Cantidad = value; }
            get { return _Cantidad; }
        }


        private float _Costo;

        public float Costo
        {
            set { _Costo = value; }
            get { return _Costo; }
        }

        private string _Observacion;

        public string Observacion
        {
            set { _Observacion = value; }
            get { return _Observacion; }
        }

        public void Add()
        {
            IG.Add(this);
        }

        public void Modify()
        {
            IG.Modify(this);
        }

        public void Erase()
        {
            IG.Erase(this);
        }

        public List<Compras> List()
        {
            return IG.List(this);
        }

        public void Find()
        {
            IG.Find(this);
        }

        public int Ultimo()
        {
            return IG.Ultimo(this); ;
        }

        public void FindUltimo()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable Lista()
        {
            return IG.Lista(this);
        }

        public System.Data.DataTable ListaP()
        {
            return IG.ListaP(this);
        }

        public int UltimoTipo()
        {
            return IG.Ultimo(this);
        }

        public void ModifySaldo()
        {
            IG.FindUltimo(this);
        }

        public void ModifyUltVenta()
        {
            throw new NotImplementedException();
        }

        public void AddOnline()
        {
            throw new NotImplementedException();
        }

        public void Erase2()
        {
            throw new NotImplementedException();
        }

        public DataTable Lista1()
        {
            throw new NotImplementedException();
        }

        public DataTable Lista2()
        {
            throw new NotImplementedException();
        }

        public DataTable Lista3()
        {
            throw new NotImplementedException();
        }

        public DataTable Lista4()
        {
            throw new NotImplementedException();
        }
    }
}
