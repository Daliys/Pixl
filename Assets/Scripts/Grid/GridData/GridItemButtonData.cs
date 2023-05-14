using Data;

namespace Grid.GridData
{
    public record GridItemButtonData : GridItemData
    {
        public bool IsButtonActive { get; set; } = true;
        
        /*public GridItemButtonData(CellStatus cellStatus) : base(cellStatus)
        {
            isButtonActive = true;
            isImageBorderVisible = false;
        }
        
        public GridItemButtonData(CellStatus cellStatus, bool isImageAlpha100, bool isButtonActive, bool isImageBorderVisible) : base(cellStatus, isImageAlpha100)
        {
            this.isButtonActive = isButtonActive;
            this.isImageBorderVisible = isImageBorderVisible;
        }*/
    }
}