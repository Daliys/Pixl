using System;
using Localization;
using UnityEngine;

namespace MenuUI
{
    public class SettingUI : MonoBehaviour
    {
        [SerializeField] private GameObject aboutAppPanel;
        
        [SerializeField] private LanguageButton englishLanguageButton;
        [SerializeField] private LanguageButton spanishLanguageButton2;
        [SerializeField] private LanguageButton russianLanguageButton3;
        
        public void Initialize()
        {
            UpdateButtons();
        }


        public void UpdateButtons()
        {
            englishLanguageButton.SetActive(LocalizationManager.GetCurrentLanguage() == LocalizationManager.Language.en);
            spanishLanguageButton2.SetActive(LocalizationManager.GetCurrentLanguage()== LocalizationManager.Language.es);
            russianLanguageButton3.SetActive(LocalizationManager.GetCurrentLanguage() == LocalizationManager.Language.ru);
        }

        public void OnButtonAboutAppClicked()
        {
            aboutAppPanel.SetActive(true);
        }

    }
}