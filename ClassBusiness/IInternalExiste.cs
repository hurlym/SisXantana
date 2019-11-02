using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBussines
{
    internal interface IInternalExiste<T>:IInternalGeneral<T>
    {
        int Exists(T Data);
    }
}
