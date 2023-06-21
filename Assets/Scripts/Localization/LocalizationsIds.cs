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
        
        
        public static readonly LocalizationsIds CardSmudgingEuclideanDistance = new() { value = "card_smudging_euclidean_distance" };
        public static readonly LocalizationsIds CardSmudgingCityDistance = new() { value = "card_smudging_city_distance" };
        public static readonly LocalizationsIds CardSmudgingChessboardDistance = new() { value = "card_smudging_chessboard_distance" };
        public static readonly LocalizationsIds CardFilteringErosion = new() { value = "card_filtering_erosion" };
        public static readonly LocalizationsIds CardFilteringDilation = new() { value = "card_filtering_dilation" };
        public static readonly LocalizationsIds CardZhangSuenMethod = new() { value = "card_zhang_suen_method" };
        
        
        public static readonly LocalizationsIds WikiCardImagesAndDefinitionName = new() { value = "wiki_card_images_and_definition_name" };
        public static readonly LocalizationsIds WikiCardImagesAndDefinitionDescription = new() { value = "wiki_card_images_and_definition_description" };
        public static readonly LocalizationsIds WikiCardBinaryImagesName = new() { value = "wiki_card_binary_images_name" };
        public static readonly LocalizationsIds WikiCardBinaryImagesDescription = new() { value = "wiki_card_binary_images_description" };
        public static readonly LocalizationsIds WikiCardGrayscaleImagesName = new() { value = "wiki_card_grayscale_images_name" };
        public static readonly LocalizationsIds WikiCardGrayscaleImagesDescription = new() { value = "wiki_card_grayscale_images_description" };
        public static readonly LocalizationsIds WikiCardBinarizationGrayscaleImagesName = new() { value = "wiki_card_binarization_grayscale_images_name" };
        public static readonly LocalizationsIds WikiCardBinarizationGrayscaleImagesDescription = new() { value = "wiki_card_binarization_grayscale_images_description" };
        public static readonly LocalizationsIds WikiCardColorModelsName = new() { value = "wiki_card_color_models_name" };
        public static readonly LocalizationsIds WikiCardColorModelsDescription = new() { value = "wiki_card_color_models_description" };
        public static readonly LocalizationsIds WikiCardImageContrastAdjustmentName = new() { value = "wiki_card_image_contrast_adjustment_name" };
        public static readonly LocalizationsIds WikiCardImageContrastAdjustmentDescription = new() { value = "wiki_card_image_contrast_adjustment_description" };
        public static readonly LocalizationsIds WikiCardImageThinningName = new() { value = "wiki_card_image_thinning_name" };
        public static readonly LocalizationsIds WikiCardImageThinningDescription = new() { value = "wiki_card_image_thinning_description" };
        public static readonly LocalizationsIds WikiCardImageFilteringName = new() { value = "wiki_card_image_filtering_name" };
        public static readonly LocalizationsIds WikiCardImageFilteringDescription = new() { value = "wiki_card_image_filtering_description" };
        public static readonly LocalizationsIds WikiCardWaveletTransformName = new() { value = "wiki_card_wavelet_transform_name" };
        public static readonly LocalizationsIds WikiCardWaveletTransformDescription = new() { value = "wiki_card_wavelet_transform_description" };
        public static readonly LocalizationsIds WikiCardSegmentationName = new() { value = "wiki_card_segmentation_name" };
        public static readonly LocalizationsIds WikiCardSegmentationDescription = new() { value = "wiki_card_segmentation_description" };
        public static readonly LocalizationsIds WikiCardEdgeEnhancementName = new() { value = "wiki_card_edge_enhancement_name" };
        public static readonly LocalizationsIds WikiCardEdgeEnhancementDescription = new() { value = "wiki_card_edge_enhancement_description" };
        public static readonly LocalizationsIds WikiCardTextureAnalysis = new() { value = "wiki_card_texture_analysis" };
        public static readonly LocalizationsIds WikiCardTextureAnalysisDescription = new() { value = "wiki_card_texture_analysis_description" };
        public static readonly LocalizationsIds WikiCardContourDetectionName = new() { value = "wiki_card_contour_detection_name" };
        public static readonly LocalizationsIds WikiCardContourDetectionDescription = new() { value = "wiki_card_contour_detection_description" };

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
                CardSmudgingEuclideanDistance,
                CardSmudgingCityDistance,
                CardSmudgingChessboardDistance,
                CardFilteringErosion,
                CardFilteringDilation,
                CardZhangSuenMethod,
                WikiCardImagesAndDefinitionName,
                WikiCardImagesAndDefinitionDescription,
                WikiCardBinaryImagesName,
                WikiCardBinaryImagesDescription,
                WikiCardGrayscaleImagesName,
                WikiCardGrayscaleImagesDescription,
                WikiCardBinarizationGrayscaleImagesName,
                WikiCardBinarizationGrayscaleImagesDescription,
                WikiCardColorModelsName,
                WikiCardColorModelsDescription,
                WikiCardImageContrastAdjustmentName,
                WikiCardImageContrastAdjustmentDescription,
                WikiCardImageThinningName,
                WikiCardImageThinningDescription,
                WikiCardImageFilteringName,
                WikiCardImageFilteringDescription,
                WikiCardWaveletTransformName,
                WikiCardWaveletTransformDescription,
                WikiCardSegmentationName,
                WikiCardSegmentationDescription,
                WikiCardEdgeEnhancementName,
                WikiCardEdgeEnhancementDescription,
                WikiCardTextureAnalysis,
                WikiCardTextureAnalysisDescription,
                WikiCardContourDetectionName,
                WikiCardContourDetectionDescription,
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