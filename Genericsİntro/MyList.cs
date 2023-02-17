using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    class MyList<T>
    {
        T[] items = new T[0];

        public MyList()
        {
                T[] tempitem = items;
        }

        public void Add(T item)
        {

            T[] tempitem = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempitem.Length; i++)
            {

                items[i] = tempitem[i];

            }

            items[items.Length - 1] = item;
        }





    }
}
