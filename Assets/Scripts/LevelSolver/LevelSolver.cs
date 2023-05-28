using Data;
using Grid.GridData;
using UI;

namespace LevelSolver
{
    public abstract class LevelSolver : LevelBase
    {
        protected AbstractUILevel uiLevel;
        public virtual void Initialize(bool[,] startingGrid, AbstractUILevel uiLevel)
        {
            this.uiLevel = uiLevel;
            gridSize = new Point(startingGrid.GetLength(0), startingGrid.GetLength(1));
            grid = new bool[gridSize.x, gridSize.y];
            grid = startingGrid.Clone() as bool[,];

        }

        protected abstract void StartSolving();

        public abstract GridItemData[,] GetGridForResultExplanationPanel(Point point);


        public virtual GridItemData GetGridItemDataAtPoint(Point point)
        {
            bool value = grid[point.x, point.y];
            CellStatus cellStatus = value ? CellStatus.Filled : CellStatus.Empty;
            return new GridItemData{CellStatus = cellStatus};
        }

    }
}