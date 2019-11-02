using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassBussines
{
    internal interface IInternalRemito<T> : IInternalGeneral<T>
      
    {

        int UltimoRemito(T Data);
        DataTable ListaFecha(T Data);
        DataTable ListaVendedor(T Data);
    }
}
