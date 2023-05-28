using Data;
using Grid.GridData;

namespace ResultPanel
{
    public class UIResultPanel7 : AbstractUIResultPanel
    {
        public override void InitializeErrorDescriptionPanel(GridItemData correctUpdateData,
            GridItemData playerUpdateData)
        {
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