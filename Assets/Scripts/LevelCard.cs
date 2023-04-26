using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelCard : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI levelNameText;
    [SerializeField] private TextMeshProUGUI levelNumberText;
    [SerializeField] private TextMeshProUGUI levelDescriptionText;

    public enum LeverCardType
    {
        WIKI,
        GAME
    }

    [SerializeField] private LeverCardType leverCardType;
    
    public void OnButtonClicked()
    {

        switch (leverCardType)
        {
            case LeverCardType.WIKI:
                break;
            case LeverCardType.GAME:
                OpenGame();
                break;
        }
    
    }

    private void OpenGame()
    {
        Reference.reference.GameCanvas.gameObject.SetActive(true);
        Reference.reference.UIController.NewGame();
        Reference.reference.MainMenuCanvas.gameObject.SetActive(false);
    }
}
