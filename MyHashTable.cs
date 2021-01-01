namespace pg1
{
    public class MyHashTable
    {
        private object[] data;
        public MyHashTable(int size)
        {
            data = new object[size];
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
            // if (data[index] != null)
            //     data[index] = null;

            this.data[index] = new { key, val };
        }

        public object Get(string key)
        {
            var index = _hash(key);
            return data[index];
        }
    }
}
