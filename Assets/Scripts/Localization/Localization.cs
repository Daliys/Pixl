using System;
using TMPro;
using UnityEngine;

namespace Localization
{
    public class Localization : MonoBehaviour
    {
        private enum ElementType
        {
            Text,
            Button
        }
        
        [SerializeField]private ElementType elementType;
        
        [SerializeField]private LocalizationsIds localizationsIds;
        

        private void Start()
        {
            switch (elementType)
            {
                case ElementType.Text:
                    GetComponent<TextMeshProUGUI>().text = LocalizationManager.GetLocalizationValue(localizationsIds.value);
                    break;
                case ElementType.Button:
                    GetComponent<UnityEngine.UI.Button>().GetComponentInChildren<TextMeshProUGUI>().text = LocalizationManager.GetLocalizationValue(localizationsIds.value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}