using System.Collections.Generic;

namespace Problems
{
    public class NumberOfIslands200
    {
        public int NumIslands(char[][] grid) {
            var rows = grid.Length;
            var cols = grid[0].Length;
            
            HashSet<(int, int)> visited = new();
            var islands = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r][c] == '1' && !visited.Contains((r,c)))
                    {
                        BFS(r, c);
                        islands++;
                    }
                }
            }

            return islands;

            void BFS(int row, int col)
            {
                // define a queue
                Queue<(int, int)> q = new();
                // add first node and mark visited
                q.Enqueue((row,col));
                visited.Add((row,col)); // or grid[row][col] = '0'; to reduce Space complexity to min(M,N)

                while (q.Count > 0)
                {
                    var (r,c) = q.Dequeue();
                    // check neighbours
                    (int,int)[] directions = new[] { (1, 0), (-1, 0), (0, 1), (0, -1) };
                    foreach(var dir in directions)
                    {
                        row = r + dir.Item1;
                        col = c + dir.Item2;

                        // check if neighbour is in range, is an island, and hasn't been visited
                        if (row < rows && row >= 0 && col < cols && col >= 0
                        && grid[row][col] == '1' && !visited.Contains((row, col)))
                        {
                            q.Enqueue((row,col));
                            visited.Add((row,col)); // or grid[row][col] = '0'; 
                        }
                    }
                }
            }
        }   
    }
}

