using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<TKey, Tvalue>
    {

        TKey[] keyarray, tempkeyarray;
        Tvalue[] valuearray, tempvaluearray;

        public MyDictionary()
        {
            keyarray = new TKey[0];
            valuearray = new Tvalue[0];

        }



        public void Add(TKey key, Tvalue value)
        {
            tempkeyarray = keyarray;
            tempvaluearray = valuearray;

            keyarray = new TKey[keyarray.Length + 1];
            valuearray = new Tvalue[valuearray.Length + 1];

            for (int i = 0; i < tempkeyarray.Length; i++)
            {
                keyarray[i] = tempkeyarray[i];
            }

            for (int i = 0; i < tempvaluearray.Length; i++)
            {
                valuearray[i] = tempvaluearray[i];
            }

            keyarray[keyarray.Length - 1] = key;
            valuearray[valuearray.Length - 1] = value;

            Console.WriteLine(keyarray[keyarray.Length - 1]);
            Console.WriteLine(valuearray[valuearray.Length - 1]);

        }


    }
}
