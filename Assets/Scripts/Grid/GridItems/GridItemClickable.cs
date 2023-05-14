using Data;
using Grid.GridData;
using Grid.GridFillers;
using UnityEngine;
using UnityEngine.UI;

namespace Grid.GridItems
{
    public class GridItemClickable : GridItem
    {
        [SerializeField] protected Button button;

        
        public override void UpdateCellData(GridItemData gridItemData)
        {
            base.UpdateCellData(gridItemData);
            button.enabled = ((GridItemButtonData)gridItemData).IsButtonActive;
        }

        public virtual void OnButtonClickedGUI()
        {
            ((GridFillerClickable)gridFiller).OnChildButtonClicked(this);
        }
        
        public Button Button => button;
    }
}