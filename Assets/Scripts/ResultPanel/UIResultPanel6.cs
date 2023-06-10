using Data;
using Grid.GridData;
using Localization;

namespace ResultPanel
{
    public class UIResultPanel6 : AbstractUIResultPanel
    {
        public override void InitializeErrorDescriptionPanel(GridItemData correctUpdateData, GridItemData playerUpdateData)
        {
            print("here we are");
            header.color = whiteColor;
            description1.text = "допущена ошибка";
            description1.color = yellowColor;

            string resultStatus = correctUpdateData.CellStatus == CellStatus.SelectedWhite
                ? "отметить центральный пиксель"
                : "не отмечать центральный пиксель";
            description2.text =
                "В выделенном поле необходимо было " + resultStatus;

            description2.color = whiteColor;
            backButton.SetActive(true);
            againButton.SetActive(false);
        }
    }
}