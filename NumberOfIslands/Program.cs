using System.Reflection.Metadata.Ecma335;

namespace NumberOfIslands
{
    internal class Program
    {
        static char[][] grid = new char[][]
        {
            new char[] {'1','1','1'},
            new char[] {'0','1','0'},
            new char[] {'1','1','1'},
        };
        // necessary items
        static int m = grid.Length;
        static int n = grid[0].Length;
        static int result = 0;
        static bool[,] visitedGrid = new bool[m,n];


        static void Main(string[] args)
        {
            result = NumIslands(grid);
            Console.WriteLine(result);
        }

        static int NumIslands(char[][] grid)
        {
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (!visitedGrid[i, j] && grid[i][j] == '1')
                    {
                        visitedGrid[i, j] = true;
                        result++;
                        CheckAround(i, j);
                    }                    
                }
            }
            return result;
        }

        static void CheckAround(int i, int j)
        {
            //checktop
            if (i > 0)
            {
                if (!visitedGrid[i - 1, j] && grid[i - 1][j] == '1')
                {
                    visitedGrid[i - 1, j] = true;
                    CheckAround(i - 1, j);
                }
            }
                                                       
            //checkleft
            if (j > 0)
            {
                if (!visitedGrid[i, j-1] && grid[i][j-1] == '1')
                {
                    visitedGrid[i, j-1] = true;
                    CheckAround(i, j-1);
                }
            }

            //checkbottom
            if (i < (m - 1))
            {
                if (!visitedGrid[i + 1, j] && grid[i + 1][j] == '1')
                {
                    visitedGrid[i + 1, j] = true;
                    CheckAround(i+1, j);
                }
            }

            //checkright
            if (j < (n -1))
            {
                if (!visitedGrid[i, j + 1] && grid[i][j + 1] == '1')
                {
                    visitedGrid[i, j + 1] = true;
                    CheckAround(i, j + 1);
                }
            }
        }
    }
}
