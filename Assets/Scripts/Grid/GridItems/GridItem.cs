using UnityEngine;
using UnityEngine.UI;

namespace Grid.GridItems
{
    public class GridItem : MonoBehaviour
    {
        [SerializeField] protected Point point;
        protected Image image;
    
        [SerializeField] protected Sprite emptyImage;
        [SerializeField] protected Sprite filledImage;
        [SerializeField] protected Sprite selectedImage;
    
        protected PlayerLevel playerLevel;

        public enum CellStatus
        {
            SelectedByPlayer,
            Empty,
            Filled,
            ResultCorrectSelected,
            ResultWrongSelectedShouldBeFilled,
            ResultWrongSelectedShouldBeEmpty
        }

        protected CellStatus currentCellStatus;

        protected virtual void Awake()
        {
            image = GetComponent<Image>();
        }
    

        public virtual void UpdateCellStatus(GridItemUpdateData.GridItemUpdateData updateData)
        {
            currentCellStatus = updateData.cellStatus;

            image.sprite = currentCellStatus switch
            {
                CellStatus.SelectedByPlayer => selectedImage,
                CellStatus.Empty => emptyImage,
                CellStatus.Filled => filledImage,
                CellStatus.ResultCorrectSelected => filledImage,
                CellStatus.ResultWrongSelectedShouldBeFilled => selectedImage,
                CellStatus.ResultWrongSelectedShouldBeEmpty => selectedImage,
                _ => image.sprite
            };
        }

        public void Initialize(Point point, PlayerLevel playerLevel = null)
        {
            this.point = point;
            this.playerLevel = playerLevel;
        }

        public Point Point => point;

  

        public CellStatus CurrentCellStatus => currentCellStatus;

    }
}
