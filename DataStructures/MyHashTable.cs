using System.Collections;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace MyHashTable
{
    public class HashTableNode<T, K>
    {
        
        public K Key { get; set; }
        public T Value { get; set; }
        public HashTableNode(K key, T value) 
        {
            Key = key;
            Value = value;
        }
    }


    public class MyHashTable< T, K > : IEnumerable<HashTableNode<T, K>>
    {
        public int LengthMyHashTable { get; private set; }
        private HashTableNode<T, K>[] _hashTableNodes;

        //Получает или задает значение, связанное с указанным ключом.
        public T this[K key] { get => GetValue(key); set { Put(key: key, value: value); } }

        public MyHashTable(int length = 1000) 
        {
            LengthMyHashTable = length;
            _hashTableNodes = new HashTableNode<T, K>[LengthMyHashTable];
        }
        //Hash fanction algorithm
        /* Обязателние условии хеш функции:
         * 1-Постоянство -> Должно возвращать один и тот же hаsh при передачи одинаковий ключ
         * 2-Не уникально -> Избежать коллизии(При передачи разные ключи получить одино hash)
         * 3-Равномерность -> Распределять по длину массива
         * 4-Быстрота -> Должно работать быстро
         * Аз ман хер кор мекунад :)
         */
        private int GetHashCode(K key) => Math.Abs(key.GetHashCode() % LengthMyHashTable);
        //Добавляет элемент с указанным ключом и значением в Hashtable.
        public void Put(T value, K key)
        {
            if (LengthMyHashTable == 0)
                return;
            var hashCodeKey = GetHashCode(key);
            var valueHashTayble = _hashTableNodes[hashCodeKey];
            if (valueHashTayble is null)
            {
                _hashTableNodes[hashCodeKey] = new HashTableNode<T, K>(key: key, value: value);
                return;
            }
            if (valueHashTayble.Key is not null && valueHashTayble.Key.Equals(key))
            {
                valueHashTayble.Value = value;
                return;
            }
        }
        //Получить значение по ключ.
        public T GetValue(K key)
        {
            if (LengthMyHashTable == 0)
                return default;
            var hashCodeKey = GetHashCode(key);
            var valueHashTayble = _hashTableNodes[hashCodeKey];
            if (valueHashTayble is null)
                return default;
            if(valueHashTayble.Key.Equals(key))
                return valueHashTayble.Value;
            return default;
        }
        //Удаляет все элементы из Hashtable.
        public void Claer()
        {
            _hashTableNodes = null;
            LengthMyHashTable = 0;
        }
        //Создает поверхностную копию Hashtable.
        public HashTableNode<T, K>[] Clone()
        {
            return _hashTableNodes;
        }
        //Определяет, содержит ли Hashtable определенный ключ.
        public bool Contains(K key)
        {
            var hashCodeKey = GetHashCode(key);
            var valueHashTable  = _hashTableNodes[hashCodeKey];
            if (valueHashTable.Key.Equals(key))
                return true;
            return false;
        }
        //Определяет, содержит ли Hashtable определенное значение.
        public bool ContainsValue(T value)
        {
            if(value is null)
                return false;
            foreach (var item in _hashTableNodes)
            {
                if(item.Value is not null && item.Value.Equals(value))
                    return true;
            }
            return false;
        }



        
        public IEnumerator<HashTableNode<T, K>> GetEnumerator()
        {
            foreach(var item in _hashTableNodes)
                    yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
