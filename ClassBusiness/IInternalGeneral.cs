using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassBussines
{
    internal interface IInternalGeneral<T>
    {
        void Add(T Data);
        void Modify(T Data);
        void Erase(T Data);
        List<T> List(T Data);
        void Find(T Data);
        int Ultimo(T Data);
        void FindUltimo(T Data);
        DataTable Lista(T Data);
        DataTable ListaP(T Data);
        


        
    }
}
