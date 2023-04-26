
using Grid.GridFillers;
using Grid.GridItems;

namespace Grid
{
    public class PreviousGridFiller : GridFiller
    {
 
        protected override void InitializeGridItem(GridItem gridItem, Point point)
        {
            gridItem.Initialize(point);
        }

        public void UpdatePreviousStepGrid()
        {
            UpdateGridBy(uiController.PlayerLevel.GetPreviousGridItemStatus);
        }

        public void UpdateByCorrectAnswer()
        {
            UpdateGridBy(GetCellStatusByCorrectAnswer);
        }

        private GridItemUpdateData.GridItemUpdateData GetCellStatusByCorrectAnswer(Point point)
        {
            int currentIteration = uiController.PlayerLevel.GetCurrentIteration() - 1;
            return new GridItemUpdateData.GridItemUpdateData(uiController.LevelSolver.GetCellStatusAtPoint(point, currentIteration));
        }

    }
}
