using System.Collections.Generic;
using Data;
using ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Localization;

namespace MenuUI
{
    public class TestPage : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI currentIndexText;
        [SerializeField] private TextMeshProUGUI totalIndexText;
        
        [SerializeField] private TextMeshProUGUI questionText;
        [SerializeField] private Image questionImage;

        [SerializeField] private TestAnswerButton button1;
        [SerializeField] private TestAnswerButton button2;
        [SerializeField] private TestAnswerButton button3;

        [SerializeField] private GameObject nextButton;
        [SerializeField] private TextMeshProUGUI nextButtonText;

        [SerializeField] private Color correctButtonColor;
        [SerializeField] private Color wrongButtonColor;

        [SerializeField] private GameObject resultPanel;
        [SerializeField] private TextMeshProUGUI resultCorrectText;
        [SerializeField] private TextMeshProUGUI resultWrongText;

        private int _correctAnswers; 
        private int _wrongAnswers; 
        
        private QuestionsDataList _questionsDataList;
        private QuestionData[] _randomSortedQuestions;
        private int _currentIndex;

        private bool _isTestFinished;

        public void Initialize(QuestionsDataList questionsDataList)
        {
            _questionsDataList = questionsDataList;
            
            List<QuestionData> temp = new List<QuestionData>();
            temp.AddRange(_questionsDataList.questions);

            _randomSortedQuestions = new QuestionData[temp.Count];
            
            for (int i = 0; i < _randomSortedQuestions.Length; i++)
            {
                int randomIndex = Random.Range(0, temp.Count);
                _randomSortedQuestions[i] = temp[randomIndex];
                temp.RemoveAt(randomIndex);
            }
            
            button1.Initialize(OnButtonClicked);
            button2.Initialize(OnButtonClicked);
            button3.Initialize(OnButtonClicked);
            nextButton.SetActive(false);
            _currentIndex = 0;
            _correctAnswers = 0;
            _wrongAnswers = 0;
            _isTestFinished = false;
            
            resultPanel.gameObject.SetActive(false);
            nextButton.SetActive(false);
            ResetButtons();
            InitializeQuestion(_randomSortedQuestions[_currentIndex]);
        }

        private void InitializeQuestion(QuestionData questionData)
        {
            currentIndexText.text = (_currentIndex + 1).ToString("D2");
            totalIndexText.text = "/ " + _randomSortedQuestions.Length;

            if (questionData.questionText == null || string.IsNullOrEmpty(questionData.questionText.value))
                questionText.gameObject.SetActive(false);
            else
            {
                questionText.gameObject.SetActive(true);
                questionText.text = LocalizationManager.GetLocalizationValue(questionData.questionText.value);
            }

            if (questionData.questionImage == null) questionImage.gameObject.SetActive(false);
            else
            {
                questionImage.gameObject.SetActive(true);
                questionImage.sprite = questionData.questionImage;
                questionImage.preserveAspect = true;
            }

            InitializeAnswerButton(button1, questionData.answerOptions, 0);
            InitializeAnswerButton(button2, questionData.answerOptions, 1);
            InitializeAnswerButton(button3, questionData.answerOptions, 2);
        }

        private void InitializeAnswerButton(TestAnswerButton button, AnswerOption[] options, int index)
        {
            if (options != null && index < options.Length)
            {
                button.gameObject.SetActive(true);
                AnswerOption option = options[index];
                if (option.answerImage == null)
                {
                    string locKey = (option.answerText != null) ? option.answerText.value : string.Empty;
                    button.SetButtonValue(LocalizationManager.GetLocalizationValue(locKey));
                }
                else
                {
                    button.SetButtonValue(option.answerImage);
                }
            }
            else
            {
                button.gameObject.SetActive(false);
            }
        }

        private void OnButtonClicked(int index)
        {
            int correctIndex = _randomSortedQuestions[_currentIndex].correctAnswerIndex;
            if (correctIndex == index)
            {
                GetButton(index).gameObject.GetComponent<Image>().color = correctButtonColor;
                _correctAnswers++;
            }
            else
            {
                GetButton(index).gameObject.GetComponent<Image>().color = wrongButtonColor;
                GetButton(correctIndex).gameObject.GetComponent<Image>().color = correctButtonColor;
                _wrongAnswers++;
            }
            
            button1.gameObject.GetComponent<Button>().enabled = false;
            button2.gameObject.GetComponent<Button>().enabled = false;
            button3.gameObject.GetComponent<Button>().enabled = false;
            nextButton.SetActive(true);

            nextButtonText.text = (_currentIndex + 1) != _randomSortedQuestions.Length
                ? LocalizationManager.GetLocalizationValue(LocalizationsIds.TestNextQuestion.value)
                : LocalizationManager.GetLocalizationValue(LocalizationsIds.TestResult.value);
        }

        public void OnButtonNextClicked()
        {

            if (_isTestFinished)
            {
                Initialize(_questionsDataList);
                return;
            }
            
            if (_currentIndex + 1 == _randomSortedQuestions.Length)
            {
                resultPanel.gameObject.SetActive(true);
                resultCorrectText.text = _correctAnswers.ToString();
                resultWrongText.text = _wrongAnswers.ToString();
                nextButtonText.text = LocalizationManager.GetLocalizationValue(LocalizationsIds.TestRepeat.value);
                _isTestFinished = true;
                return;
            }
            
            _currentIndex++;
            InitializeQuestion(_randomSortedQuestions[_currentIndex]);
            ResetButtons();
            nextButton.SetActive(false);
        }


        private void ResetButtons()
        {
            button1.gameObject.GetComponent<Image>().color = Color.white;
            button2.gameObject.GetComponent<Image>().color = Color.white;
            button3.gameObject.GetComponent<Image>().color = Color.white;

            button1.gameObject.GetComponent<Button>().enabled = true;
            button2.gameObject.GetComponent<Button>().enabled = true;
            button3.gameObject.GetComponent<Button>().enabled = true;
        }
         

        private TestAnswerButton GetButton(int index)
        {
            switch (index)
            {
                case 0: return button1;
                case 1: return button2;
                case 2: return button3;
            }

            return null;
        }
        
    }
}