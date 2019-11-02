using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassBussines
{
    public interface IListas<T> : IGeneral<T>
    {
        DataTable ListaPedidoFecha();
    }
}
