using Data;
using Grid.GridData;

namespace ResultPanel
{
    public class UIResultPanel8 : UIResultPanel7
    {
        public override void InitializeErrorDescriptionPanel(GridItemData correctUpdateData, GridItemData playerUpdateData)
        {
            header.color = whiteColor;
            description1.text = "допущена ошибка";
            description1.color = yellowColor;
            
            string resultStatus = correctUpdateData.CellStatus == CellStatus.SelectedBlack
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