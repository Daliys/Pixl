using Data;

namespace Grid.GridData
{
    public record GridItemButtonTextData : GridItemButtonData
    {
        public bool IsImageBorderVisible { get; set; } = false;
        public string Text { get; set; } = "";
        
        /*public GridItemButtonTextData(CellStatus cellStatus, string text) : base(cellStatus)
        {
            this.text = text;
        }

        public GridItemButtonTextData(CellStatus cellStatus, bool isImageAlpha100, bool isButtonActive, bool isImageBorderVisible, string text) : base(cellStatus, isImageAlpha100, isButtonActive, isImageBorderVisible)
        {
            this.text = text;
        }*/
    }
}