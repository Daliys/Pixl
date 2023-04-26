using Grid.GridItems;

namespace Grid.GridItemUpdateData
{
    public class GridItemUpdateData
    {
        public readonly GridItem.CellStatus cellStatus;

        public GridItemUpdateData(GridItem.CellStatus cellStatus)
        {
            this.cellStatus = cellStatus;
        }
    }
}