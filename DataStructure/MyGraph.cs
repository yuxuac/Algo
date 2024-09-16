using System;
using System.Collections.Generic;

/*
1. What is graph?
                is a        is a
    LinkedList -----> Tree -----> Graph
2. Types of graph
    Directed - Undirected
    Weighted - Unweighted
    Cylic - Acyclic
3. Graph Data
       2 ---- 0
      / \
     /   \
    1 --- 3

    3.1: Edge List
        const graph1 = new [[0, 2], [2, 3], [2, 1], [1, 3]];
    3.2: Adjacent List
        const graph2_1 = new [[2],  [2, 3], [1, 3, 0], [1, 2]];
        const graph2_2 = new [{ key: 0, value: [2] }, { key: 1, value: [2, 3] }, { key: 2, value: [1, 3, 0] }, { key: 3, value: [1, 2]}]
    3.3: Adjacent Matrix (0s and 1s can be replaced with weighted value)
        const graph3 = new [
        //    0  1  2  3
          0  [0, 0, 1, 0],
          1  [0, 0, 1, 1],
          2  [1, 1, 0, 1],
          3  [0, 1, 1, 0],
        ];

*/
namespace Algo
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