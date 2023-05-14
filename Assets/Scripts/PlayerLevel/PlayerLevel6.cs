using System.Collections.Generic;
using Data;
using Grid.GridData;
using Grid.GridItems;
using UI;

namespace PlayerLevel
{
    public class PlayerLevel6 : PlayerLevel
    {
        private List<bool[,]> playerIterations;

        private bool isResultCorrect;

        public override void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel)
        {
            this.uiLevel = uiLevel;
            playerIterations = new List<bool[,]>();

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
                    //TODO переделать этот кусок здесь ошибка
                    /*if (GetPreviousGridItemStatus(new Point(i, j)).cellStatus == GridItem.CellStatus.SelectedByPlayer)
                    {
                        grid[i, j] = false;
                    }
                    else
                    {
                        grid[i, j] = lastStep[i, j];
                    }*/
                }
            }

            playerIterations.RemoveAt(playerIterations.Count-1);

        }
    
        public List<bool[,]> PlayerIterations => playerIterations;

        public ResultStatus GetClickableGridItemResultStatus(Point point)
        {
            bool playerStatus = grid[point.x,point.y];
            bool currentStatus = uiLevel.LevelSolver.GetGridValue(point);

            if (!currentStatus && !playerStatus) return ResultStatus.Correct;
            if (currentStatus && playerStatus) return ResultStatus.Correct;
            isResultCorrect = false;
            if (!currentStatus && playerStatus) return ResultStatus.WrongShouldBeEmpty;
            // current && !player
            return ResultStatus.WrongShouldBeFilled;
        }

        public GridItemData GetPreviousGridItemStatus(Point point)
        {
            if (playerIterations.Count < 2) return null;

            bool currentStatus = playerIterations[^1][point.x, point.y];
            bool previousStatus = playerIterations[^2][point.x, point.y];

            if (!currentStatus && !previousStatus) return new GridItemData{CellStatus = CellStatus.Empty};
            if (currentStatus && previousStatus) return new GridItemData{CellStatus = CellStatus.Filled};

            return new GridItemData{CellStatus = CellStatus.Selected};
        }

     
        public int GetCurrentIteration()
        {
            return playerIterations.Count - 1;
        }

        public bool IsResultCorrect => isResultCorrect;
    }
}
