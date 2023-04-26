
using Grid.GridFillers;
using Grid.GridItems;

namespace Grid
{
    public class ClickableGridFiller : GridFiller
    {
        protected override void InitializeGridItem(GridItem gridItem, Point point)
        {
            ((GridItemClickable)gridItem).Initialize(point, uiController.PlayerLevel);
        }

        public void UpdateGridByResultValue()
        {
            UpdateGridBy(uiController.PlayerLevel.GetClickableGridItemResultStatus);
        }

        public void UpdateGridByPlayerLevelGrid()
        {
            UpdateGridBy(uiController.PlayerLevel.GetCellStatusAtPoint);
        }

        public void UpdateGridByPreviousGridValues()
        {
            UpdateGridBy(uiController.PlayerLevel.GetPreviousGridItemStatus);
        }
    }
}
