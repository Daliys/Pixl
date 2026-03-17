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
        public static readonly LocalizationsIds Correct = new() { value = "correct" };
        public static readonly LocalizationsIds Incorrect = new() { value = "incorrect" };
        public static readonly LocalizationsIds Menu = new() { value = "menu" };
        public static readonly LocalizationsIds Algorithm = new() { value = "algorithm" };
        public static readonly LocalizationsIds Check = new() { value = "check" };
        public static readonly LocalizationsIds Repeat = new() { value = "repeat" };
        public static readonly LocalizationsIds T1Smudging = new() { value = "t1_smudging" };
        public static readonly LocalizationsIds T1EuclideanDistance = new() { value = "t1_euclidean_distance" };
        public static readonly LocalizationsIds T1BinaryToHalftone = new() { value = "t1_binary_to_halftone" };
        public static readonly LocalizationsIds T2CityDistance = new() { value = "t2_city_distance" };
        public static readonly LocalizationsIds T2CityDistanceDescription = new() { value = "t2_city_distance_description" };
        public static readonly LocalizationsIds T3ChessboardDistance = new() { value = "t3_chessboard_distance" };
        public static readonly LocalizationsIds T3ChessboardDistanceDescription = new() { value = "t3_chessboard_distance_description" };
        public static readonly LocalizationsIds T4Thinning = new() { value = "t4_thinning" };
        public static readonly LocalizationsIds T4ZhangSuenMethod = new() { value = "t4_zhang_suen_method" };
        public static readonly LocalizationsIds T4MarkRemovalDescription = new() { value = "t4_mark_removal_description" };
        public static readonly LocalizationsIds T5Filtering = new() { value = "t5_filtering" };
        public static readonly LocalizationsIds T5Erosion = new() { value = "t5_erosion" };
        public static readonly LocalizationsIds T5ErosionDescription = new() { value = "t5_erosion_description" };
        public static readonly LocalizationsIds T5ErosionLeavePixelsDescription = new() { value = "t5_erosion_leave_pixels_description" };
        public static readonly LocalizationsIds T6Expansion = new() { value = "t6_expansion" };
        public static readonly LocalizationsIds T6ExpansionDescription = new() { value = "t6_expansion_description" };
        public static readonly LocalizationsIds T6ExpansionAddPixelsDescription = new() { value = "t6_expansion_add_pixels_description" };
        
        
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
        public static readonly LocalizationsIds ResultAllCorrect = new() { value = "result_all_correct" };
        public static readonly LocalizationsIds ResultExplanation1 = new() { value = "result_explanation_1" };
        public static readonly LocalizationsIds ResultExplanation2 = new() { value = "result_explanation_2" };
        public static readonly LocalizationsIds ResultHeader = new() { value = "result_header" };
        public static readonly LocalizationsIds ResultMarkCenter = new() { value = "result_mark_center" };
        public static readonly LocalizationsIds ResultMistakeDescription1 = new() { value = "result_mistake_description_1" };
        public static readonly LocalizationsIds ResultMistakeDescriptionPrefix = new() { value = "result_mistake_description_prefix" };
        public static readonly LocalizationsIds ResultMistakeMade = new() { value = "result_mistake_made" };
        public static readonly LocalizationsIds ResultNotMarkCenter = new() { value = "result_not_mark_center" };
        public static readonly LocalizationsIds TestNextQuestion = new() { value = "test_next_question" };
        public static readonly LocalizationsIds TestQ1Q10A1Text = new() { value = "test_q1_q10_a1_text" };
        public static readonly LocalizationsIds TestQ1Q10A2Text = new() { value = "test_q1_q10_a2_text" };
        public static readonly LocalizationsIds TestQ1Q10A3Text = new() { value = "test_q1_q10_a3_text" };
        public static readonly LocalizationsIds TestQ1Q10Text = new() { value = "test_q1_q10_text" };
        public static readonly LocalizationsIds TestQ1Q1A1Text = new() { value = "test_q1_q1_a1_text" };
        public static readonly LocalizationsIds TestQ1Q1A2Text = new() { value = "test_q1_q1_a2_text" };
        public static readonly LocalizationsIds TestQ1Q1A3Text = new() { value = "test_q1_q1_a3_text" };
        public static readonly LocalizationsIds TestQ1Q1Text = new() { value = "test_q1_q1_text" };
        public static readonly LocalizationsIds TestQ1Q2A1Text = new() { value = "test_q1_q2_a1_text" };
        public static readonly LocalizationsIds TestQ1Q2A2Text = new() { value = "test_q1_q2_a2_text" };
        public static readonly LocalizationsIds TestQ1Q2A3Text = new() { value = "test_q1_q2_a3_text" };
        public static readonly LocalizationsIds TestQ1Q2Text = new() { value = "test_q1_q2_text" };
        public static readonly LocalizationsIds TestQ1Q3A1Text = new() { value = "test_q1_q3_a1_text" };
        public static readonly LocalizationsIds TestQ1Q3A2Text = new() { value = "test_q1_q3_a2_text" };
        public static readonly LocalizationsIds TestQ1Q3A3Text = new() { value = "test_q1_q3_a3_text" };
        public static readonly LocalizationsIds TestQ1Q3Text = new() { value = "test_q1_q3_text" };
        public static readonly LocalizationsIds TestQ1Q4A1Text = new() { value = "test_q1_q4_a1_text" };
        public static readonly LocalizationsIds TestQ1Q4A2Text = new() { value = "test_q1_q4_a2_text" };
        public static readonly LocalizationsIds TestQ1Q4A3Text = new() { value = "test_q1_q4_a3_text" };
        public static readonly LocalizationsIds TestQ1Q4Text = new() { value = "test_q1_q4_text" };
        public static readonly LocalizationsIds TestQ1Q5A1Text = new() { value = "test_q1_q5_a1_text" };
        public static readonly LocalizationsIds TestQ1Q5A2Text = new() { value = "test_q1_q5_a2_text" };
        public static readonly LocalizationsIds TestQ1Q5A3Text = new() { value = "test_q1_q5_a3_text" };
        public static readonly LocalizationsIds TestQ1Q5Text = new() { value = "test_q1_q5_text" };
        public static readonly LocalizationsIds TestQ1Q6A1Text = new() { value = "test_q1_q6_a1_text" };
        public static readonly LocalizationsIds TestQ1Q6A2Text = new() { value = "test_q1_q6_a2_text" };
        public static readonly LocalizationsIds TestQ1Q6A3Text = new() { value = "test_q1_q6_a3_text" };
        public static readonly LocalizationsIds TestQ1Q6Text = new() { value = "test_q1_q6_text" };
        public static readonly LocalizationsIds TestQ1Q7A1Text = new() { value = "test_q1_q7_a1_text" };
        public static readonly LocalizationsIds TestQ1Q7A2Text = new() { value = "test_q1_q7_a2_text" };
        public static readonly LocalizationsIds TestQ1Q7A3Text = new() { value = "test_q1_q7_a3_text" };
        public static readonly LocalizationsIds TestQ1Q7Text = new() { value = "test_q1_q7_text" };
        public static readonly LocalizationsIds TestQ1Q8A1Text = new() { value = "test_q1_q8_a1_text" };
        public static readonly LocalizationsIds TestQ1Q8A2Text = new() { value = "test_q1_q8_a2_text" };
        public static readonly LocalizationsIds TestQ1Q8A3Text = new() { value = "test_q1_q8_a3_text" };
        public static readonly LocalizationsIds TestQ1Q8Text = new() { value = "test_q1_q8_text" };
        public static readonly LocalizationsIds TestQ1Q9A1Text = new() { value = "test_q1_q9_a1_text" };
        public static readonly LocalizationsIds TestQ1Q9A2Text = new() { value = "test_q1_q9_a2_text" };
        public static readonly LocalizationsIds TestQ1Q9A3Text = new() { value = "test_q1_q9_a3_text" };
        public static readonly LocalizationsIds TestQ1Q9Text = new() { value = "test_q1_q9_text" };
        public static readonly LocalizationsIds TestQ2Q10A1Text = new() { value = "test_q2_q10_a1_text" };
        public static readonly LocalizationsIds TestQ2Q10A2Text = new() { value = "test_q2_q10_a2_text" };
        public static readonly LocalizationsIds TestQ2Q10A3Text = new() { value = "test_q2_q10_a3_text" };
        public static readonly LocalizationsIds TestQ2Q10Text = new() { value = "test_q2_q10_text" };
        public static readonly LocalizationsIds TestQ2Q1A1Text = new() { value = "test_q2_q1_a1_text" };
        public static readonly LocalizationsIds TestQ2Q1A2Text = new() { value = "test_q2_q1_a2_text" };
        public static readonly LocalizationsIds TestQ2Q1A3Text = new() { value = "test_q2_q1_a3_text" };
        public static readonly LocalizationsIds TestQ2Q1Text = new() { value = "test_q2_q1_text" };
        public static readonly LocalizationsIds TestQ2Q2Text = new() { value = "test_q2_q2_text" };
        public static readonly LocalizationsIds TestQ2Q3A1Text = new() { value = "test_q2_q3_a1_text" };
        public static readonly LocalizationsIds TestQ2Q3A2Text = new() { value = "test_q2_q3_a2_text" };
        public static readonly LocalizationsIds TestQ2Q3A3Text = new() { value = "test_q2_q3_a3_text" };
        public static readonly LocalizationsIds TestQ2Q3Text = new() { value = "test_q2_q3_text" };
        public static readonly LocalizationsIds TestQ2Q4A1Text = new() { value = "test_q2_q4_a1_text" };
        public static readonly LocalizationsIds TestQ2Q4A2Text = new() { value = "test_q2_q4_a2_text" };
        public static readonly LocalizationsIds TestQ2Q4A3Text = new() { value = "test_q2_q4_a3_text" };
        public static readonly LocalizationsIds TestQ2Q4Text = new() { value = "test_q2_q4_text" };
        public static readonly LocalizationsIds TestQ2Q5A1Text = new() { value = "test_q2_q5_a1_text" };
        public static readonly LocalizationsIds TestQ2Q5A2Text = new() { value = "test_q2_q5_a2_text" };
        public static readonly LocalizationsIds TestQ2Q5A3Text = new() { value = "test_q2_q5_a3_text" };
        public static readonly LocalizationsIds TestQ2Q5Text = new() { value = "test_q2_q5_text" };
        public static readonly LocalizationsIds TestQ2Q6A1Text = new() { value = "test_q2_q6_a1_text" };
        public static readonly LocalizationsIds TestQ2Q6A2Text = new() { value = "test_q2_q6_a2_text" };
        public static readonly LocalizationsIds TestQ2Q6A3Text = new() { value = "test_q2_q6_a3_text" };
        public static readonly LocalizationsIds TestQ2Q6Text = new() { value = "test_q2_q6_text" };
        public static readonly LocalizationsIds TestQ2Q7A1Text = new() { value = "test_q2_q7_a1_text" };
        public static readonly LocalizationsIds TestQ2Q7A2Text = new() { value = "test_q2_q7_a2_text" };
        public static readonly LocalizationsIds TestQ2Q7A3Text = new() { value = "test_q2_q7_a3_text" };
        public static readonly LocalizationsIds TestQ2Q7Text = new() { value = "test_q2_q7_text" };
        public static readonly LocalizationsIds TestQ2Q8A1Text = new() { value = "test_q2_q8_a1_text" };
        public static readonly LocalizationsIds TestQ2Q8A2Text = new() { value = "test_q2_q8_a2_text" };
        public static readonly LocalizationsIds TestQ2Q8A3Text = new() { value = "test_q2_q8_a3_text" };
        public static readonly LocalizationsIds TestQ2Q8Text = new() { value = "test_q2_q8_text" };
        public static readonly LocalizationsIds TestQ2Q9A1Text = new() { value = "test_q2_q9_a1_text" };
        public static readonly LocalizationsIds TestQ2Q9A2Text = new() { value = "test_q2_q9_a2_text" };
        public static readonly LocalizationsIds TestQ2Q9A3Text = new() { value = "test_q2_q9_a3_text" };
        public static readonly LocalizationsIds TestQ2Q9Text = new() { value = "test_q2_q9_text" };
        public static readonly LocalizationsIds TestQ3Q10Text = new() { value = "test_q3_q10_text" };
        public static readonly LocalizationsIds TestQ3Q1A1Text = new() { value = "test_q3_q1_a1_text" };
        public static readonly LocalizationsIds TestQ3Q1A2Text = new() { value = "test_q3_q1_a2_text" };
        public static readonly LocalizationsIds TestQ3Q1A3Text = new() { value = "test_q3_q1_a3_text" };
        public static readonly LocalizationsIds TestQ3Q1Text = new() { value = "test_q3_q1_text" };
        public static readonly LocalizationsIds TestQ3Q2A1Text = new() { value = "test_q3_q2_a1_text" };
        public static readonly LocalizationsIds TestQ3Q2A2Text = new() { value = "test_q3_q2_a2_text" };
        public static readonly LocalizationsIds TestQ3Q2A3Text = new() { value = "test_q3_q2_a3_text" };
        public static readonly LocalizationsIds TestQ3Q2Text = new() { value = "test_q3_q2_text" };
        public static readonly LocalizationsIds TestQ3Q3A1Text = new() { value = "test_q3_q3_a1_text" };
        public static readonly LocalizationsIds TestQ3Q3A2Text = new() { value = "test_q3_q3_a2_text" };
        public static readonly LocalizationsIds TestQ3Q3A3Text = new() { value = "test_q3_q3_a3_text" };
        public static readonly LocalizationsIds TestQ3Q3Text = new() { value = "test_q3_q3_text" };
        public static readonly LocalizationsIds TestQ3Q4A1Text = new() { value = "test_q3_q4_a1_text" };
        public static readonly LocalizationsIds TestQ3Q4A2Text = new() { value = "test_q3_q4_a2_text" };
        public static readonly LocalizationsIds TestQ3Q4A3Text = new() { value = "test_q3_q4_a3_text" };
        public static readonly LocalizationsIds TestQ3Q4Text = new() { value = "test_q3_q4_text" };
        public static readonly LocalizationsIds TestQ3Q5A1Text = new() { value = "test_q3_q5_a1_text" };
        public static readonly LocalizationsIds TestQ3Q5A2Text = new() { value = "test_q3_q5_a2_text" };
        public static readonly LocalizationsIds TestQ3Q5A3Text = new() { value = "test_q3_q5_a3_text" };
        public static readonly LocalizationsIds TestQ3Q5Text = new() { value = "test_q3_q5_text" };
        public static readonly LocalizationsIds TestQ3Q6A1Text = new() { value = "test_q3_q6_a1_text" };
        public static readonly LocalizationsIds TestQ3Q6A2Text = new() { value = "test_q3_q6_a2_text" };
        public static readonly LocalizationsIds TestQ3Q6A3Text = new() { value = "test_q3_q6_a3_text" };
        public static readonly LocalizationsIds TestQ3Q6Text = new() { value = "test_q3_q6_text" };
        public static readonly LocalizationsIds TestQ3Q7A1Text = new() { value = "test_q3_q7_a1_text" };
        public static readonly LocalizationsIds TestQ3Q7A2Text = new() { value = "test_q3_q7_a2_text" };
        public static readonly LocalizationsIds TestQ3Q7A3Text = new() { value = "test_q3_q7_a3_text" };
        public static readonly LocalizationsIds TestQ3Q7Text = new() { value = "test_q3_q7_text" };
        public static readonly LocalizationsIds TestQ3Q8A1Text = new() { value = "test_q3_q8_a1_text" };
        public static readonly LocalizationsIds TestQ3Q8A2Text = new() { value = "test_q3_q8_a2_text" };
        public static readonly LocalizationsIds TestQ3Q8A3Text = new() { value = "test_q3_q8_a3_text" };
        public static readonly LocalizationsIds TestQ3Q8Text = new() { value = "test_q3_q8_text" };
        public static readonly LocalizationsIds TestQ3Q9Text = new() { value = "test_q3_q9_text" };
        public static readonly LocalizationsIds TestQ4Q10A1Text = new() { value = "test_q4_q10_a1_text" };
        public static readonly LocalizationsIds TestQ4Q10A2Text = new() { value = "test_q4_q10_a2_text" };
        public static readonly LocalizationsIds TestQ4Q10A3Text = new() { value = "test_q4_q10_a3_text" };
        public static readonly LocalizationsIds TestQ4Q10Text = new() { value = "test_q4_q10_text" };
        public static readonly LocalizationsIds TestQ4Q1A1Text = new() { value = "test_q4_q1_a1_text" };
        public static readonly LocalizationsIds TestQ4Q1A2Text = new() { value = "test_q4_q1_a2_text" };
        public static readonly LocalizationsIds TestQ4Q1A3Text = new() { value = "test_q4_q1_a3_text" };
        public static readonly LocalizationsIds TestQ4Q1Text = new() { value = "test_q4_q1_text" };
        public static readonly LocalizationsIds TestQ4Q2A1Text = new() { value = "test_q4_q2_a1_text" };
        public static readonly LocalizationsIds TestQ4Q2A2Text = new() { value = "test_q4_q2_a2_text" };
        public static readonly LocalizationsIds TestQ4Q2A3Text = new() { value = "test_q4_q2_a3_text" };
        public static readonly LocalizationsIds TestQ4Q2Text = new() { value = "test_q4_q2_text" };
        public static readonly LocalizationsIds TestQ4Q3A1Text = new() { value = "test_q4_q3_a1_text" };
        public static readonly LocalizationsIds TestQ4Q3A2Text = new() { value = "test_q4_q3_a2_text" };
        public static readonly LocalizationsIds TestQ4Q3A3Text = new() { value = "test_q4_q3_a3_text" };
        public static readonly LocalizationsIds TestQ4Q3Text = new() { value = "test_q4_q3_text" };
        public static readonly LocalizationsIds TestQ4Q4A1Text = new() { value = "test_q4_q4_a1_text" };
        public static readonly LocalizationsIds TestQ4Q4A2Text = new() { value = "test_q4_q4_a2_text" };
        public static readonly LocalizationsIds TestQ4Q4A3Text = new() { value = "test_q4_q4_a3_text" };
        public static readonly LocalizationsIds TestQ4Q4Text = new() { value = "test_q4_q4_text" };
        public static readonly LocalizationsIds TestQ4Q5A1Text = new() { value = "test_q4_q5_a1_text" };
        public static readonly LocalizationsIds TestQ4Q5A2Text = new() { value = "test_q4_q5_a2_text" };
        public static readonly LocalizationsIds TestQ4Q5A3Text = new() { value = "test_q4_q5_a3_text" };
        public static readonly LocalizationsIds TestQ4Q5Text = new() { value = "test_q4_q5_text" };
        public static readonly LocalizationsIds TestQ4Q6A1Text = new() { value = "test_q4_q6_a1_text" };
        public static readonly LocalizationsIds TestQ4Q6A2Text = new() { value = "test_q4_q6_a2_text" };
        public static readonly LocalizationsIds TestQ4Q6A3Text = new() { value = "test_q4_q6_a3_text" };
        public static readonly LocalizationsIds TestQ4Q6Text = new() { value = "test_q4_q6_text" };
        public static readonly LocalizationsIds TestQ4Q7A1Text = new() { value = "test_q4_q7_a1_text" };
        public static readonly LocalizationsIds TestQ4Q7A2Text = new() { value = "test_q4_q7_a2_text" };
        public static readonly LocalizationsIds TestQ4Q7A3Text = new() { value = "test_q4_q7_a3_text" };
        public static readonly LocalizationsIds TestQ4Q7Text = new() { value = "test_q4_q7_text" };
        public static readonly LocalizationsIds TestQ4Q8A1Text = new() { value = "test_q4_q8_a1_text" };
        public static readonly LocalizationsIds TestQ4Q8A2Text = new() { value = "test_q4_q8_a2_text" };
        public static readonly LocalizationsIds TestQ4Q8A3Text = new() { value = "test_q4_q8_a3_text" };
        public static readonly LocalizationsIds TestQ4Q8Text = new() { value = "test_q4_q8_text" };
        public static readonly LocalizationsIds TestQ4Q9A1Text = new() { value = "test_q4_q9_a1_text" };
        public static readonly LocalizationsIds TestQ4Q9A2Text = new() { value = "test_q4_q9_a2_text" };
        public static readonly LocalizationsIds TestQ4Q9A3Text = new() { value = "test_q4_q9_a3_text" };
        public static readonly LocalizationsIds TestQ4Q9Text = new() { value = "test_q4_q9_text" };
        public static readonly LocalizationsIds TestQ5Q10A1Text = new() { value = "test_q5_q10_a1_text" };
        public static readonly LocalizationsIds TestQ5Q10A2Text = new() { value = "test_q5_q10_a2_text" };
        public static readonly LocalizationsIds TestQ5Q10A3Text = new() { value = "test_q5_q10_a3_text" };
        public static readonly LocalizationsIds TestQ5Q10Text = new() { value = "test_q5_q10_text" };
        public static readonly LocalizationsIds TestQ5Q1A1Text = new() { value = "test_q5_q1_a1_text" };
        public static readonly LocalizationsIds TestQ5Q1A2Text = new() { value = "test_q5_q1_a2_text" };
        public static readonly LocalizationsIds TestQ5Q1A3Text = new() { value = "test_q5_q1_a3_text" };
        public static readonly LocalizationsIds TestQ5Q1Text = new() { value = "test_q5_q1_text" };
        public static readonly LocalizationsIds TestQ5Q2A1Text = new() { value = "test_q5_q2_a1_text" };
        public static readonly LocalizationsIds TestQ5Q2A2Text = new() { value = "test_q5_q2_a2_text" };
        public static readonly LocalizationsIds TestQ5Q2A3Text = new() { value = "test_q5_q2_a3_text" };
        public static readonly LocalizationsIds TestQ5Q2Text = new() { value = "test_q5_q2_text" };
        public static readonly LocalizationsIds TestQ5Q3A1Text = new() { value = "test_q5_q3_a1_text" };
        public static readonly LocalizationsIds TestQ5Q3A2Text = new() { value = "test_q5_q3_a2_text" };
        public static readonly LocalizationsIds TestQ5Q3A3Text = new() { value = "test_q5_q3_a3_text" };
        public static readonly LocalizationsIds TestQ5Q3Text = new() { value = "test_q5_q3_text" };
        public static readonly LocalizationsIds TestQ5Q4A1Text = new() { value = "test_q5_q4_a1_text" };
        public static readonly LocalizationsIds TestQ5Q4A2Text = new() { value = "test_q5_q4_a2_text" };
        public static readonly LocalizationsIds TestQ5Q4A3Text = new() { value = "test_q5_q4_a3_text" };
        public static readonly LocalizationsIds TestQ5Q4Text = new() { value = "test_q5_q4_text" };
        public static readonly LocalizationsIds TestQ5Q5A1Text = new() { value = "test_q5_q5_a1_text" };
        public static readonly LocalizationsIds TestQ5Q5A2Text = new() { value = "test_q5_q5_a2_text" };
        public static readonly LocalizationsIds TestQ5Q5A3Text = new() { value = "test_q5_q5_a3_text" };
        public static readonly LocalizationsIds TestQ5Q5Text = new() { value = "test_q5_q5_text" };
        public static readonly LocalizationsIds TestQ5Q6A1Text = new() { value = "test_q5_q6_a1_text" };
        public static readonly LocalizationsIds TestQ5Q6A2Text = new() { value = "test_q5_q6_a2_text" };
        public static readonly LocalizationsIds TestQ5Q6A3Text = new() { value = "test_q5_q6_a3_text" };
        public static readonly LocalizationsIds TestQ5Q6Text = new() { value = "test_q5_q6_text" };
        public static readonly LocalizationsIds TestQ5Q7A1Text = new() { value = "test_q5_q7_a1_text" };
        public static readonly LocalizationsIds TestQ5Q7A2Text = new() { value = "test_q5_q7_a2_text" };
        public static readonly LocalizationsIds TestQ5Q7A3Text = new() { value = "test_q5_q7_a3_text" };
        public static readonly LocalizationsIds TestQ5Q7Text = new() { value = "test_q5_q7_text" };
        public static readonly LocalizationsIds TestQ5Q8A1Text = new() { value = "test_q5_q8_a1_text" };
        public static readonly LocalizationsIds TestQ5Q8A2Text = new() { value = "test_q5_q8_a2_text" };
        public static readonly LocalizationsIds TestQ5Q8A3Text = new() { value = "test_q5_q8_a3_text" };
        public static readonly LocalizationsIds TestQ5Q8Text = new() { value = "test_q5_q8_text" };
        public static readonly LocalizationsIds TestQ5Q9A1Text = new() { value = "test_q5_q9_a1_text" };
        public static readonly LocalizationsIds TestQ5Q9A2Text = new() { value = "test_q5_q9_a2_text" };
        public static readonly LocalizationsIds TestQ5Q9A3Text = new() { value = "test_q5_q9_a3_text" };
        public static readonly LocalizationsIds TestQ5Q9Text = new() { value = "test_q5_q9_text" };
        public static readonly LocalizationsIds TestQ6Q10A1Text = new() { value = "test_q6_q10_a1_text" };
        public static readonly LocalizationsIds TestQ6Q10A2Text = new() { value = "test_q6_q10_a2_text" };
        public static readonly LocalizationsIds TestQ6Q10A3Text = new() { value = "test_q6_q10_a3_text" };
        public static readonly LocalizationsIds TestQ6Q10Text = new() { value = "test_q6_q10_text" };
        public static readonly LocalizationsIds TestQ6Q1A1Text = new() { value = "test_q6_q1_a1_text" };
        public static readonly LocalizationsIds TestQ6Q1A2Text = new() { value = "test_q6_q1_a2_text" };
        public static readonly LocalizationsIds TestQ6Q1A3Text = new() { value = "test_q6_q1_a3_text" };
        public static readonly LocalizationsIds TestQ6Q1Text = new() { value = "test_q6_q1_text" };
        public static readonly LocalizationsIds TestQ6Q2A1Text = new() { value = "test_q6_q2_a1_text" };
        public static readonly LocalizationsIds TestQ6Q2A2Text = new() { value = "test_q6_q2_a2_text" };
        public static readonly LocalizationsIds TestQ6Q2A3Text = new() { value = "test_q6_q2_a3_text" };
        public static readonly LocalizationsIds TestQ6Q2Text = new() { value = "test_q6_q2_text" };
        public static readonly LocalizationsIds TestQ6Q3A1Text = new() { value = "test_q6_q3_a1_text" };
        public static readonly LocalizationsIds TestQ6Q3A2Text = new() { value = "test_q6_q3_a2_text" };
        public static readonly LocalizationsIds TestQ6Q3A3Text = new() { value = "test_q6_q3_a3_text" };
        public static readonly LocalizationsIds TestQ6Q3Text = new() { value = "test_q6_q3_text" };
        public static readonly LocalizationsIds TestQ6Q4A1Text = new() { value = "test_q6_q4_a1_text" };
        public static readonly LocalizationsIds TestQ6Q4A2Text = new() { value = "test_q6_q4_a2_text" };
        public static readonly LocalizationsIds TestQ6Q4A3Text = new() { value = "test_q6_q4_a3_text" };
        public static readonly LocalizationsIds TestQ6Q4Text = new() { value = "test_q6_q4_text" };
        public static readonly LocalizationsIds TestQ6Q5A1Text = new() { value = "test_q6_q5_a1_text" };
        public static readonly LocalizationsIds TestQ6Q5A2Text = new() { value = "test_q6_q5_a2_text" };
        public static readonly LocalizationsIds TestQ6Q5A3Text = new() { value = "test_q6_q5_a3_text" };
        public static readonly LocalizationsIds TestQ6Q5Text = new() { value = "test_q6_q5_text" };
        public static readonly LocalizationsIds TestQ6Q6A1Text = new() { value = "test_q6_q6_a1_text" };
        public static readonly LocalizationsIds TestQ6Q6A2Text = new() { value = "test_q6_q6_a2_text" };
        public static readonly LocalizationsIds TestQ6Q6A3Text = new() { value = "test_q6_q6_a3_text" };
        public static readonly LocalizationsIds TestQ6Q6Text = new() { value = "test_q6_q6_text" };
        public static readonly LocalizationsIds TestQ6Q7A1Text = new() { value = "test_q6_q7_a1_text" };
        public static readonly LocalizationsIds TestQ6Q7A2Text = new() { value = "test_q6_q7_a2_text" };
        public static readonly LocalizationsIds TestQ6Q7A3Text = new() { value = "test_q6_q7_a3_text" };
        public static readonly LocalizationsIds TestQ6Q7Text = new() { value = "test_q6_q7_text" };
        public static readonly LocalizationsIds TestQ6Q8A1Text = new() { value = "test_q6_q8_a1_text" };
        public static readonly LocalizationsIds TestQ6Q8A2Text = new() { value = "test_q6_q8_a2_text" };
        public static readonly LocalizationsIds TestQ6Q8A3Text = new() { value = "test_q6_q8_a3_text" };
        public static readonly LocalizationsIds TestQ6Q8Text = new() { value = "test_q6_q8_text" };
        public static readonly LocalizationsIds TestQ6Q9A1Text = new() { value = "test_q6_q9_a1_text" };
        public static readonly LocalizationsIds TestQ6Q9A2Text = new() { value = "test_q6_q9_a2_text" };
        public static readonly LocalizationsIds TestQ6Q9A3Text = new() { value = "test_q6_q9_a3_text" };
        public static readonly LocalizationsIds TestQ6Q9Text = new() { value = "test_q6_q9_text" };
        public static readonly LocalizationsIds TestQ7Q10A1Text = new() { value = "test_q7_q10_a1_text" };
        public static readonly LocalizationsIds TestQ7Q10A2Text = new() { value = "test_q7_q10_a2_text" };
        public static readonly LocalizationsIds TestQ7Q10A3Text = new() { value = "test_q7_q10_a3_text" };
        public static readonly LocalizationsIds TestQ7Q10Text = new() { value = "test_q7_q10_text" };
        public static readonly LocalizationsIds TestQ7Q1A1Text = new() { value = "test_q7_q1_a1_text" };
        public static readonly LocalizationsIds TestQ7Q1A2Text = new() { value = "test_q7_q1_a2_text" };
        public static readonly LocalizationsIds TestQ7Q1A3Text = new() { value = "test_q7_q1_a3_text" };
        public static readonly LocalizationsIds TestQ7Q1Text = new() { value = "test_q7_q1_text" };
        public static readonly LocalizationsIds TestQ7Q2A1Text = new() { value = "test_q7_q2_a1_text" };
        public static readonly LocalizationsIds TestQ7Q2A2Text = new() { value = "test_q7_q2_a2_text" };
        public static readonly LocalizationsIds TestQ7Q2A3Text = new() { value = "test_q7_q2_a3_text" };
        public static readonly LocalizationsIds TestQ7Q2Text = new() { value = "test_q7_q2_text" };
        public static readonly LocalizationsIds TestQ7Q3A1Text = new() { value = "test_q7_q3_a1_text" };
        public static readonly LocalizationsIds TestQ7Q3A2Text = new() { value = "test_q7_q3_a2_text" };
        public static readonly LocalizationsIds TestQ7Q3A3Text = new() { value = "test_q7_q3_a3_text" };
        public static readonly LocalizationsIds TestQ7Q3Text = new() { value = "test_q7_q3_text" };
        public static readonly LocalizationsIds TestQ7Q4A1Text = new() { value = "test_q7_q4_a1_text" };
        public static readonly LocalizationsIds TestQ7Q4A2Text = new() { value = "test_q7_q4_a2_text" };
        public static readonly LocalizationsIds TestQ7Q4A3Text = new() { value = "test_q7_q4_a3_text" };
        public static readonly LocalizationsIds TestQ7Q4Text = new() { value = "test_q7_q4_text" };
        public static readonly LocalizationsIds TestQ7Q5A1Text = new() { value = "test_q7_q5_a1_text" };
        public static readonly LocalizationsIds TestQ7Q5A2Text = new() { value = "test_q7_q5_a2_text" };
        public static readonly LocalizationsIds TestQ7Q5A3Text = new() { value = "test_q7_q5_a3_text" };
        public static readonly LocalizationsIds TestQ7Q5Text = new() { value = "test_q7_q5_text" };
        public static readonly LocalizationsIds TestQ7Q6A1Text = new() { value = "test_q7_q6_a1_text" };
        public static readonly LocalizationsIds TestQ7Q6A2Text = new() { value = "test_q7_q6_a2_text" };
        public static readonly LocalizationsIds TestQ7Q6A3Text = new() { value = "test_q7_q6_a3_text" };
        public static readonly LocalizationsIds TestQ7Q6Text = new() { value = "test_q7_q6_text" };
        public static readonly LocalizationsIds TestQ7Q7A1Text = new() { value = "test_q7_q7_a1_text" };
        public static readonly LocalizationsIds TestQ7Q7A2Text = new() { value = "test_q7_q7_a2_text" };
        public static readonly LocalizationsIds TestQ7Q7A3Text = new() { value = "test_q7_q7_a3_text" };
        public static readonly LocalizationsIds TestQ7Q7Text = new() { value = "test_q7_q7_text" };
        public static readonly LocalizationsIds TestQ7Q8A1Text = new() { value = "test_q7_q8_a1_text" };
        public static readonly LocalizationsIds TestQ7Q8A2Text = new() { value = "test_q7_q8_a2_text" };
        public static readonly LocalizationsIds TestQ7Q8A3Text = new() { value = "test_q7_q8_a3_text" };
        public static readonly LocalizationsIds TestQ7Q8Text = new() { value = "test_q7_q8_text" };
        public static readonly LocalizationsIds TestQ7Q9A1Text = new() { value = "test_q7_q9_a1_text" };
        public static readonly LocalizationsIds TestQ7Q9A2Text = new() { value = "test_q7_q9_a2_text" };
        public static readonly LocalizationsIds TestQ7Q9A3Text = new() { value = "test_q7_q9_a3_text" };
        public static readonly LocalizationsIds TestQ7Q9Text = new() { value = "test_q7_q9_text" };
        public static readonly LocalizationsIds TestQ8Q10A1Text = new() { value = "test_q8_q10_a1_text" };
        public static readonly LocalizationsIds TestQ8Q10A2Text = new() { value = "test_q8_q10_a2_text" };
        public static readonly LocalizationsIds TestQ8Q10A3Text = new() { value = "test_q8_q10_a3_text" };
        public static readonly LocalizationsIds TestQ8Q10Text = new() { value = "test_q8_q10_text" };
        public static readonly LocalizationsIds TestQ8Q1A1Text = new() { value = "test_q8_q1_a1_text" };
        public static readonly LocalizationsIds TestQ8Q1A2Text = new() { value = "test_q8_q1_a2_text" };
        public static readonly LocalizationsIds TestQ8Q1A3Text = new() { value = "test_q8_q1_a3_text" };
        public static readonly LocalizationsIds TestQ8Q1Text = new() { value = "test_q8_q1_text" };
        public static readonly LocalizationsIds TestQ8Q2A1Text = new() { value = "test_q8_q2_a1_text" };
        public static readonly LocalizationsIds TestQ8Q2A2Text = new() { value = "test_q8_q2_a2_text" };
        public static readonly LocalizationsIds TestQ8Q2A3Text = new() { value = "test_q8_q2_a3_text" };
        public static readonly LocalizationsIds TestQ8Q2Text = new() { value = "test_q8_q2_text" };
        public static readonly LocalizationsIds TestQ8Q3A1Text = new() { value = "test_q8_q3_a1_text" };
        public static readonly LocalizationsIds TestQ8Q3A2Text = new() { value = "test_q8_q3_a2_text" };
        public static readonly LocalizationsIds TestQ8Q3A3Text = new() { value = "test_q8_q3_a3_text" };
        public static readonly LocalizationsIds TestQ8Q3Text = new() { value = "test_q8_q3_text" };
        public static readonly LocalizationsIds TestQ8Q4A1Text = new() { value = "test_q8_q4_a1_text" };
        public static readonly LocalizationsIds TestQ8Q4A2Text = new() { value = "test_q8_q4_a2_text" };
        public static readonly LocalizationsIds TestQ8Q4A3Text = new() { value = "test_q8_q4_a3_text" };
        public static readonly LocalizationsIds TestQ8Q4Text = new() { value = "test_q8_q4_text" };
        public static readonly LocalizationsIds TestQ8Q5A1Text = new() { value = "test_q8_q5_a1_text" };
        public static readonly LocalizationsIds TestQ8Q5A2Text = new() { value = "test_q8_q5_a2_text" };
        public static readonly LocalizationsIds TestQ8Q5A3Text = new() { value = "test_q8_q5_a3_text" };
        public static readonly LocalizationsIds TestQ8Q5Text = new() { value = "test_q8_q5_text" };
        public static readonly LocalizationsIds TestQ8Q6A1Text = new() { value = "test_q8_q6_a1_text" };
        public static readonly LocalizationsIds TestQ8Q6A2Text = new() { value = "test_q8_q6_a2_text" };
        public static readonly LocalizationsIds TestQ8Q6A3Text = new() { value = "test_q8_q6_a3_text" };
        public static readonly LocalizationsIds TestQ8Q6Text = new() { value = "test_q8_q6_text" };
        public static readonly LocalizationsIds TestQ8Q7A1Text = new() { value = "test_q8_q7_a1_text" };
        public static readonly LocalizationsIds TestQ8Q7A2Text = new() { value = "test_q8_q7_a2_text" };
        public static readonly LocalizationsIds TestQ8Q7A3Text = new() { value = "test_q8_q7_a3_text" };
        public static readonly LocalizationsIds TestQ8Q7Text = new() { value = "test_q8_q7_text" };
        public static readonly LocalizationsIds TestQ8Q8A1Text = new() { value = "test_q8_q8_a1_text" };
        public static readonly LocalizationsIds TestQ8Q8A2Text = new() { value = "test_q8_q8_a2_text" };
        public static readonly LocalizationsIds TestQ8Q8A3Text = new() { value = "test_q8_q8_a3_text" };
        public static readonly LocalizationsIds TestQ8Q8Text = new() { value = "test_q8_q8_text" };
        public static readonly LocalizationsIds TestQ8Q9A1Text = new() { value = "test_q8_q9_a1_text" };
        public static readonly LocalizationsIds TestQ8Q9A2Text = new() { value = "test_q8_q9_a2_text" };
        public static readonly LocalizationsIds TestQ8Q9A3Text = new() { value = "test_q8_q9_a3_text" };
        public static readonly LocalizationsIds TestQ8Q9Text = new() { value = "test_q8_q9_text" };
        public static readonly LocalizationsIds TestQ9Q10A1Text = new() { value = "test_q9_q10_a1_text" };
        public static readonly LocalizationsIds TestQ9Q10A2Text = new() { value = "test_q9_q10_a2_text" };
        public static readonly LocalizationsIds TestQ9Q10A3Text = new() { value = "test_q9_q10_a3_text" };
        public static readonly LocalizationsIds TestQ9Q10Text = new() { value = "test_q9_q10_text" };
        public static readonly LocalizationsIds TestQ9Q1A1Text = new() { value = "test_q9_q1_a1_text" };
        public static readonly LocalizationsIds TestQ9Q1A2Text = new() { value = "test_q9_q1_a2_text" };
        public static readonly LocalizationsIds TestQ9Q1A3Text = new() { value = "test_q9_q1_a3_text" };
        public static readonly LocalizationsIds TestQ9Q1Text = new() { value = "test_q9_q1_text" };
        public static readonly LocalizationsIds TestQ9Q2A1Text = new() { value = "test_q9_q2_a1_text" };
        public static readonly LocalizationsIds TestQ9Q2A2Text = new() { value = "test_q9_q2_a2_text" };
        public static readonly LocalizationsIds TestQ9Q2A3Text = new() { value = "test_q9_q2_a3_text" };
        public static readonly LocalizationsIds TestQ9Q2Text = new() { value = "test_q9_q2_text" };
        public static readonly LocalizationsIds TestQ9Q3A1Text = new() { value = "test_q9_q3_a1_text" };
        public static readonly LocalizationsIds TestQ9Q3A2Text = new() { value = "test_q9_q3_a2_text" };
        public static readonly LocalizationsIds TestQ9Q3A3Text = new() { value = "test_q9_q3_a3_text" };
        public static readonly LocalizationsIds TestQ9Q3Text = new() { value = "test_q9_q3_text" };
        public static readonly LocalizationsIds TestQ9Q4A1Text = new() { value = "test_q9_q4_a1_text" };
        public static readonly LocalizationsIds TestQ9Q4A2Text = new() { value = "test_q9_q4_a2_text" };
        public static readonly LocalizationsIds TestQ9Q4A3Text = new() { value = "test_q9_q4_a3_text" };
        public static readonly LocalizationsIds TestQ9Q4Text = new() { value = "test_q9_q4_text" };
        public static readonly LocalizationsIds TestQ9Q5A1Text = new() { value = "test_q9_q5_a1_text" };
        public static readonly LocalizationsIds TestQ9Q5A2Text = new() { value = "test_q9_q5_a2_text" };
        public static readonly LocalizationsIds TestQ9Q5A3Text = new() { value = "test_q9_q5_a3_text" };
        public static readonly LocalizationsIds TestQ9Q5Text = new() { value = "test_q9_q5_text" };
        public static readonly LocalizationsIds TestQ9Q6A1Text = new() { value = "test_q9_q6_a1_text" };
        public static readonly LocalizationsIds TestQ9Q6A2Text = new() { value = "test_q9_q6_a2_text" };
        public static readonly LocalizationsIds TestQ9Q6A3Text = new() { value = "test_q9_q6_a3_text" };
        public static readonly LocalizationsIds TestQ9Q6Text = new() { value = "test_q9_q6_text" };
        public static readonly LocalizationsIds TestQ9Q7A1Text = new() { value = "test_q9_q7_a1_text" };
        public static readonly LocalizationsIds TestQ9Q7A2Text = new() { value = "test_q9_q7_a2_text" };
        public static readonly LocalizationsIds TestQ9Q7A3Text = new() { value = "test_q9_q7_a3_text" };
        public static readonly LocalizationsIds TestQ9Q7Text = new() { value = "test_q9_q7_text" };
        public static readonly LocalizationsIds TestQ9Q8A1Text = new() { value = "test_q9_q8_a1_text" };
        public static readonly LocalizationsIds TestQ9Q8A2Text = new() { value = "test_q9_q8_a2_text" };
        public static readonly LocalizationsIds TestQ9Q8A3Text = new() { value = "test_q9_q8_a3_text" };
        public static readonly LocalizationsIds TestQ9Q8Text = new() { value = "test_q9_q8_text" };
        public static readonly LocalizationsIds TestQ9Q9A1Text = new() { value = "test_q9_q9_a1_text" };
        public static readonly LocalizationsIds TestQ9Q9A2Text = new() { value = "test_q9_q9_a2_text" };
        public static readonly LocalizationsIds TestQ9Q9A3Text = new() { value = "test_q9_q9_a3_text" };
        public static readonly LocalizationsIds TestQ9Q9Text = new() { value = "test_q9_q9_text" };
        public static readonly LocalizationsIds TestRepeat = new() { value = "test_repeat" };
        public static readonly LocalizationsIds TestResult = new() { value = "test_result" };
        public static readonly LocalizationsIds TestQ2Q2A1Text = new() { value = "test_q2_q2_a1_text" };
        public static readonly LocalizationsIds TestQ2Q2A2Text = new() { value = "test_q2_q2_a2_text" };
        public static readonly LocalizationsIds TestQ2Q2A3Text = new() { value = "test_q2_q2_a3_text" };



        private static LocalizationsIds[] _allValues;
        public static LocalizationsIds[] GetAllValues()
        {
            if (_allValues != null) return _allValues;
            _allValues = new[]
            {
                Algorithm,
                Check,
                Correct,
                Incorrect,
                Menu,
                Repeat,
                T1BinaryToHalftone,
                T1EuclideanDistance,
                T1Smudging,
                T2CityDistance,
                T2CityDistanceDescription,
                T3ChessboardDistance,
                T3ChessboardDistanceDescription,
                T4MarkRemovalDescription,
                T4Thinning,
                T4ZhangSuenMethod,
                T5Erosion,
                T5ErosionDescription,
                T5ErosionLeavePixelsDescription,
                T5Filtering,
                T6Expansion,
                T6ExpansionAddPixelsDescription,
                T6ExpansionDescription,
                CardFilteringDilation,
                CardFilteringErosion,
                CardSmudgingChessboardDistance,
                CardSmudgingCityDistance,
                CardSmudgingEuclideanDistance,
                CardZhangSuenMethod,
                MainMenuAboutButton,
                MainMenuName,
                MainMenuPracticeButton,
                MainMenuSettingsButton,
                MainMenuSettingsLanguage,
                MainMenuTestButton,
                MainMenuTheoryButton,
                ResultAllCorrect,
                ResultExplanation1,
                ResultExplanation2,
                ResultHeader,
                ResultMarkCenter,
                ResultMistakeDescription1,
                ResultMistakeDescriptionPrefix,
                ResultMistakeMade,
                ResultNotMarkCenter,
                TestCardBinaryImages,
                TestCardConceptAndDefinition,
                TestCardImageThinning,
                TestCardSegmentation,
                TestCardTextureAnalysis,
                TestNextQuestion,
                TestQ1Q10A1Text,
                TestQ1Q10A2Text,
                TestQ1Q10A3Text,
                TestQ1Q10Text,
                TestQ1Q1A1Text,
                TestQ1Q1A2Text,
                TestQ1Q1A3Text,
                TestQ1Q1Text,
                TestQ1Q2A1Text,
                TestQ1Q2A2Text,
                TestQ1Q2A3Text,
                TestQ1Q2Text,
                TestQ1Q3A1Text,
                TestQ1Q3A2Text,
                TestQ1Q3A3Text,
                TestQ1Q3Text,
                TestQ1Q4A1Text,
                TestQ1Q4A2Text,
                TestQ1Q4A3Text,
                TestQ1Q4Text,
                TestQ1Q5A1Text,
                TestQ1Q5A2Text,
                TestQ1Q5A3Text,
                TestQ1Q5Text,
                TestQ1Q6A1Text,
                TestQ1Q6A2Text,
                TestQ1Q6A3Text,
                TestQ1Q6Text,
                TestQ1Q7A1Text,
                TestQ1Q7A2Text,
                TestQ1Q7A3Text,
                TestQ1Q7Text,
                TestQ1Q8A1Text,
                TestQ1Q8A2Text,
                TestQ1Q8A3Text,
                TestQ1Q8Text,
                TestQ1Q9A1Text,
                TestQ1Q9A2Text,
                TestQ1Q9A3Text,
                TestQ1Q9Text,
                TestQ2Q10A1Text,
                TestQ2Q10A2Text,
                TestQ2Q10A3Text,
                TestQ2Q10Text,
                TestQ2Q1A1Text,
                TestQ2Q1A2Text,
                TestQ2Q1A3Text,
                TestQ2Q1Text,
                TestQ2Q2A1Text,
                TestQ2Q2A2Text,
                TestQ2Q2A3Text,
                TestQ2Q2Text,
                TestQ2Q3A1Text,
                TestQ2Q3A2Text,
                TestQ2Q3A3Text,
                TestQ2Q3Text,
                TestQ2Q4A1Text,
                TestQ2Q4A2Text,
                TestQ2Q4A3Text,
                TestQ2Q4Text,
                TestQ2Q5A1Text,
                TestQ2Q5A2Text,
                TestQ2Q5A3Text,
                TestQ2Q5Text,
                TestQ2Q6A1Text,
                TestQ2Q6A2Text,
                TestQ2Q6A3Text,
                TestQ2Q6Text,
                TestQ2Q7A1Text,
                TestQ2Q7A2Text,
                TestQ2Q7A3Text,
                TestQ2Q7Text,
                TestQ2Q8A1Text,
                TestQ2Q8A2Text,
                TestQ2Q8A3Text,
                TestQ2Q8Text,
                TestQ2Q9A1Text,
                TestQ2Q9A2Text,
                TestQ2Q9A3Text,
                TestQ2Q9Text,
                TestQ3Q10Text,
                TestQ3Q1A1Text,
                TestQ3Q1A2Text,
                TestQ3Q1A3Text,
                TestQ3Q1Text,
                TestQ3Q2A1Text,
                TestQ3Q2A2Text,
                TestQ3Q2A3Text,
                TestQ3Q2Text,
                TestQ3Q3A1Text,
                TestQ3Q3A2Text,
                TestQ3Q3A3Text,
                TestQ3Q3Text,
                TestQ3Q4A1Text,
                TestQ3Q4A2Text,
                TestQ3Q4A3Text,
                TestQ3Q4Text,
                TestQ3Q5A1Text,
                TestQ3Q5A2Text,
                TestQ3Q5A3Text,
                TestQ3Q5Text,
                TestQ3Q6A1Text,
                TestQ3Q6A2Text,
                TestQ3Q6A3Text,
                TestQ3Q6Text,
                TestQ3Q7A1Text,
                TestQ3Q7A2Text,
                TestQ3Q7A3Text,
                TestQ3Q7Text,
                TestQ3Q8A1Text,
                TestQ3Q8A2Text,
                TestQ3Q8A3Text,
                TestQ3Q8Text,
                TestQ3Q9Text,
                TestQ4Q10A1Text,
                TestQ4Q10A2Text,
                TestQ4Q10A3Text,
                TestQ4Q10Text,
                TestQ4Q1A1Text,
                TestQ4Q1A2Text,
                TestQ4Q1A3Text,
                TestQ4Q1Text,
                TestQ4Q2A1Text,
                TestQ4Q2A2Text,
                TestQ4Q2A3Text,
                TestQ4Q2Text,
                TestQ4Q3A1Text,
                TestQ4Q3A2Text,
                TestQ4Q3A3Text,
                TestQ4Q3Text,
                TestQ4Q4A1Text,
                TestQ4Q4A2Text,
                TestQ4Q4A3Text,
                TestQ4Q4Text,
                TestQ4Q5A1Text,
                TestQ4Q5A2Text,
                TestQ4Q5A3Text,
                TestQ4Q5Text,
                TestQ4Q6A1Text,
                TestQ4Q6A2Text,
                TestQ4Q6A3Text,
                TestQ4Q6Text,
                TestQ4Q7A1Text,
                TestQ4Q7A2Text,
                TestQ4Q7A3Text,
                TestQ4Q7Text,
                TestQ4Q8A1Text,
                TestQ4Q8A2Text,
                TestQ4Q8A3Text,
                TestQ4Q8Text,
                TestQ4Q9A1Text,
                TestQ4Q9A2Text,
                TestQ4Q9A3Text,
                TestQ4Q9Text,
                TestQ5Q10A1Text,
                TestQ5Q10A2Text,
                TestQ5Q10A3Text,
                TestQ5Q10Text,
                TestQ5Q1A1Text,
                TestQ5Q1A2Text,
                TestQ5Q1A3Text,
                TestQ5Q1Text,
                TestQ5Q2A1Text,
                TestQ5Q2A2Text,
                TestQ5Q2A3Text,
                TestQ5Q2Text,
                TestQ5Q3A1Text,
                TestQ5Q3A2Text,
                TestQ5Q3A3Text,
                TestQ5Q3Text,
                TestQ5Q4A1Text,
                TestQ5Q4A2Text,
                TestQ5Q4A3Text,
                TestQ5Q4Text,
                TestQ5Q5A1Text,
                TestQ5Q5A2Text,
                TestQ5Q5A3Text,
                TestQ5Q5Text,
                TestQ5Q6A1Text,
                TestQ5Q6A2Text,
                TestQ5Q6A3Text,
                TestQ5Q6Text,
                TestQ5Q7A1Text,
                TestQ5Q7A2Text,
                TestQ5Q7A3Text,
                TestQ5Q7Text,
                TestQ5Q8A1Text,
                TestQ5Q8A2Text,
                TestQ5Q8A3Text,
                TestQ5Q8Text,
                TestQ5Q9A1Text,
                TestQ5Q9A2Text,
                TestQ5Q9A3Text,
                TestQ5Q9Text,
                TestQ6Q10A1Text,
                TestQ6Q10A2Text,
                TestQ6Q10A3Text,
                TestQ6Q10Text,
                TestQ6Q1A1Text,
                TestQ6Q1A2Text,
                TestQ6Q1A3Text,
                TestQ6Q1Text,
                TestQ6Q2A1Text,
                TestQ6Q2A2Text,
                TestQ6Q2A3Text,
                TestQ6Q2Text,
                TestQ6Q3A1Text,
                TestQ6Q3A2Text,
                TestQ6Q3A3Text,
                TestQ6Q3Text,
                TestQ6Q4A1Text,
                TestQ6Q4A2Text,
                TestQ6Q4A3Text,
                TestQ6Q4Text,
                TestQ6Q5A1Text,
                TestQ6Q5A2Text,
                TestQ6Q5A3Text,
                TestQ6Q5Text,
                TestQ6Q6A1Text,
                TestQ6Q6A2Text,
                TestQ6Q6A3Text,
                TestQ6Q6Text,
                TestQ6Q7A1Text,
                TestQ6Q7A2Text,
                TestQ6Q7A3Text,
                TestQ6Q7Text,
                TestQ6Q8A1Text,
                TestQ6Q8A2Text,
                TestQ6Q8A3Text,
                TestQ6Q8Text,
                TestQ6Q9A1Text,
                TestQ6Q9A2Text,
                TestQ6Q9A3Text,
                TestQ6Q9Text,
                TestQ7Q10A1Text,
                TestQ7Q10A2Text,
                TestQ7Q10A3Text,
                TestQ7Q10Text,
                TestQ7Q1A1Text,
                TestQ7Q1A2Text,
                TestQ7Q1A3Text,
                TestQ7Q1Text,
                TestQ7Q2A1Text,
                TestQ7Q2A2Text,
                TestQ7Q2A3Text,
                TestQ7Q2Text,
                TestQ7Q3A1Text,
                TestQ7Q3A2Text,
                TestQ7Q3A3Text,
                TestQ7Q3Text,
                TestQ7Q4A1Text,
                TestQ7Q4A2Text,
                TestQ7Q4A3Text,
                TestQ7Q4Text,
                TestQ7Q5A1Text,
                TestQ7Q5A2Text,
                TestQ7Q5A3Text,
                TestQ7Q5Text,
                TestQ7Q6A1Text,
                TestQ7Q6A2Text,
                TestQ7Q6A3Text,
                TestQ7Q6Text,
                TestQ7Q7A1Text,
                TestQ7Q7A2Text,
                TestQ7Q7A3Text,
                TestQ7Q7Text,
                TestQ7Q8A1Text,
                TestQ7Q8A2Text,
                TestQ7Q8A3Text,
                TestQ7Q8Text,
                TestQ7Q9A1Text,
                TestQ7Q9A2Text,
                TestQ7Q9A3Text,
                TestQ7Q9Text,
                TestQ8Q10A1Text,
                TestQ8Q10A2Text,
                TestQ8Q10A3Text,
                TestQ8Q10Text,
                TestQ8Q1A1Text,
                TestQ8Q1A2Text,
                TestQ8Q1A3Text,
                TestQ8Q1Text,
                TestQ8Q2A1Text,
                TestQ8Q2A2Text,
                TestQ8Q2A3Text,
                TestQ8Q2Text,
                TestQ8Q3A1Text,
                TestQ8Q3A2Text,
                TestQ8Q3A3Text,
                TestQ8Q3Text,
                TestQ8Q4A1Text,
                TestQ8Q4A2Text,
                TestQ8Q4A3Text,
                TestQ8Q4Text,
                TestQ8Q5A1Text,
                TestQ8Q5A2Text,
                TestQ8Q5A3Text,
                TestQ8Q5Text,
                TestQ8Q6A1Text,
                TestQ8Q6A2Text,
                TestQ8Q6A3Text,
                TestQ8Q6Text,
                TestQ8Q7A1Text,
                TestQ8Q7A2Text,
                TestQ8Q7A3Text,
                TestQ8Q7Text,
                TestQ8Q8A1Text,
                TestQ8Q8A2Text,
                TestQ8Q8A3Text,
                TestQ8Q8Text,
                TestQ8Q9A1Text,
                TestQ8Q9A2Text,
                TestQ8Q9A3Text,
                TestQ8Q9Text,
                TestQ9Q10A1Text,
                TestQ9Q10A2Text,
                TestQ9Q10A3Text,
                TestQ9Q10Text,
                TestQ9Q1A1Text,
                TestQ9Q1A2Text,
                TestQ9Q1A3Text,
                TestQ9Q1Text,
                TestQ9Q2A1Text,
                TestQ9Q2A2Text,
                TestQ9Q2A3Text,
                TestQ9Q2Text,
                TestQ9Q3A1Text,
                TestQ9Q3A2Text,
                TestQ9Q3A3Text,
                TestQ9Q3Text,
                TestQ9Q4A1Text,
                TestQ9Q4A2Text,
                TestQ9Q4A3Text,
                TestQ9Q4Text,
                TestQ9Q5A1Text,
                TestQ9Q5A2Text,
                TestQ9Q5A3Text,
                TestQ9Q5Text,
                TestQ9Q6A1Text,
                TestQ9Q6A2Text,
                TestQ9Q6A3Text,
                TestQ9Q6Text,
                TestQ9Q7A1Text,
                TestQ9Q7A2Text,
                TestQ9Q7A3Text,
                TestQ9Q7Text,
                TestQ9Q8A1Text,
                TestQ9Q8A2Text,
                TestQ9Q8A3Text,
                TestQ9Q8Text,
                TestQ9Q9A1Text,
                TestQ9Q9A2Text,
                TestQ9Q9A3Text,
                TestQ9Q9Text,
                TestRepeat,
                TestResult
            };
            return _allValues;
        }
        

    }

}