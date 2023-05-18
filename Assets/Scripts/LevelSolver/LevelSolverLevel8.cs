using Data;

namespace LevelSolver
{
    public class LevelSolverLevel8 : LevelSolverLevel7
    {
        public LevelSolverLevel8(Mask mask) : base(mask)
        {
        }

        protected override bool GetValueAfterMaskAtPoint(Point point)
        {
            if (grid[point.x, point.y]) return false;
            
            Point maskCenter = new Point(mask.MaskSize.x / 2, mask.MaskSize.y / 2);

            for (int i = 0; i < mask.MaskSize.x; i++)
            {
                for (int j = 0; j < mask.MaskSize.y; j++)
                {
                    if (mask.GetMask()[i, j])
                    {
                        Point checkingPoint = new Point(point.x + i - maskCenter.x, point.y + j - maskCenter.y);
                        if (IsPointInRange(checkingPoint) && grid[checkingPoint.x, checkingPoint.y]) return true;
                    }
                }
            }
            
            return false;
        }

        protected override CellStatus GetCellStatusForResultExplanationPanel(CellStatus cellStatus, Point point, Point CheckingPoint)
        {
            bool isCellWrong = !GetValueAfterMaskAtPoint(CheckingPoint);
            
            if (cellStatus == CellStatus.Filled && mask.GetMask()[point.x, point.y])
                cellStatus = CellStatus.SelectedWhite;

            if (cellStatus == CellStatus.Empty && mask.GetMask()[point.x, point.y])
            {
                if(isCellWrong) cellStatus = CellStatus.SelectedYellow;
                else cellStatus = CellStatus.SelectedBlack;
            }
            return cellStatus;
        }
    }
}