using Data;
using Grid.GridData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIResultPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bottomExplanation;
    [SerializeField] private TextMeshProUGUI header;
    [SerializeField] private TextMeshProUGUI description1;
    [SerializeField] private TextMeshProUGUI description2;
    [SerializeField] private TextMeshProUGUI yourAnswer;
    [SerializeField] private TextMeshProUGUI correctAnswer;
    [SerializeField] private Image arrowImage;
    [SerializeField] private GameObject backButton;
   
    [SerializeField] private Color whiteColor;
    [SerializeField] private Color yellowColor;
    
    
    private ResultStatus resultStatus;
    
    private void Awake()
    {
        InitializeStartPanel(ResultStatus.WrongValue);
    }

    public void InitializeStartPanel(ResultStatus status)
    {
        bottomExplanation.enabled = false;
        header.text = "результат";
        yourAnswer.enabled = false;
        correctAnswer.enabled = false;
        arrowImage.enabled = false;
        backButton.SetActive(false);

        print(status);
        if (status.Equals( ResultStatus.Correct))
        {
            header.color = whiteColor;
            
            description1.text = "все верно";
            description1.color = whiteColor;
            description2.enabled = false;
        }
        else
        {
            header.color = yellowColor;

            description1.text = "допущена ошибка";
            description1.color = yellowColor;

            description2.enabled = true;
            description2.text = "Ошибка обозначена жёлтым пикселем '!' \nДля просмотра нажмите на него";
            description2.color = whiteColor;
        }
    }

    public void InitializeErrorDescriptionPanel(GridItemData correctUpdateData, GridItemData playerUpdateData )
    {
        if (correctUpdateData is GridItemButtonTextData)
        {

            string correctAnswerStr = ((GridItemButtonTextData)correctUpdateData).Text;
            string userAnswerStr = ((GridItemButtonTextData)playerUpdateData).Text;
            
            header.color = whiteColor;
            
            description1.text = "допущена ошибка";
            description1.color = yellowColor;

            description2.text =
                "В выбранном поле вы ввели неверный результат, вместо этого необходимо было указать следующее значение:";
            description2.color = whiteColor;

            bottomExplanation.text = "Пиксель жёлтого цвета указывает \nна ближайший противоположный пиксель";
            bottomExplanation.color = yellowColor;
            bottomExplanation.enabled = true;
            
            backButton.SetActive(true);
            
            
            yourAnswer.enabled = true;
            correctAnswer.enabled = true;
            arrowImage.enabled = true;

            yourAnswer.text = userAnswerStr;
            yourAnswer.color = whiteColor;
            correctAnswer.text = correctAnswerStr;
            correctAnswer.color = yellowColor;
        }
    }

    public void OnButtonBackClicked()
    {
        Reference.reference.UIController.Level.OnButtonBackExplanationPanelClicked();
    }
    
}
