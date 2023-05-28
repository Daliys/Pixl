using System.Collections.Generic;
using Data;
using Grid.GridData;
using Grid.GridItems;
using LevelSolver;
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

        public GridItemData GetGritItemDataAtPointWhenClicked(Point point)
        {
            CellStatus finalStatus;
            bool isClickable = grid[point.x, point.y];
            
            if (playerIterations.Count > 1)
            {
                CellStatus lastCellStatus =
                    grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
                CellStatus prevCellStatus =
                    playerIterations[^1][point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
                
                finalStatus = (lastCellStatus != prevCellStatus)? CellStatus.Selected : lastCellStatus;
                isClickable = playerIterations[^1][point.x, point.y];
            }
            else
            {
                CellStatus lastCellStatus = playerIterations[^1][point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
                CellStatus prevCellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
                
                finalStatus = (lastCellStatus != prevCellStatus)? CellStatus.Selected : lastCellStatus;
                isClickable = playerIterations[^1][point.x, point.y];
            }
            
            return new GridItemButtonData {CellStatus = finalStatus, IsButtonActive = isClickable};
        }

        public override GridItemData GetGritItemDataAtPoint(Point point)
        {
            CellStatus lastCellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
            bool isClickable = grid[point.x, point.y];

            return new GridItemButtonData { CellStatus = lastCellStatus, IsButtonActive = isClickable };
        }

        public override bool IsGridFilledCorrect()
        {
            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    bool solverValue = GetLevelSolver().GetGridStatusAtLastIteration(new Point(i,j));
                    if (grid[i,j] != solverValue) return false;
                }
            }
        
            return true;
        }

        public override GridItemData GetResultDataForUpdateCell(Point point)
        {
            bool solverValue = GetLevelSolver().GetCorrectValueAtPoint(point);
            bool playerValue = grid[point.x, point.y];
            
            CellStatus cellStatus;
            bool isClickable = false;
            bool isAlpha = true;
            
            if (solverValue && playerValue)
            {
                cellStatus = CellStatus.Filled;
            }
            else if (!solverValue && !playerValue)
            {
                cellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
                isAlpha = false;
            }
            else
            {
                cellStatus = CellStatus.Warning;
                isClickable = true;
            }
            
            return new GridItemButtonTextData{CellStatus = cellStatus, IsButtonActive = isClickable, IsImageAlpha100 = isAlpha};
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
                 
                    if (GetPreviousGridItemStatus(new Point(i, j)).CellStatus == CellStatus.Selected)
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

        public void OnGridItemClicked(GridItem gridItem)
        {
            Point point = gridItem.Point;
            grid[point.x, point.y] = !grid[point.x, point.y];
            gridItem.UpdateCellData(GetGritItemDataAtPointWhenClicked(gridItem.Point));
        }

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

        public GridItemButtonData[,] GetPreviousGridItemStatus()
        {
            GridItemButtonData[,] data = new GridItemButtonData[gridSize.x, gridSize.y];

            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    Point point = new Point(i, j);
                    if (playerIterations.Count < 2) return null;

                    bool currentStatus = playerIterations[^1][point.x, point.y];
                    bool previousStatus = playerIterations[^2][point.x, point.y];

                    if (!currentStatus && !previousStatus)
                    {
                        data[i, j] = new GridItemButtonData { CellStatus = CellStatus.Empty, IsButtonActive = false };
                        continue;
                    }

                    if (currentStatus && previousStatus)
                    {
                        data[i, j] = new GridItemButtonData { CellStatus = CellStatus.Filled, IsButtonActive = true };
                        continue;
                    }

                    data[i, j] = new GridItemButtonData { CellStatus = CellStatus.Selected, IsButtonActive = true };
                }
            }

            return data;

        }

        public int GetCurrentIteration()
        {
            return playerIterations.Count - 1;
        }

        public bool IsResultCorrect => isResultCorrect;
        
        private LevelSolverLevel6 GetLevelSolver() => (LevelSolverLevel6)uiLevel.LevelSolver;
    }
}
