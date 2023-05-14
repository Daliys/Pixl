using UnityEngine;

namespace UI
{
    public class UIController : MonoBehaviour
    {


        [SerializeField] private GameObject bottomPanel;
        [SerializeField] private GameObject levelPrefab;
        [SerializeField] private GameObject backgroundPanel;

        [SerializeField] private AbstractUILevel level;


        private void Awake()
        {
            //GameObject gm = Instantiate(levelPrefab, transform);
            levelPrefab.GetComponent<AbstractUILevel>().InitializeOnAwake();
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

        public void NewGame()
        {
            
        }

        public void SetActiveBottomPanel(bool isActive)
        {
            bottomPanel.SetActive(isActive);
        }
     
        public AbstractUILevel Level => level;

    }
}