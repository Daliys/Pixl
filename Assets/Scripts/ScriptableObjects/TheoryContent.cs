using Localization;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "theoryContent", menuName = "Custom/Theory Content")]
    public class TheoryContent : ScriptableObject
    {
        public Sprite ruSprite;
        public Sprite enSprite;
        public Sprite esSprite;
        
        public Sprite GetSpriteByLanguage(LocalizationManager.Language language)
        {
            switch (language)
            {
                case LocalizationManager.Language.en:
                    return enSprite;
                case LocalizationManager.Language.ru:
                    return ruSprite;
                case LocalizationManager.Language.es:
                    return esSprite;
                default:
                    return null;
            }
        }
    }
}