using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject settingPanel;
    [SerializeField] private GameObject wikiPanel;
    [SerializeField] private GameObject gameModePanel;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject chooseLevelPanel;

    public void OnWikiButtonClicked()
    {
        HideAllPanels();
        wikiPanel.SetActive(true);
    }

    public void OnSettingButtonClicked()
    {
        HideAllPanels();
        settingPanel.SetActive(true);
    }

    public void OnGameModeButtonClicked()
    {
        HideAllPanels();
        gameModePanel.SetActive(true);
    }

    public void OnMenuButtonClicked()
    {
        HideAllPanels();
        menuPanel.SetActive(true);
    }

    public void OnTrainingModeButtonClicked()
    {
        HideAllPanels();
        chooseLevelPanel.SetActive(true);
    }

    public void OnBackButtonOnChooseLevelClicked()
    {
        HideAllPanels();
        gameModePanel.SetActive(true);
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
        gameModePanel.SetActive(false);
        menuPanel.SetActive(false);
    }
    
    
}
