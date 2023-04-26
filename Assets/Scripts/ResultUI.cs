using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI headerText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI numberText;
    [SerializeField] private Image backgroundImage;

    [SerializeField] private Color normalColor;
    [SerializeField] private Color wrongColor;
    
    public void InitializeResultPanel(bool isEverythingCorrect)
    {
        if (isEverythingCorrect)
        {
            headerText.text = "all is correct";
            descriptionText.text = "you can try to play again";
            numberText.text = "";
            backgroundImage.color = normalColor;
        }
        else
        {
            headerText.text = "you made a mistake";
            descriptionText.text = "some text that will be explain why are you soo dump";
            numberText.text = "0";
            backgroundImage.color = wrongColor;
        }
    }
    
    
    public void OnAgainButtonClicked()
    {
        backgroundImage.color = normalColor;
        Reference.reference.UIController.NewGame();
    }
  

}
