using System;
using UnityEngine;
using Localization;

namespace Data
{
    [Serializable]
    public class QuestionData
    {
        public LocalizationsIds questionText;
        public Sprite questionImage;
        public AnswerOption[] answerOptions;
        public int correctAnswerIndex;
    }

    [Serializable]
    public class AnswerOption
    {
        public LocalizationsIds answerText;
        public Sprite answerImage;
    }
}