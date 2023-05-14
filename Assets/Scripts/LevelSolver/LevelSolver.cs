using Data;
using Grid.GridData;
using Grid.GridItems;

namespace LevelSolver
{
    public abstract class LevelSolver : LevelBase
    {

        public virtual void Initialize(bool[,] startingGrid)
        {
            //Change Lenght 
            gridSize = new Point(startingGrid.GetLength(0), startingGrid.GetLength(1));
            grid = new bool[gridSize.x, gridSize.y];
            grid = startingGrid.Clone() as bool[,];

        }

        protected abstract void StartSolving();


        public virtual GridItemData GetGridItemDataAtPoint(Point point)
        {
            bool value = grid[point.x, point.y];
            CellStatus cellStatus = value ? CellStatus.Filled : CellStatus.Empty;
            return new GridItemData{CellStatus = cellStatus};
        }

    }
}