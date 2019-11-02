using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBussines
{
    public class Cliente : IGeneralCliente<Cliente>
    {
        IInternalGeneral<Cliente> IG = SingletonFasade.GetInstance;
        //IInternalGeneral<Cliente> IGC = SingletonFasade.GetInstance;

        private int _Id;

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        private string _Nombre;

        public string Nombre
        {
            set { _Nombre = value; }
            get { return _Nombre; }
        }

        private string _Direccion;

        public string Direccion
        {
            set { _Direccion = value; }
            get { return _Direccion; }
        }

        private string _Localidad;

        public string Localidad
        {
            set { _Localidad = value; }
            get { return _Localidad; }
        }

        private int  _Provincia;

        public int Provincia
        {
            set { _Provincia = value; }
            get { return _Provincia; }
        }

        private int _CP;

        public int CP
        {
            set { _CP = value; }
            get { return _CP; }

        }

        private string _Mail;

        public string Mail
        {
            set { _Mail = value; }
            get { return _Mail; }
        }


        private string _Telef;

        public string Telef
        {
            set { _Telef = value; }
            get { return _Telef; }
        }

        private string _NFiscal;

        public string NFiscal
        {
            set { _NFiscal = value; }
            get { return _NFiscal; }
        }

        private string _Observ;

        public string Observ
        {
            set { _Observ = value; }
            get { return _Observ; }
        }


        private int _IVA;

        public int IVA
        {
            set { _IVA = value; }
            get { return _IVA; }
        }


        private int _CodEmpresa;

        public int CodEmpresa
        {
            set { _CodEmpresa = value; }
            get { return _CodEmpresa; }
        }


        private int _Vendedor;

        public int Vendedor
        {
            set { _Vendedor = value; }
            get { return _Vendedor; }

        }

        private string _Expreso;

        public string Expreso
        {
            set { _Expreso = value; }
            get { return _Expreso; }
        }


        private string _UltimaCompra;

        public string UltimaCompra
        {
            set { _UltimaCompra = value; }
            get { return _UltimaCompra; }
        }

        private int _NumLista;

        public int NumLista
        {
            set { _NumLista = value; }
            get { return _NumLista; }

        }

        private int _Condicion;

        public int Condicion
        {
            set { _Condicion = value; }
            get { return _Condicion; }

        }

        private int _Tipo;

        public int Tipo
        {
            set { _Tipo = value; }
            get { return _Tipo; }

        }


        private string _Fantasia;

        public string Fantasia
        {
            set { _Fantasia = value; }
            get { return _Fantasia; }
        }


        private string _DireccionEnvio;

        public string DireccionEnvio
        {
            set { _DireccionEnvio = value; }
            get { return _DireccionEnvio; }
        }


        private string _FechaAlta;

        public string FechaAlta
        {
            set { _FechaAlta = value; }
            get { return _FechaAlta; }
        }

        private string _NombreContI;

        public string NombreContI
        {
            set { _NombreContI = value; }
            get { return _NombreContI; }
        }

        private string _TelefContI;

        public string TelefContI
        {
            set { _TelefContI = value; }
            get { return _TelefContI; }
        }

        private string _EmailContI;

        public string EmailContI
        {
            set { _EmailContI = value; }
            get { return _EmailContI; }
        }


        private string _CargoContI;

        public string CargoContI
        {
            set { _CargoContI = value; }
            get { return _CargoContI; }
        }



        private string _NombreContII;

        public string NombreContII
        {
            set { _NombreContII = value; }
            get { return _NombreContII; }
        }

        private string _TelefContII;

        public string TelefContII
        {
            set { _TelefContII = value; }
            get { return _TelefContII; }
        }

        private string _EmailContII;

        public string EmailContII
        {
            set { _EmailContII = value; }
            get { return _EmailContII; }
        }

        private string _CargoContII;

        public string CargoContII
        {
            set { _CargoContII = value; }
            get { return _CargoContII; }
        }



        private string _NombreContIII;

        public string NombreContIII
        {
            set { _NombreContIII = value; }
            get { return _NombreContIII; }
        }

        private string _TelefContIII;

        public string TelefContIII
        {
            set { _TelefContIII = value; }
            get { return _TelefContIII; }
        }

        private string _EmailContIII;

        public string EmailContIII
        {
            set { _EmailContIII = value; }
            get { return _EmailContIII; }
        }

        private string _CargoContIII;

        public string CargoContIII
        {
            set { _CargoContIII = value; }
            get { return _CargoContIII; }
        }


        private string _Consulta;

        public string Consulta
        {
            set { _Consulta = value; }
            get { return _Consulta; }
        }




        private float _Descuento;

        public float Descuento
        {
            set { _Descuento = value; }
            get { return _Descuento; }

        }

        private int _CreditoCC;

        public int CreditoCC
        {
            set { _CreditoCC = value; }
            get { return _CreditoCC; }

        }

        private float _DeudaCC;

        public float DeudaCC
        {
            set { _DeudaCC = value; }
            get { return _DeudaCC; }

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

        public List<Cliente> List()
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
