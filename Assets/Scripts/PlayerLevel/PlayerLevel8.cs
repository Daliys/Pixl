using Data;
using Grid.GridData;

namespace PlayerLevel
{
    public class PlayerLevel8 : PlayerLevel7
    {
        public override GridItemData GetGritItemDataAtPoint(Point point)
        {
            CellStatus cellStatus;
            
            if (playerGrid[point.x, point.y]) cellStatus = grid[point.x, point.y] ? CellStatus.SelectedWhite : CellStatus.SelectedBlack;
            else cellStatus = grid[point.x, point.y] ? CellStatus.Filled : CellStatus.Empty;

            bool isButtonActive = !grid[point.x, point.y];
            
            return new GridItemButtonData {CellStatus = cellStatus, IsButtonActive = isButtonActive};
        }
    }
}