using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ClassBussines
{
    public class Factura : IGeneral<Factura>
    {
        IInternalGeneral<Factura> IG = SingletonFasade.GetInstance;
        //IInternalGeneral<Cliente> IGC = SingletonFasade.GetInstance;

        private string _Id;

        public string Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        private string _Letra;

        public string Letra
        {
            set { _Letra = value; }
            get { return _Letra; }
        }

        private int _Tipo;

        public int Tipo
        {
            set { _Tipo = value; }
            get { return _Tipo; }
        }

        private string _Punto;

        public string Punto
        {
            set { _Punto = value; }
            get { return _Punto; }
        }

        private string _factura;

        //no puede tener el mismo nombre de la clase
        public string factura
        {
            set { _factura = value; }
            get { return _factura; }
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

        private int _Cliente;

        public int Cliente
        {
            set { _Cliente = value; }
            get { return _Cliente; }
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

        private string _Cuit;
        public string Cuit
        {
            set { _Cuit = value; }
            get { return _Cuit; }
        }

        private string _Remito;
        public string Remito
        {
            set { _Remito = value; }
            get { return _Remito; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            set { _Descripcion = value; }
            get { return _Descripcion; }
        }

        private float _Importe;
        public float Importe
        {
            set { _Importe = value; }
            get { return _Importe; }
        }

        private float _Neto;
        public float Neto
        {
            set { _Neto = value; }
            get { return _Neto; }
        }

        private float _Dto;
        public float Dto
        {
            set { _Dto = value; }
            get { return _Dto; }
        }

        private float _Neto1;
        public float Neto1
        {
            set { _Neto1 = value; }
            get { return _Neto1; }
        }

        private float _Iva1;
        public float Iva1
        {
            set { _Iva1 = value; }
            get { return _Iva1; }
        }

        private float _Iva2;
        public float Iva2
        {
            set { _Iva2 = value; }
            get { return _Iva2; }
        }

        private float _Total;
        public float Total
        {
            set { _Total = value; }
            get { return _Total; }
        }

        private string _Imprepago;
        public string Imprepago
        {
            set { _Imprepago = value; }
            get { return _Imprepago; }
        }

        private string _Impre1;
        public string Impre1
        {
            set { _Impre1 = value; }
            get { return _Impre1; }
        }

        private string _Impre2;
        public string Impre2
        {
            set { _Impre2 = value; }
            get { return _Impre2; }
        }

        private string _Condiva;
        public string Condiva
        {
            set { _Condiva = value; }
            get { return _Condiva; }
        }

        private int _Item;
        public int Item
        {
            set { _Item = value; }
            get { return _Item; }
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

        private float _Precio;
        public float Precio
        {
            set { _Precio = value; }
            get { return _Precio; }
        }

        private string _Impre3;
        public string Impre3
        {
            set { _Impre3 = value; }
            get { return _Impre3; }
        }

        private string _Impre4;
        public string Impre4
        {
            set { _Impre4 = value; }
            get { return _Impre4; }
        }

        private float _PorceIva;
        public float PorceIva
        {
            set { _PorceIva = value; }
            get { return _PorceIva; }
        }

        private float _PorceDto;
        public float PorceDto
        {
            set { _PorceDto = value; }
            get { return _PorceDto; }
        }

        private string _Cae;
        public string Cae
        {
            set { _Cae = value; }
            get { return _Cae; }
        }

        private string _VtoCae;
        public string VtoCae
        {
            set { _VtoCae = value; }
            get { return _VtoCae; }
        }

        private string _ImpreBarra;
        public string ImpreBarra
        {
            set { _ImpreBarra = value; }
            get { return _ImpreBarra; }
        }

        private string _ImpreBarraII;
        public string ImpreBarraII
        {
            set { _ImpreBarraII = value; }
            get { return _ImpreBarraII; }
        }

        private string _ImpreTipo;
        public string ImpreTipo
        {
            set { _ImpreTipo = value; }
            get { return _ImpreTipo; }
        }

        private string _ImpreNumero;
        public string ImpreNumero
        {
            set { _ImpreNumero = value; }
            get { return _ImpreNumero; }
        }

        private string _ImpreComprobante;
        public string ImpreComprobante
        {
            set { _ImpreComprobante = value; }
            get { return _ImpreComprobante; }
        }

        private string _DescripcionI;
        public string DescripcionI
        {
            set { _DescripcionI = value; }
            get { return _DescripcionI; }
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

        public List<Factura> List()
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
