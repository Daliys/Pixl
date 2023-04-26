using System.Collections.Generic;
using Grid.GridItems;

public abstract class LevelSolver : LevelBase
{
    protected bool[,] tempGrid;
    
    protected List<bool[,]> iterationList;
    
    public virtual void Initialize(bool[,] startingGrid)
    {
        //Change Lenght 
        gridSize = new Point(startingGrid.GetLength(0), startingGrid.GetLength(1));
        grid = new bool[gridSize.x, gridSize.y];
        tempGrid = new bool[gridSize.x, gridSize.y];
        iterationList = new List<bool[,]>();
        
        grid = startingGrid.Clone() as bool[,];
        tempGrid = startingGrid.Clone() as bool[,];
        
        StartSolving();
    }

    protected abstract void StartSolving();


    public GridItem.CellStatus GetCellStatusAtPoint(Point point, int iterationNumber)
    {
        bool value = iterationList[iterationNumber][point.x, point.y];
        return value ? GridItem.CellStatus.Filled : GridItem.CellStatus.Empty;
    }
}