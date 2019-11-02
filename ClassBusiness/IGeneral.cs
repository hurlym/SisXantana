using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace ClassBussines
{
    public interface IGeneral<T>
    {
        void Add();
        void AddOnline();
        void Modify();
        void Erase();
        void Erase2();
        List<T> List();
        void Find();
        int Ultimo();
        void FindUltimo();
        DataTable Lista();
        DataTable Lista1();
        DataTable Lista2();
        DataTable Lista3();
        DataTable Lista4();

    }
}

