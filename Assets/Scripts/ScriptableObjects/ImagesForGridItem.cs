using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ImagesForGridItem", menuName = "Custom/ImagesForGridItem")]
    public class ImagesForGridItem : ScriptableObject
    {
        public Sprite emptyImage;
        public Sprite filledImage;
        public Sprite selectedImage;
        public Sprite selectedWhite;
        public Sprite selectedBlack;
        public Sprite selectedYellow;
        public Sprite warningImage;
    }
}