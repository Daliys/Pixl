using Grid.GridItems;
using PlayerLevel;

namespace Grid.GridFillers
{
    public class GridFillerPreview : GridFiller
    {
 
        protected override void InitializeGridItem(GridItem gridItem, Point point)
        {
            gridItem.Initialize(point, this);
        }

        public void UpdatePreviousStepGrid()
        {
            UpdateGridBy(((PlayerLevel6)uiLevel.PlayerLevel).GetPreviousGridItemStatus);
        }

    }
}
