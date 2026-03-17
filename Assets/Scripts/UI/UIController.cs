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
            Sprite sprite = cardModelPractice.theoryContent.GetSpriteByLanguage(Localization.LocalizationManager.GetCurrentLanguage());
            wikiImage.sprite = sprite;
            wikiImage.preserveAspect = true;
            wikiImage.SetNativeSize();
            
            RectTransform rect = wikiImage.rectTransform;
            // Set anchors to Top-Stretch
            rect.anchorMin = new Vector2(0, 1);
            rect.anchorMax = new Vector2(1, 1);
            rect.pivot = new Vector2(0.5f, 1);
            
            // Calculate height based on parent width to maintain aspect ratio with Left/Right 0
            float parentWidth = ((RectTransform)rect.parent).rect.width;
            float ratio = sprite.rect.height / sprite.rect.width;
            float targetHeight = parentWidth * ratio;
            
            // Set sizeDelta (x=0 means stretch to anchors, y=calculated height)
            rect.sizeDelta = new Vector2(0, targetHeight);
            rect.anchoredPosition = Vector2.zero;
        }

        public void SetActiveBottomPanel(bool isActive)
        {
            bottomPanel.SetActive(isActive);
        }
     
        public AbstractUILevel Level => level;

    }
}