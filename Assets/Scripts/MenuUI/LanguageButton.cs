using Localization;
using TMPro;
using UnityEngine;

namespace MenuUI
{
    public class LanguageButton : MonoBehaviour
    {
        [SerializeField] private Sprite activeSprite;
        [SerializeField] private Sprite inactiveSprite;
        [SerializeField] private Color textColorActive;
        [SerializeField] private Color textColorInactive;
        [SerializeField] private TextMeshProUGUI text;
        
        [SerializeField] LocalizationManager.Language language;
        [SerializeField] private SettingUI settingUi;
        
        public void SetActive(bool isActive)
        {
            if (isActive)
            {
                GetComponent<UnityEngine.UI.Image>().sprite = activeSprite;
                text.color = textColorActive;
            }
            else
            {
                GetComponent<UnityEngine.UI.Image>().sprite = inactiveSprite;
                text.color = textColorInactive;
            }
        }
        
        public void OnButtonClicked()
        {
            LocalizationManager.SetLanguage(language);
            settingUi.UpdateButtons();
        }
    }
}