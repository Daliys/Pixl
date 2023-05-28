using Data;
using Grid.GridData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ResultPanel
{
    public class UIResultPanel1 : AbstractUIResultPanel
    {
        [SerializeField] private TextMeshProUGUI bottomExplanation;
        [SerializeField] private TextMeshProUGUI yourAnswer;
        [SerializeField] private TextMeshProUGUI correctAnswer;
        [SerializeField] private Image arrowImage;

        private ResultStatus resultStatus;

        public override void InitializeStartPanel(ResultStatus status)
        {
            base.InitializeStartPanel(status);
        
            yourAnswer.enabled = false;
            correctAnswer.enabled = false;
            arrowImage.enabled = false;
            bottomExplanation.enabled = false;
        }

        public override void InitializeErrorDescriptionPanel(GridItemData correctUpdateData, GridItemData playerUpdateData )
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
                againButton.SetActive(false);
                
                yourAnswer.enabled = true;
                correctAnswer.enabled = true;
                arrowImage.enabled = true;

                yourAnswer.text = userAnswerStr;
                yourAnswer.color = whiteColor;
                correctAnswer.text = correctAnswerStr;
                correctAnswer.color = yellowColor;
            }
        }

    }
}
