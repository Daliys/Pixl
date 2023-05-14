using Grid.GridData;
using Grid.GridItems;
using UI;
using UnityEngine;

namespace Grid.GridFillers
{
    public abstract class GridFiller : MonoBehaviour
    {
    
        [SerializeField] protected GameObject gridParent;
        [SerializeField] protected GameObject gridPrefab;
    
        protected Point gridSize;
        protected GridItem[,] gridItems;
        protected AbstractUILevel uiLevel;

        public delegate GridItemData GridItemDataForUpdate(Point point);
 
        public void Initialize(Point gridSize, AbstractUILevel uiLevel)
        {
            this.gridSize = gridSize;
            gridItems = new GridItem[gridSize.x, gridSize.y];
            this.uiLevel = uiLevel;
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

        protected void UpdateGridBy(GridItemDataForUpdate gridItemDataForUpdate)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                for (int x = 0; x < gridSize.x; x++)
                {
                    gridItems[x,y].UpdateCellData(gridItemDataForUpdate(gridItems[x,y].Point));
                }
            }
        }
        
        protected void UpdateGridBy(GridItemData[,] data)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                for (int x = 0; x < gridSize.x; x++)
                {
                    gridItems[x,y].UpdateCellData(data[x,y]);
                }
            }
        }
        
        public AbstractUILevel UILevel => uiLevel;

    }
}
