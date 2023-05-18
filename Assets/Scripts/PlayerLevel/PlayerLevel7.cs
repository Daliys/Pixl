using Data;
using Grid.GridData;
using LevelSolver;
using UI;

namespace PlayerLevel
{
    public class PlayerLevel7 : PlayerLevel
    {
        protected bool[,] playerGrid;
        
        public override void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel)
        {
            this.uiLevel = uiLevel;
            gridSize = new Point(startingGrid.GetLength(0), startingGrid.GetLength(1));
            grid = new bool[gridSize.x, gridSize.y];
            grid = startingGrid.Clone() as bool[,];
            playerGrid = new bool[gridSize.x, gridSize.y];
        }

        public override GridItemData GetGritItemDataAtPoint(Point point)
        {
            CellStatus cellStatus;
            
            if (playerGrid[point.x, point.y]) cellStatus = grid[point.x, point.y] ? CellStatus.SelectedWhite : CellStatus.SelectedBlack;
            else cellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;

            bool isButtonActive = grid[point.x, point.y];
            
            return new GridItemButtonData {CellStatus = cellStatus, IsButtonActive = isButtonActive};
        }

        public override bool IsGridFilledCorrect()
        {
            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    bool correctValue = GetLevelSolver().GetCorrectValueAtPoint(new Point(i, j));
                    if (correctValue != playerGrid[i,j]) return false;
                }
            }

            return true;
        }
        
        public override GridItemData GetResultDataForUpdateCell(Point point)
        {
            bool solverValue = GetLevelSolver().GetCorrectValueAtPoint(point);
            bool playerValue = playerGrid[point.x, point.y];
            
            CellStatus cellStatus;
            bool isClickable = false;
            bool isAlpha = true;
            
            if (solverValue && playerValue)
            {
                cellStatus = CellStatus.SelectedWhite;
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

        public void SetOppositePlayerValueAtPoint(Point point)
        {
            playerGrid[point.x, point.y] = !playerGrid[point.x, point.y];
        }
     
        
        private LevelSolverLevel7 GetLevelSolver() => (LevelSolverLevel7)uiLevel.LevelSolver;
        private UILevel7 GetUiLevel() => (UILevel7)uiLevel;
        
    }
}