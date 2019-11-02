using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBussines
{
    internal interface IInternalCliente<T> : IInternalGeneral<T>
    {
        void ModifySaldo(T Data);
        void ModifyUltVenta(T Data);
    }
}
