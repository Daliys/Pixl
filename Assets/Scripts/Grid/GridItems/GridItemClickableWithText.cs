using TMPro;

namespace Grid.GridItems
{
    public class GridItemClickableWithText : GridItemClickable
    { 
        protected TextMeshProUGUI textView;

        protected override void Awake()
        {
            base.Awake();
            textView = GetComponent<TextMeshProUGUI>();
        }


        protected override void AfterUpdateCellData(GridItemUpdateData.GridItemUpdateData updateData)
        {
            textView.text = ((GridItemUpdateData.GridItemUpdateDataWithText)updateData).text;
        }
    }
}