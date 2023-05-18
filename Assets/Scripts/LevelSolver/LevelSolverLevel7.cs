using Data;
using Grid.GridData;
using UI;

namespace LevelSolver
{
    public class LevelSolverLevel7 : LevelSolver
    {
        protected bool[,] solvedGrid;
        protected readonly Mask mask;

        public LevelSolverLevel7(Mask mask)
        {
            this.mask = mask;
        }
        
        
        public override void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel)
        {
            base.Initialize(startingGrid, uiLevel);
            solvedGrid = new bool[gridSize.x, gridSize.y];
            
            StartSolving();
        }
        
        protected override void StartSolving()
        {
            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    solvedGrid[i, j] = GetValueAfterMaskAtPoint(new Point(i, j));
                }
            }
        }

        protected virtual bool GetValueAfterMaskAtPoint(Point point)
        {
            Point maskCenter = new Point(mask.MaskSize.x / 2, mask.MaskSize.y / 2);
            
            for (int i = 0; i < mask.MaskSize.x; i++)
            {
                for (int j = 0; j < mask.MaskSize.y; j++)
                {
                    if (mask.GetMask()[i, j])
                    {
                        Point checkingPoint = new Point(point.x + i - maskCenter.x, point.y + j - maskCenter.y);
                        if (!IsPointInRange(checkingPoint) || !grid[checkingPoint.x, checkingPoint.y]) return false;
                    }
                }
            }
            
            return true;
        }

        public bool GetCorrectValueAtPoint(Point point)
        {
            return solvedGrid[point.x, point.y];
        }

        public override GridItemData[,] GetGridForResultExplanationPanel(Point point)
        {
            GridItemButtonData[,] gridItemUpdateData = new GridItemButtonData[gridSize.x, gridSize.y];

            for (int i = 0; i < gridSize.x; i++)
            {
                for (int j = 0; j < gridSize.y; j++)
                {
                    CellStatus cellStatus = grid[i, j] ? CellStatus.Filled : CellStatus.Empty;
                    gridItemUpdateData[i, j] = new GridItemButtonData
                    {
                        CellStatus = cellStatus, IsButtonActive = false, IsImageAlpha100 = false
                    };
                }
            }
            
            Point maskCenter = new Point(mask.MaskSize.x / 2, mask.MaskSize.y / 2);
            for (int i = 0; i < mask.MaskSize.x; i++)
            {
                for (int j = 0; j < mask.MaskSize.y; j++)
                {
                    Point checkingPoint = new Point(point.x + i - maskCenter.x, point.y + j - maskCenter.y);
                    if(IsPointInRange(checkingPoint))
                    {
                        CellStatus cellStatus = gridItemUpdateData[checkingPoint.x, checkingPoint.y].CellStatus;

                        cellStatus = GetCellStatusForResultExplanationPanel(cellStatus, new Point(i, j),point);

                        gridItemUpdateData[checkingPoint.x, checkingPoint.y] = new GridItemButtonData 
                            { CellStatus = cellStatus, IsButtonActive = false, IsImageAlpha100 = true};
                    }
                }
            }
            
            return gridItemUpdateData;
        }

        protected virtual CellStatus GetCellStatusForResultExplanationPanel(CellStatus cellStatus, Point point, Point CheckingPoint)
        {
            if (cellStatus == CellStatus.Filled && mask.GetMask()[point.x, point.y])
                cellStatus = CellStatus.SelectedWhite;
                        
            if(cellStatus == CellStatus.Empty && mask.GetMask()[point.x, point.y])
                cellStatus = CellStatus.SelectedYellow;

            return cellStatus;
        }
        
        public override GridItemData GetGridItemDataAtPoint(Point point)
        {
            CellStatus cellStatus;
       
            if (solvedGrid[point.x, point.y]) cellStatus = grid[point.x, point.y] ? CellStatus.SelectedWhite : CellStatus.SelectedBlack;
            else cellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;

            return new GridItemButtonData{CellStatus = cellStatus};
        }
    }
}