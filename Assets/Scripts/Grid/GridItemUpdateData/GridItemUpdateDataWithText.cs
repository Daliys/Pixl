using Grid.GridItems;

namespace Grid.GridItemUpdateData
{
    public class GridItemUpdateDataWithText: GridItemUpdateData
    {
        public readonly string text;

        public GridItemUpdateDataWithText(GridItem.CellStatus cellStatus, string text) : base(cellStatus)
        {
            this.text = text;
        }
    }
}