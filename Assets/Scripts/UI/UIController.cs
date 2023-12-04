using Data.CardsModel;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private GameObject bottomPanel;
        [SerializeField] private GameObject levelParent;
        [SerializeField] private GameObject wikiPanel;
        [SerializeField] private Image wikiImage;
        
        private GameObject createdGM;
        private AbstractUILevel level;
        private CardModelPractice cardModelPractice;

        public void Initialize(CardModelPractice cardModelPractice)
        {
            this.cardModelPractice = cardModelPractice;
            bottomPanel.SetActive(true);
            if (createdGM != null)
            {
                Destroy(createdGM);
            }
            
            createdGM = Instantiate(cardModelPractice.levelPrefab, levelParent.transform);
            level = createdGM.GetComponent<AbstractUILevel>();
            level.InitializeOnAwake();
        }

        public void StartAgainLevel()
        {
            Initialize(cardModelPractice);
        }
        

        public void OnButtonMainMenuClicked()
        {
            Reference.reference.MainMenuCanvas.gameObject.SetActive(true);
            Reference.reference.MainMenuUI.OpenMainMenuPanel();
            Reference.reference.GameCanvas.gameObject.SetActive(false);
        }

        
        public void OnButtonCheckResultClicked()
        {
            level.OnButtonCheckResultClicked();
        }

        public void OnButtonWikiClicked()
        {
            wikiPanel.SetActive(true);
            wikiImage.sprite = cardModelPractice.theoryContent.GetSpriteByLanguage(Localization.LocalizationManager.GetCurrentLanguage());
            wikiImage.preserveAspect = true;
            wikiImage.SetNativeSize();
            
            Vector3 pos = wikiImage.gameObject.transform.localPosition;
            pos.y = 0;
            wikiImage.gameObject.transform.localPosition = pos;
        }

        public void SetActiveBottomPanel(bool isActive)
        {
            bottomPanel.SetActive(isActive);
        }
     
        public AbstractUILevel Level => level;

    }
}