using Data;
using Grid.GridData;
using TMPro;
using UnityEngine;

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
            header.text = "результат";
            backButton.SetActive(false);
            againButton.SetActive(true);

            if (status.Equals(ResultStatus.Correct))
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

        public abstract void InitializeErrorDescriptionPanel(GridItemData correctUpdateData, GridItemData playerUpdateData);

        public void OnButtonBackClicked()
        {
            Reference.reference.UIController.Level.OnButtonBackExplanationPanelClicked();
        }
    }
}