using System;
using System.Collections.Generic;

using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ClassBussines
{
    public class Depositos : IGeneral<Depositos>
    {
        IInternalGeneral<Depositos> IG = SingletonFasade.GetInstance;
        //IInternalGeneral<Cliente> IGC = SingletonFasade.GetInstance;

        private string _Id;

        public string Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        private string _Deposito;

        public string Deposito
        {
            set { _Deposito = value; }
            get { return _Deposito; }
        }

        private string _Renglon;

        public string Renglon
        {
            set { _Renglon = value; }
            get { return _Renglon; }
        }

        private int _Banco;

        public int Banco
        {
            set { _Banco = value; }
            get { return _Banco; }
        }

        private string _Fecha;

        public string Fecha
        {
            set { _Fecha = value; }
            get { return _Fecha; }
        }

        private string _FechaOrd;

        public string FechaOrd
        {
            set { _FechaOrd = value; }
            get { return _FechaOrd; }
        }

        private float _Importe;

        public float Importe
        {
            set { _Importe = value; }
            get { return _Importe; }

        }

        private string _AcreditaOrd;

        public string AcreditaOrd
        {
            set { _AcreditaOrd = value; }
            get { return _AcreditaOrd; }
        }

        private string _Tipo2;
        public string Tipo2
        {
            set { _Tipo2 = value; }
            get { return _Tipo2; }
        }

        private string _Numero2;

        public string Numero2
        {
            set { _Numero2 = value; }
            get { return _Numero2; }
        }

        private string _Fecha2;

        public string Fecha2
        {
            set { _Fecha2 = value; }
            get { return _Fecha2; }
        }

        private float _Importe2;
        public float Importe2
        {
            set { _Importe2 = value; }
            get { return _Importe2; }
        }

        private string _Observaciones2;

        public string Observaciones2
        {
            set { _Observaciones2 = value; }
            get { return _Observaciones2; }
        }

        private int _Empresa;

        public int Empresa
        {
            set { _Empresa = value; }
            get { return _Empresa; }
        }

        private float _Impolista;
        public float Impolista
        {
            set { _Impolista = value; }
            get { return _Impolista; }
        }

        private string _ClaveCheque;

        public string ClaveCheque
        {
            set { _ClaveCheque = value; }
            get { return _ClaveCheque; }
        }

        private string _ClaveLectora;

        public string ClaveLectora
        {
            set { _ClaveLectora = value; }
            get { return _ClaveLectora; }
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

        public List<Depositos> List()
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
