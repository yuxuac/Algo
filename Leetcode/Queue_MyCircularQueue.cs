using System;
using System.Collections.Generic;

namespace Algo.Leetcode
{
    public class MyCircularQueue
    {
        private int Length { get; set; }
        private int[] Data { get; set; }
        private int HeadIndex { get; set; }
        private int TailIndex { get; set; }
        private int Size { get; set; }

        public MyCircularQueue(int k)
        {
            this.Data = new int[k];
            this.Length = 0;
            this.HeadIndex = -1;
            this.TailIndex = -1;
            this.Size = k;
        }

        public bool EnQueue(int value)
        {
            if (this.IsFull())
                return false;

            if (this.Length == 0)
            {
                this.Data[0] = value;
                this.HeadIndex = 0;
                this.TailIndex = 0;
            }
            else
            {
                if (this.TailIndex == this.Size - 1)
                    this.TailIndex = 0;
                else
                    this.TailIndex++;
                this.Data[TailIndex] = value;
            }

            this.Length++;
            return true;
        }

        public bool DeQueue()
        {
            if (this.IsEmpty())
                return false;

            if (this.Length == 1)
            {
                this.Data[this.HeadIndex] = -1;
                this.HeadIndex = -1;
                this.TailIndex = -1;
            }
            else
            {
                this.Data[this.HeadIndex] = -1;
                if (this.HeadIndex == this.Size - 1)
                    this.HeadIndex = 0;
                else
                    this.HeadIndex++;
            }

            this.Length--;
            return true;
        }

        public int Front()
        {
            if (this.HeadIndex < 0)
                return -1;
            return this.Data[this.HeadIndex];
        }

        public int Rear()
        {
            if (this.TailIndex < 0)
                return -1;
            return this.Data[this.TailIndex];
        }

        public bool IsEmpty()
        {
            return this.Length == 0;
        }

        public bool IsFull()
        {
            return this.Length == this.Size;
        }
    }
}