using Data;
using Grid.GridData;
using LevelSolver;
using UI;

namespace PlayerLevel
{
    public class PlayerLevel1 : PlayerLevel
    {

        private IrrationalNumber[,] gridValues;
        
        public override void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel)
        {
            this.uiLevel = uiLevel;
            gridSize = new Point(startingGrid.GetLength(0), startingGrid.GetLength(1));
            grid = new bool[gridSize.x, gridSize.y];
            gridValues = new IrrationalNumber[gridSize.x, gridSize.y];
            grid = startingGrid.Clone() as bool[,];
        }

        public override GridItemData GetGritItemDataAtPoint(Point point)
        {
            CellStatus cellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
            IrrationalNumber number = gridValues[point.x, point.y];
            string str = number == null ? "" : number.ToString();
      
            Point currentSelected = GetUiLevel().GridFiller.SelectedGridItem == null? null : GetUiLevel().GridFiller.SelectedGridItem.Point;
            bool isAlpha = currentSelected == null || point.Equals(currentSelected);
            bool isBorder = currentSelected != null && point.Equals(currentSelected);
            
            return new GridItemButtonTextData
                {CellStatus = cellStatus, Text = str, IsImageAlpha100 = isAlpha, IsImageBorderVisible = isBorder};
        }


        public void SetGridValue(Point point, IrrationalNumber number)
        {
            gridValues[point.x, point.y] = number;
        }

        public new IrrationalNumber GetGridValue(Point point)
        {
            return gridValues[point.x, point.y];
        }

   
        
        public override GridItemData GetResultDataForUpdateCell(Point point)
        {
            IrrationalNumber solverNumber = GetLevelSolver().GetGridValueAtPoint(point);
            IrrationalNumber playerNumber = gridValues[point.x, point.y];

            CellStatus cellStatus;
            string text;
            bool isClickable;
            
            if (solverNumber.Equals(playerNumber))
            {
                cellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;
                text = playerNumber.ToString();
                isClickable = false;
            }
            else
            {
                cellStatus = CellStatus.Warning;
                text = "";
                isClickable = true;
            }
            
            return new GridItemButtonTextData{CellStatus = cellStatus, Text = text, IsButtonActive = isClickable};
        }
        
        public override bool IsGridFilledCorrect()
        {
            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    IrrationalNumber number = GetLevelSolver().GetGridValues()[i, j];
                    if (!number.Equals(gridValues[i, j])) return false;
                }
            }

            return true;
        }

        private LevelSolverLevel1 GetLevelSolver() => (LevelSolverLevel1)uiLevel.LevelSolver;
        private UILevel1 GetUiLevel() => (UILevel1)uiLevel;
    }
}