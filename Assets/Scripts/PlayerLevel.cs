using System.Collections.Generic;
using Grid;
using Grid.GridItems;
using Grid.GridItemUpdateData;

public class PlayerLevel : LevelBase
{
    private LevelSolver levelSolver;
    private List<bool[,]> playerIterations;

    private bool isResultCorrect;
    
    public void Initialize(bool[,] startingGrid, LevelSolver levelSolver)
    {
        playerIterations = new List<bool[,]>();
        this.levelSolver = levelSolver;
        
        gridSize = new Point(startingGrid.GetLength(0), startingGrid.GetLength(1));
        grid = new bool[gridSize.x, gridSize.y];
        grid = startingGrid.Clone() as bool[,];
        
        SaveIteration();
        isResultCorrect = true;
    }

    public void SaveIteration()
    {
        bool isSame = true ;
        bool[,] newGrid = new bool[gridSize.x, gridSize.y];

        for (int i = 0; i < gridSize.x; i++)
        {
            for (int j = 0; j < gridSize.y; j++)
            {
                newGrid[i, j] = grid[i, j];
                if (playerIterations.Count < 1)
                {
                    isSame = false;
                }
                else if (newGrid[i, j] != playerIterations[^1][i, j])
                {
                    isSame = false;
                }
            }
        }

        if (!isSame)
        {
            playerIterations.Add(newGrid);
        }
    }
    
    public void OnButtonEditPreviousClicked()
    {
        bool[,] lastStep = playerIterations[^2];
        for (int i = 0; i < gridSize.x; i++)
        {
            for (int j = 0; j < gridSize.y; j++)
            {
                if (GetPreviousGridItemStatus(new Point(i, j)).cellStatus == GridItem.CellStatus.SelectedByPlayer)
                {
                    grid[i, j] = false;
                }
                else
                {
                    grid[i, j] = lastStep[i, j];
                }

            }
        }

        playerIterations.RemoveAt(playerIterations.Count-1);

    }
    
    public List<bool[,]> PlayerIterations => playerIterations;

    public GridItemUpdateData GetClickableGridItemResultStatus(Point point)
    {
        bool playerStatus = grid[point.x,point.y];
        bool currentStatus = levelSolver.GetGridValue(point);

        if (!currentStatus && !playerStatus) return new GridItemUpdateData(GridItem.CellStatus.Empty);
        if (currentStatus && playerStatus) return new GridItemUpdateData(GridItem.CellStatus.ResultCorrectSelected);
        isResultCorrect = false;
        if (!currentStatus && playerStatus) return new GridItemUpdateData(GridItem.CellStatus.ResultWrongSelectedShouldBeEmpty);
        // current && !player
        return new GridItemUpdateData(GridItem.CellStatus.ResultWrongSelectedShouldBeFilled);
    }

    public GridItemUpdateData GetPreviousGridItemStatus(Point point)
    {
        if (playerIterations.Count < 2) return new GridItemUpdateData(GridItem.CellStatus.Empty);

        bool currentStatus = playerIterations[^1][point.x, point.y];
        bool previousStatus = playerIterations[^2][point.x, point.y];

        if (!currentStatus && !previousStatus) return new GridItemUpdateData(GridItem.CellStatus.Empty);
        if (currentStatus && previousStatus) return new GridItemUpdateData(GridItem.CellStatus.Filled);

        return new GridItemUpdateData(GridItem.CellStatus.SelectedByPlayer);
    }

    public GridItemUpdateData GetCellStatusAtPoint(Point point)
    {
        return new GridItemUpdateData(GetGridValue(point) ? GridItem.CellStatus.Filled : GridItem.CellStatus.Empty);
    }

    public int GetCurrentIteration()
    {
        return playerIterations.Count - 1;
    }

    public bool IsResultCorrect => isResultCorrect;
}
