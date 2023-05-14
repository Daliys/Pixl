using Data;
using Grid.GridData;
using Grid.GridFillers;
using TMPro;
using UnityEngine;

namespace Grid.GridItems
{
    public class GridItemClickableWithText : GridItemClickable
    { 
        [SerializeField] protected TextMeshProUGUI textView;
        [SerializeField] protected GameObject borderImage;
        
   
        public override void OnButtonClickedGUI()
        {
            ((GridFillerClickableWithText)gridFiller).OnChildButtonClicked(this);
        }

        public override void UpdateCellData(GridItemData gridItemData)
        {
            base.UpdateCellData(gridItemData);
            textView.text = ((GridItemButtonTextData)gridItemData).Text;
            borderImage.SetActive(((GridItemButtonTextData)gridItemData).IsImageBorderVisible);

            Color color = gridItemData.CellStatus == CellStatus.Filled ? Color.black : Color.white;
            color.a = gridItemData.IsImageAlpha100 ? 1.0f : alphaValueForImage;
            textView.color = color;
        }

        public void UpdateText(string text)
        {
            textView.text = text;
        }
    }
}