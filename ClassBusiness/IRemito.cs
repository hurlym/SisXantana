using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassBussines
{
    

    public interface IRemito<T> : IGeneral<T>
    {

        int UltimoRemito(T Data);
        DataTable ListaFecha(T Data);
        DataTable ListaVendedor(T Data);
    }
}
