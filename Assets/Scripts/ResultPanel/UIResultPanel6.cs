using Data;
using Grid.GridData;
using Localization;

namespace ResultPanel
{
    public class UIResultPanel6 : AbstractUIResultPanel
    {
        public override void InitializeErrorDescriptionPanel(GridItemData correctUpdateData, GridItemData playerUpdateData)
        {
            header.color = whiteColor;
            description1.text = LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultMistakeMade.value);
            description1.color = yellowColor;

            string resultStatus = correctUpdateData.CellStatus == CellStatus.SelectedWhite
                ? LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultMarkCenter.value)
                : LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultNotMarkCenter.value);
            description2.text =
                LocalizationManager.GetLocalizationValue(LocalizationsIds.ResultMistakeDescriptionPrefix.value) + resultStatus;

            description2.color = whiteColor;
            backButton.SetActive(true);
            againButton.SetActive(false);
        }
    }
}