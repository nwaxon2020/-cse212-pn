public static class Recursion
{
    public static void SolveMaze(List<string> results, Maze maze)
    {
        List<(int, int)> currPath = new();
        Explore(results, maze, currPath, 0, 0);
    }

    private static void Explore(List<string> results, Maze maze, List<(int, int)> currPath, int x, int y)
    {
        // Base cases
        if (!maze.IsValidMove(currPath, x, y))
            return;

        // Add current position to path
        currPath.Add((x, y));

        // Check if this is the end
        if (maze.IsEnd(x, y))
        {
            results.Add(currPath.AsString());
        }
        else
        {
            // Recursive calls in 4 directions: Right, Down, Left, Up
            Explore(results, maze, currPath, x + 1, y); // right
            Explore(results, maze, currPath, x, y + 1); // down
            Explore(results, maze, currPath, x - 1, y); // left
            Explore(results, maze, currPath, x, y - 1); // up
        }

        // Backtrack
        currPath.RemoveAt(currPath.Count - 1);
    }
}
