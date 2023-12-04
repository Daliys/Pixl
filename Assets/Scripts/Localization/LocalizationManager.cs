using System;
using System.Collections.Generic;

using UnityEngine;

namespace Localization
{
    /// <summary>
    /// Localization manager is responsible for loading and retrieving localized text. 
    /// </summary>
    public class LocalizationManager : MonoBehaviour
    {
        private static LocalizationManager instance;

        /// <summary>
        /// The localized text of all texts in the game
        /// </summary>
        private static Dictionary<string, Dictionary<string, string>> localizedText;

        /// <summary>
        /// All available languages in the game
        /// </summary>
        public enum Language
        {
            en,
            ru,
            es
        }

        /// <summary>
        /// Current language of the game
        /// </summary>
        private static Language currentLanguage;

        public static event Action OnLanguageChanged; 

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
                return;
            }

            currentLanguage = Language.en;
            
            LoadLocalizedText();
            DontDestroyOnLoad(gameObject);
        }

        private static void LoadLocalizedText()
        {
            string filePath = "Localization/localization";
            TextAsset textAsset = Resources.Load<TextAsset>(filePath);

            if (textAsset != null)
            {
                localizedText = JsonUtility.FromJson<Dictionary<string, Dictionary<string, string>>>(textAsset.text);
            }
            else
            {
                Debug.LogError("Cannot find localization file: " + filePath);
            }
        }

        /// <summary>
        /// Retrieves the localized value for the given key. Usually key contains in <see cref="LocalizationsIds"/> class.
        /// </summary>
        /// <param name="key">The key used to retrieve the localized value.</param>
        /// <returns>The localized value associated with the given key.</returns>
        public static string GetLocalizationValue(string key)
        {
            string value = key;

            if (localizedText != null && localizedText.TryGetValue(key, out var languageValues))
            {
                if (languageValues.ContainsKey(currentLanguage.ToString()))
                {
                    value = languageValues[currentLanguage.ToString()]; 
                }
            }

            return value;
        }
        
        public static void SetLanguage(Language language)
        {
            currentLanguage = language;
            OnLanguageChanged?.Invoke();
        }
        
        public static Language GetCurrentLanguage()
        {
            return currentLanguage;
        }
        
    }
}