using UnityEngine.UI;

namespace Grid.GridItems
{
    public class GridItemClickable : GridItem
    {
        private Button button;

        protected override void Awake()
        {
            base.Awake();
            button = GetComponent<Button>();
        }
        
        public void UpdateCellData(GridItemUpdateData.GridItemUpdateData updateData)
        {
            base.UpdateCellStatus(updateData);
            AfterUpdateCellData(updateData);
        }

        protected virtual void AfterUpdateCellData(GridItemUpdateData.GridItemUpdateData updateData)
        {
            button.enabled = currentCellStatus is CellStatus.Filled or CellStatus.SelectedByPlayer;
        }
        

        protected virtual void OnButtonClickedGUI()
        {
            currentCellStatus = currentCellStatus == CellStatus.SelectedByPlayer
                ? CellStatus.Filled
                : CellStatus.SelectedByPlayer;
            image.sprite = currentCellStatus == CellStatus.SelectedByPlayer ? selectedImage : filledImage;

            if (playerLevel != null)
            {
                playerLevel.SetGridValue(point, currentCellStatus == CellStatus.Filled);
            }
        }
        
    }
}