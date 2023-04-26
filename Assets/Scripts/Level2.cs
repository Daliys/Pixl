using Grid.GridItems;
using Grid.GridItemUpdateData;

public class Level2 : LevelSolver
{
    
    private IrrationalNumber[,] gridValues;

    public override void Initialize(bool[,] startingGrid)
    {
        base.Initialize(startingGrid);
        gridValues = new IrrationalNumber[gridSize.x, gridSize.y];
    }


    protected override void StartSolving()
    {
        for (int i = 0; i < gridSize.x; i++)
        {
            for (int j = 0; j < gridSize.y; j++)
            {
                Point point = new Point(i, j);
                bool status = GetGridValue(point);

                Point nearPoint = GetNearOppositeCell(point, status);
                Point distPoint = point - nearPoint;
                gridValues[point.x, point.y] = new IrrationalNumber(distPoint, status);
            }
        }
    }
    
    private Point GetNearOppositeCell(Point originalPoint, bool initialValue)
    {
        Point lowestDistancePoint = null;

        for (int wave = 1; wave < 8; wave++)
        {
            for (int i = -wave; i < wave; i++)
            {
                Point pointToCheck = new Point(originalPoint.x + i, originalPoint.y - wave);
                lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint, lowestDistancePoint, initialValue);

                pointToCheck = new Point(originalPoint.x + wave, originalPoint.y + i);
                lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint, lowestDistancePoint, initialValue);

                pointToCheck = new Point(originalPoint.x - i, originalPoint.y + wave);
                lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint, lowestDistancePoint, initialValue);

                pointToCheck = new Point(originalPoint.x - wave, originalPoint.y - i);
                lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint, lowestDistancePoint, initialValue);
            }

            if (lowestDistancePoint != null)
            {
                return lowestDistancePoint;
            }
        }

        return null;
    }
    

    private Point CompareAndGetLowestDistancePoint(Point pointToCheck, Point originalPoint, Point lowestDistancePoint, bool initValue)
    {
        if (IsPointInRange(pointToCheck) && GetGridValue(pointToCheck) == !initValue)
        {
            if (lowestDistancePoint == null) return pointToCheck;

            Point distCheck = originalPoint - pointToCheck;
            IrrationalNumber irCheck = new IrrationalNumber(distCheck);

            Point distLowest = pointToCheck - lowestDistancePoint;
            IrrationalNumber irLowest = new IrrationalNumber(distLowest);


            return irCheck < irLowest ? pointToCheck : lowestDistancePoint;

        }

        return lowestDistancePoint;
    }

    public GridItemUpdateData GetCorrectDataForUpdateCell(Point point)
    {
        GridItem.CellStatus cellStatus = grid[point.x, point.y] ? GridItem.CellStatus.Filled : GridItem.CellStatus.Empty;
        return new GridItemUpdateDataWithText(cellStatus, gridValues[point.x, point.y].ToString());
    }

    
}