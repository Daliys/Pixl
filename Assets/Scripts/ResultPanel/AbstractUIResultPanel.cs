using Data;
using Grid.GridData;
using TMPro;
using UnityEngine;
using Localization;

namespace ResultPanel
{
    public abstract class AbstractUIResultPanel : MonoBehaviour
    {
        [SerializeField] protected TextMeshProUGUI header;
        [SerializeField] protected TextMeshProUGUI description1;
        [SerializeField] protected TextMeshProUGUI description2;
        [SerializeField] protected GameObject backButton;
        [SerializeField] protected GameObject againButton;

        [SerializeField] protected Color whiteColor;
        [SerializeField] protected Color yellowColor;
        
        public virtual void InitializeStartPanel(ResultStatus status)
        {
            header.text = LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultHeader.value);
            backButton.SetActive(false);
            againButton.SetActive(true);

            if (status.Equals(ResultStatus.Correct))
            {
                header.color = whiteColor;

                description1.text = LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultAllCorrect.value);
                description1.color = whiteColor;
                description2.enabled = false;
            }
            else
            {
                header.color = yellowColor;

                description1.text = LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultMistakeMade.value);
                description1.color = yellowColor;

                description2.enabled = true;
                description2.text = LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultExplanation2.value);
                description2.color = whiteColor;
            }
        }

        public abstract void InitializeErrorDescriptionPanel(GridItemData correctUpdateData, GridItemData playerUpdateData);

        public void OnButtonBackClicked()
        {
            Reference.reference.UIController.Level.OnButtonBackExplanationPanelClicked();
        }
    }
}