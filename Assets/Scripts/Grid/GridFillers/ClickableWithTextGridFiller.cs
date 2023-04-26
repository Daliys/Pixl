using Grid.GridFillers;
using Grid.GridItems;

namespace Grid
{
    public class ClickableWithTextGridFiller : GridFiller
    {
        protected override void InitializeGridItem(GridItem gridItem, Point point)
        {
            gridItem.Initialize(point, uiController.PlayerLevel);
        }


        public void UpdateGridByCorrectAnswer()
        {
            UpdateGridBy(((Level2)uiController.LevelSolver).GetCorrectDataForUpdateCell);
        }
    }
}