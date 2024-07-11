using System.Reflection.Metadata.Ecma335;

namespace NumberOfIslands
{
    internal class Program
    {
        static char[][] grid = new char[][]
        {
            new char[] {'1', '1', '0', '0', '0'},
            new char[] {'1', '1', '0', '0', '0'},
            new char[] {'0', '0', '1', '0', '0'},
            new char[] {'0', '0', '0', '1', '1'}
        };
        // necessary items
        static int m = grid.Length;
        static int n = grid[0].Length;
        static int result = 0;


        static void Main(string[] args)
        {
            int result = NumIslands(grid);
            Console.WriteLine(result);
        }

        static int NumIslands(char[][] grid)
        {
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {                   
                    if (grid[i][j] == '1')
                    {
                        if (i == 0 && j == 0)
                        {
                            result++;
                        }else if(i > 0 && j == 0)
                        {
                            if (grid[i - 1][j] == '0')
                                result++;
                        }else if(i == 0 && j > 0)
                        {
                            if (grid[i][j - 1] == '0')
                                result++;
                        }
                        else
                        {
                            if (grid[i][j - 1] == '0' && grid[i - 1][j] == '0')
                                result++;
                        }
                    }                    
                }
            }
            return result;
        }
    }
}
