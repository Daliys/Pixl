using Data;

namespace Grid.GridData
{
    public record GridItemData
    {
        public CellStatus CellStatus { get; set; }
        public bool IsImageAlpha100 { get; set; } = true;
        
        /*public GridItemData(byte cellStatus, bool isImageAlpha100 = true)
        {
            this.cellStatus = cellStatus;
            this.isImageAlpha100 = isImageAlpha100;
        }*/
    }
}