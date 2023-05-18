using Data;
using Grid.GridData;
using UI;

namespace LevelSolver
{
    public class LevelSolverLevel1 : LevelSolver
    {

        protected IrrationalNumber[,] gridValues;

        public override void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel)
        {
            base.Initialize(startingGrid, uiLevel);
            gridValues = new IrrationalNumber[gridSize.x, gridSize.y];
            StartSolving();
        }
        
        protected override void StartSolving()
        {
            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    Point point = new Point(i, j);
                    Point nearPoint = GetNearOppositeCell(point, GetGridValue(point));
                    SetDistanceAtGridValues(point, nearPoint);
                }
            }
        }

        protected virtual void SetDistanceAtGridValues(Point settingPoint, Point nearPoint)
        {
            gridValues[settingPoint.x, settingPoint.y] = new IrrationalNumber(settingPoint - nearPoint, !GetGridValue(settingPoint));
        }

        private Point GetNearOppositeCell(Point originalPoint, bool initialValue)
        {
            Point lowestDistancePoint = null;
            bool isCheckedNext = false;

            for (int wave = 1; wave < 8; wave++)
            {
                for (int i = -wave; i < wave; i++)
                {
                    Point pointToCheck = new Point(originalPoint.x + i, originalPoint.y - wave);
                    lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint,
                        lowestDistancePoint, initialValue);

                    pointToCheck = new Point(originalPoint.x + wave, originalPoint.y + i);
                    lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint,
                        lowestDistancePoint, initialValue);

                    pointToCheck = new Point(originalPoint.x - i, originalPoint.y + wave);
                    lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint,
                        lowestDistancePoint, initialValue);

                    pointToCheck = new Point(originalPoint.x - wave, originalPoint.y - i);
                    lowestDistancePoint = CompareAndGetLowestDistancePoint(pointToCheck, originalPoint,
                        lowestDistancePoint, initialValue);
                }

                if (lowestDistancePoint != null)
                {
                    if (!isCheckedNext) isCheckedNext = true;
                    else return lowestDistancePoint;
                }
            }

            return null;
        }

        protected virtual Point CompareAndGetLowestDistancePoint(Point pointToCheck, Point originalPoint,
            Point lowestDistancePoint, bool initValue)
        {
            if (IsPointInRange(pointToCheck) && GetGridValue(pointToCheck) == !initValue)
            {
                if (lowestDistancePoint == null) return pointToCheck;

                Point distCheck = originalPoint - pointToCheck;
                IrrationalNumber irCheck = new IrrationalNumber(distCheck);

                Point distLowest = originalPoint - lowestDistancePoint;
                IrrationalNumber irLowest = new IrrationalNumber(distLowest);

                return irCheck < irLowest ? pointToCheck : lowestDistancePoint;
            }

            return lowestDistancePoint;
        }

        public override GridItemData[,] GetGridForResultExplanationPanel(Point point)
        {
            GridItemButtonTextData[,] gridItemUpdateData = new GridItemButtonTextData[gridSize.x, gridSize.y];
            Point nearOppositeCell = GetNearOppositeCell(point, grid[point.x, point.y]);

            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    GridItemData itemData = GetGridItemDataAtPoint(new Point(i, j));
                    gridItemUpdateData[i, j] = new GridItemButtonTextData
                    {
                        CellStatus = itemData.CellStatus, IsButtonActive = false, Text = "", IsImageAlpha100 = false
                    };
                }
            }

            gridItemUpdateData[nearOppositeCell.x, nearOppositeCell.y] = new GridItemButtonTextData
                { CellStatus = CellStatus.Selected, IsButtonActive = false, Text = "", IsImageBorderVisible = true };

            gridItemUpdateData[point.x, point.y] = new GridItemButtonTextData
            {
                CellStatus = GetGridItemDataAtPoint(point).CellStatus, Text = GetGridValueAtPoint(point).ToString(),
                IsButtonActive = false, IsImageBorderVisible = true
            };
            
            return gridItemUpdateData;
        }


        public IrrationalNumber GetGridValueAtPoint(Point point)
        {
            return gridValues[point.x, point.y];
        }

        public override GridItemData GetGridItemDataAtPoint(Point point)
        {
            bool value = grid[point.x, point.y];
            CellStatus cellStatus = value ? CellStatus.Filled : CellStatus.Empty;
            string text = gridValues[point.x, point.y].ToString();
            return new GridItemButtonTextData { CellStatus = cellStatus, Text = text};
        }

        public IrrationalNumber[,] GetGridValues() => gridValues;
    }
}





