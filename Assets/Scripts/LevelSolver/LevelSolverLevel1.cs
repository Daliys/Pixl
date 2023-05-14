using Data;
using Grid.GridData;
using Grid.GridItems;

namespace LevelSolver
{
    public class LevelSolverLevel1 : LevelSolver
    {

        public IrrationalNumber[,] gridValues;

        public override void Initialize(bool[,] startingGrid)
        {
            base.Initialize(startingGrid);
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
                    bool status = GetGridValue(point);

                    Point nearPoint = GetNearOppositeCell(point, status);
                    Point distPoint = point - nearPoint;
                    gridValues[point.x, point.y] = new IrrationalNumber(distPoint, !status);
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
                    return lowestDistancePoint;
                }
            }

            return null;
        }


        private Point CompareAndGetLowestDistancePoint(Point pointToCheck, Point originalPoint,
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

        public GridItemButtonTextData[,] GetGridForResultExplanationPanel(Point point)
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
    }
}