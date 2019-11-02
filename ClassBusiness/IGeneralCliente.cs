using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBussines
{
    public interface IGeneralCliente<T> :IGeneral<T>
    {
        void ModifySaldo();
        void ModifyUltVenta();
    }
}
