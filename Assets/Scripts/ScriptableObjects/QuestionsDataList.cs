using Data;
using Unity.VisualScripting;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "QuestionsData", menuName = "Custom/Question Data")]
    public class QuestionsDataList : ScriptableObject
    {
        [Serialize]
        public QuestionData[] questions;
    }
}