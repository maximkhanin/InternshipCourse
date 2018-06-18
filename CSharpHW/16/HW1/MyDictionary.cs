using System;
using System.Linq;

namespace HW1
{
    class MyDictionary<TKey, TValue>
    {
        private int _counter;
        private TKey[] _keys = new TKey[0];
        private TValue[] _values = new TValue[0];

        public int Counter()
        {
            return _counter;
        }

        public void Add(TKey key, TValue value)
        {
            if (!(_keys.Contains(key)))
            {
                _counter++;

                Array.Resize(ref _keys, _counter);
                _keys[_counter - 1] = key;

                Array.Resize(ref _values, _counter);
                _values[_counter - 1] = value;
            }
        }


        public void Remove(TKey key, TValue value)
        {
            var flag = false;
            var tmpKeys = new TKey[_keys.Length - 1];
            var tmpValues = new TValue[_values.Length - 1];
            var i = 0;
            var k = 0;

            while (i < _keys.Length)
            {
                if (!(_keys[i].Equals(key) && _values[i].Equals(value)))
                {
                    tmpKeys[k] = _keys[i];
                    tmpValues[k] = _values[i];
                    k += 1;
                    flag = true;
                }
                i += 1;
            }

            if (flag)
            {

                _keys = tmpKeys;
                _values = tmpValues;
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                var index = 0;

                for (var i = 0; i < _keys.Length; i++)
                {
                    if (key.Equals(_keys[i]))
                        index = i;
                }

                return _values[index];
            }
        }

        public override string ToString()
        {
            var str = "";

            for (var i = 0; i < _keys.Length; i++)
            {
                str += "Key - " + _keys[i] + "; Value - " + _values[i] + '\n';
            }

            return str;
        }
    }
}
