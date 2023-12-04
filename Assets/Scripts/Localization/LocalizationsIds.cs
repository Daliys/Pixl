using System;

namespace Localization
{
    /// <summary>
    /// This class contains all available localizations ids
    /// </summary>
    [System.Serializable]
    public class LocalizationsIds
    {
        /// <summary>
        /// The value of the localization id
        /// </summary>
        public string value;
        
        public static readonly LocalizationsIds MainMenuName = new() { value = "main_menu_name" };
        public static readonly LocalizationsIds MainMenuPracticeButton = new() { value = "main_menu_practice_button" };
        public static readonly LocalizationsIds MainMenuSettingsButton = new() { value = "main_menu_settings_button" };
        public static readonly LocalizationsIds MainMenuTheoryButton = new() { value = "main_menu_theory_button" };
        public static readonly LocalizationsIds MainMenuTestButton = new() { value = "main_menu_test_button" };
        public static readonly LocalizationsIds MainMenuAboutButton = new() { value = "main_menu_about_button" };
        public static readonly LocalizationsIds MainMenuSettingsLanguage = new() { value = "main_menu_settings_language" };
        
        
        public static readonly LocalizationsIds CardSmudgingEuclideanDistance = new() { value = "card_smudging_euclidean_distance" };
        public static readonly LocalizationsIds CardSmudgingCityDistance = new() { value = "card_smudging_city_distance" };
        public static readonly LocalizationsIds CardSmudgingChessboardDistance = new() { value = "card_smudging_chessboard_distance" };
        public static readonly LocalizationsIds CardFilteringErosion = new() { value = "card_filtering_erosion" };
        public static readonly LocalizationsIds CardFilteringDilation = new() { value = "card_filtering_dilation" };
        public static readonly LocalizationsIds CardZhangSuenMethod = new() { value = "card_zhang_suen_method" };
        
    
        public static readonly LocalizationsIds TestCardConceptAndDefinition = new() { value = "test_card_concept_and_definition" };
        public static readonly LocalizationsIds TestCardBinaryImages = new() { value = "test_card_binary_images" };
        public static readonly LocalizationsIds TestCardGrayscaleImages= new() { value = "test_card_grayscale_images" };
        public static readonly LocalizationsIds TestCardBinarizationOfGrayscaleImages= new() { value = "test_card_binarization_of_grayscale_images" };
        public static readonly LocalizationsIds TestCardColorModels= new() { value = "test_card_color_models" };
        public static readonly LocalizationsIds TestCardImageFiltering= new() { value = "test_card_image_filtering" };
        public static readonly LocalizationsIds TestCardSegmentation = new() { value = "test_card_segmentation" };
        public static readonly LocalizationsIds TestCardTextureAnalysis = new() { value = "test_card_texture_analysis" };
        public static readonly LocalizationsIds TestCardImageThinning = new() { value = "test_card_image_thinning" };




        public static LocalizationsIds[] GetAllValues()
        {
            return new[]
            {
                MainMenuName,
                MainMenuPracticeButton,
                MainMenuSettingsButton,
                MainMenuTheoryButton,
                MainMenuTestButton,
                MainMenuAboutButton,
                MainMenuSettingsLanguage,
                CardSmudgingEuclideanDistance,
                CardSmudgingCityDistance,
                CardSmudgingChessboardDistance,
                CardFilteringErosion,
                CardFilteringDilation,
                CardZhangSuenMethod,
                TestCardConceptAndDefinition,
                TestCardBinaryImages,
                TestCardGrayscaleImages,
                TestCardBinarizationOfGrayscaleImages,
                TestCardColorModels,
                TestCardImageFiltering,
                TestCardSegmentation,
                TestCardTextureAnalysis,
                TestCardImageThinning
            };
        }
        

    }

}