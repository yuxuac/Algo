namespace Algo.Leetcode
{
    public class DFS_NumberOfIslands
    {
        public static char[][] Initialize()
        {
            var result = new char[4][];
            result[0] = new char[] {'1', '1', '0', '0', '0'};
            result[1] = new char[] {'1', '1', '0', '0', '0'};
            result[2] = new char[] {'0', '0', '1', '0', '0'};
            result[3] = new char[] {'0', '0', '0', '1', '1'};

            return result;
        }

        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length <= 0)
                return 0;

            int cnt = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        cnt++;
                    }
                }
            }
            return cnt;
        }

        private static void DFS(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0')
                return;

            grid[i][j] = '0';

            DFS(grid, i + 1, j);
            DFS(grid, i, j + 1);
            DFS(grid, i - 1, j);
            DFS(grid, i, j - 1);
        }
    }
}