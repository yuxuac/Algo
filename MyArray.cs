using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace pg1
{
    public class MyArray
    {
        // push
        // pop
        // delete
        private int Length;
        public object[] Data;

        private int Increasement = 1000;

        public MyArray()
        {
            this.Length = 0;
            this.Data = new object[100];
        }
    }
}