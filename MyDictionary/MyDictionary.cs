using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey, TValue>
    {
        Tkey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new TValue[0];
        }
        public void Add(Tkey key,TValue value)
        {
            Tkey[] tempKey = keys;
            TValue[] tempValue = values;
            keys = new Tkey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
  }
        public int Length { get { return keys.Length; } }

        public Tkey[] Items { get { return keys; } }
        public TValue[] Items1 { get { return values; } }
    }
}