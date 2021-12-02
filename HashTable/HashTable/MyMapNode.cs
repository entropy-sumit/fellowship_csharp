using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_HashTable
{
    class MyMapNode<K, V>
    {
        private readonly int _size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this._size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % _size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
        }

        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        public int GetFrequencyOfWords(V value)
        {
            int count = 0;
            if (items == null)
            {
                Console.WriteLine("Hash Table is Empty!");
                return 0;
            }
            for (int i = 0; i < items.Length; i++)
            {
                LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(i);
                foreach (KeyValue<K, V> item in linkedList)
                {
                    if (item.value.Equals(value))
                        count++;
                }
            }
            return count;
        }

        public struct KeyValue<Ke, Va>
        {
            public Ke key { get; set; }
            public Va value { get; set; }
        }
