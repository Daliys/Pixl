using Data;
using Grid.GridData;
using Grid.GridFillers;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Grid.GridItems
{
    public abstract class GridItem : MonoBehaviour
    {
        [SerializeField] protected Point point;
        [SerializeField] protected Image image;
        [SerializeField] protected ImagesForGridItem images;
        [SerializeField] protected float alphaValueForImage;
        
        protected GridFiller gridFiller;
        protected GridItemData currentGridItemData;

        
        public virtual void UpdateCellData(GridItemData gridItemData)
        {
            currentGridItemData = gridItemData;
            var alpha = gridItemData.IsImageAlpha100 ? 1.0f : alphaValueForImage;
            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);

            image.sprite = gridItemData.CellStatus switch
            {
                CellStatus.Empty => images.emptyImage,
                CellStatus.Filled => images.filledImage,
                CellStatus.Selected => images.selectedImage,
                CellStatus.Warning => images.warningImage,
                _ => image.sprite
            };
        }

        public void Initialize(Point point, GridFiller gridFiller)
        {
            this.point = point;
            this.gridFiller = gridFiller;
        }

        public Point Point => point;
        
    }
}
