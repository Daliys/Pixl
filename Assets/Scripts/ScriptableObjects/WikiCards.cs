using Data.CardsModel;
using Unity.VisualScripting;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "wikiCards", menuName = "Custom/Wiki Cards")]
    public class WikiCards : ScriptableObject
    {
        [SerializeField]
        public CardModelWiki[] models;
    }
}