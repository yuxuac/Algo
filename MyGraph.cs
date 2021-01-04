using System;
using System.Collections.Generic;

namespace pg1
{
    public class MyGraph
    {
        public MyGraph()
        {
            this._adjacentList = new Dictionary<int, List<int>>();
            this.numberOfNodes = 0;
        }

        private int numberOfNodes;
        public int NumberOfNodes
        {
            get { return numberOfNodes; }
            private set { this.numberOfNodes = value; }
        }

        private Dictionary<int, List<int>> _adjacentList;

        public bool AddVertex(int node)
        {
            bool flag = false;
            if (!this._adjacentList.ContainsKey(node))
            {
                this._adjacentList.Add(node, new List<int>());
                this.NumberOfNodes++;
                flag = true;
            }
            return flag;
        }

        public bool AddEdge(int node1, int node2)
        {
            // Undirected graph
            bool flag = false;
            if (!this._adjacentList.ContainsKey(node1))
                AddVertex(node1);
            if (!this._adjacentList.ContainsKey(node2))
                AddVertex(node2); 

            if (!this._adjacentList[node1].Contains(node2))
            {
                this._adjacentList[node1].Add(node2);
                flag = true;
            }
            if (!this._adjacentList[node2].Contains(node1))
            {
                this._adjacentList[node2].Add(node1);
                flag = true;
            }
            return flag;
        }

        public void ShowConnections()
        {
            foreach(var key in this._adjacentList.Keys)
            {
                Console.Write($"{key}-->");
                foreach(var val in this._adjacentList[key])
                {
                    Console.Write($"{val}, ");
                }
                Console.WriteLine();
            }
        }
    }
}