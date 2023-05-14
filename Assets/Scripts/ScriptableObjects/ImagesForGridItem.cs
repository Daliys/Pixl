using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ImagesForGridItem", menuName = "CustomData/ImagesForGridItem")]
    public class ImagesForGridItem : ScriptableObject
    {
        public Sprite emptyImage;
        public Sprite filledImage;
        public Sprite selectedImage;
        public Sprite warningImage;
    }
}