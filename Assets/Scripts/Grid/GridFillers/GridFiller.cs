using Grid.GridItems;
using UnityEngine;

namespace Grid.GridFillers
{
    public abstract class GridFiller : MonoBehaviour
    {
    
        [SerializeField] protected GameObject gridParent;
        [SerializeField] protected GameObject gridPrefab;
    
        protected Point gridSize;
        protected GridItem[,] gridItems;
        protected UIController uiController;
        
        public delegate GridItemUpdateData.GridItemUpdateData CellDataForUpdate(Point point);
    
        public void Initialize(Point gridSize, UIController uiController )
        {
            this.gridSize = gridSize;
            gridItems = new GridItem[gridSize.x, gridSize.y];
            this.uiController = uiController;
            SpawnGridItems();
        }
    
        private void SpawnGridItems()
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                for (int x = 0; x < gridSize.x; x++)
                {
                    GameObject gridGameObject = Instantiate(gridPrefab, gridParent.transform);
                    GridItem gridItem = gridGameObject.GetComponent<GridItem>();
                    InitializeGridItem(gridItem, new Point(x,y));
                    gridItems[x, y] = gridItem;
                }
            }
        }

        protected abstract void InitializeGridItem(GridItem gridItem, Point point);

        protected void UpdateGridBy(CellDataForUpdate cellDataForUpdate)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                for (int x = 0; x < gridSize.x; x++)
                {
                    gridItems[x,y].UpdateCellStatus(cellDataForUpdate(gridItems[x,y].Point));
                }
            }
        }


    }
}
