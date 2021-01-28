using System.Collections.Generic;

namespace Algo
{
    public class MyHashTable
    {
        private Node[] data;
        public MyHashTable(int size)
        {
            data = new Node[size];
        }

        private int _hash(string key)
        {
            var hash = 0;
            var chars = key.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                hash = (hash + (int)chars[i] * i) % this.data.Length;
            }
            return hash;
        }

        public void Set(string key, object val)
        {
            var index = _hash(key);
            if (this.data[index] != null)
            {
                var currentNode = this.data[index];
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new Node(new KVP { Key = key, Value = val });
            }
            else
            {
                this.data[index] = new Node(new KVP { Key = key, Value = val });
            }
        }

        public List<string> Keys()
        {
            var result = new List<string>();

            for (int i = 0; i < this.data.Length; i++)
            {
                var currentNode = this.data[i];
                while (currentNode != null)
                {
                    if (currentNode.Value != null)
                    {
                        result.Add(((KVP)currentNode.Value).Key);
                    }
                    currentNode = currentNode.Next;
                }
            }
            return result;
        }

        public object Get(string key)
        {
            object result = null;

            var index = _hash(key);
            if (data[index] != null)
            {
                var currentNode = data[index];

                while (currentNode != null)
                {
                    var nodeValue = (KVP)currentNode.Value;

                    if (nodeValue.Key.Equals(key))
                    {
                        result = nodeValue.Value;
                        break;
                    }
                    currentNode = currentNode.Next;
                }
            }
            return result;
        }
    }

    public struct KVP
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }
}
