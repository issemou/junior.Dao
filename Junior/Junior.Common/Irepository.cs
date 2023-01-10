using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior.Common
{
    public interface IRepository<T>
    {
        void Add(T t);
        T Set(T t);
        T Get(int id);

        IEnumerable<T> Find(T t);
        T Delete(T t);

    }
}
