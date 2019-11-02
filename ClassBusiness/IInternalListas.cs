using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassBussines
{
    internal interface IInternalListas<T>:IInternalGeneral<T>
    {
        DataTable ListaPedidoFecha(T Data);
        DataTable ListaCliente(T Data);
    }
}
