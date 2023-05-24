using UnityEngine;

namespace MenuUI
{
    public abstract class AbstractCardsUI : MonoBehaviour
    {
        [SerializeField] protected GameObject cardPrefab;
        [SerializeField] protected GameObject contentPanel;
        
        protected bool isInitialize;
        
        public abstract void Initialize();
        protected abstract void OnButtonCardClicked(int index);
    }

}