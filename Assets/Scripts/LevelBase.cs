public class LevelBase 
{
    protected bool[,] grid;
    protected Point gridSize;
    
    protected bool IsPointInRangeAndEmpty(Point point)
    {
        return IsPointInRange(point) && !GetGridValue(point);
    }
    
    protected bool IsPointInRangeAndFilled(Point point)
    {
        return IsPointInRange(point) && GetGridValue(point);
    }

    
    protected bool IsPointInRange(Point point)
    {
        if (point.x >= gridSize.x) return false;
        if (point.x < 0) return false;
        if (point.y < 0) return false;
        if (point.y >= gridSize.y) return false;

        return true;
    }

    protected void SetGridValue(Point point)
    {
        grid[point.x,point.y] = true;
    }

    public void SetGridValue(Point point, bool value)
    {
        grid[point.x,point.y] = value;
    }

    
    public bool GetGridValue(Point point)
    {
        return grid[point.x, point.y];
    }

    public bool[,] Grid => grid;

    public void ClearGrid()
    {
        for (int i = 0; i < gridSize.x; i++)
        {
            for (int j = 0; j < gridSize.y; j++)
            {
                grid[i, j] = false;
            }
        }
    }
}
