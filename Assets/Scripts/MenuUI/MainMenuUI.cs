using UnityEngine;

namespace MenuUI
{
    public class MainMenuUI : MonoBehaviour
    {
        [SerializeField] private GameObject settingPanel;
        [SerializeField] private GameObject wikiPanel;
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject chooseLevelPanel;
        [SerializeField] private GameObject chooseTestPanel;

   
        public void OnWikiButtonClicked()
        {
            HideAllPanels();
            wikiPanel.SetActive(true);
            wikiPanel.GetComponent<WikiUI>().Initialize();
        }

        public void OnSettingButtonClicked()
        {
            HideAllPanels();
            settingPanel.SetActive(true);
        }

        public void OnPracticeButtonClicked()
        {
            HideAllPanels();
            chooseLevelPanel.SetActive(true);
            chooseLevelPanel.GetComponent<PracticeUI>().Initialize();
        }

        public void OnTestingButtonClicked()
        {
            HideAllPanels();
            
        }

        public void OpenMainMenuPanel()
        {
            HideAllPanels();
            menuPanel.SetActive(true);
        }
    
        private void HideAllPanels()
        {
            settingPanel.SetActive(false);
            chooseLevelPanel.SetActive(false);
            wikiPanel.SetActive(false);
            menuPanel.SetActive(false);
            chooseTestPanel.SetActive(false);
        }
    
    
    }
}
