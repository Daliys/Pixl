using UnityEditor;
using UnityEngine;

namespace Localization
{
    /// <summary>
    /// This class is used to store localization ids in the inspector
    /// </summary>
    [CustomPropertyDrawer(typeof(LocalizationsIds))]
    public class LocalizationsIdsDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            var names = LocalizationsIds.GetAllValues();
            var values = new GUIContent[names.Length];
            var selectedValue = property.FindPropertyRelative("value").stringValue;

            for (int i = 0; i < names.Length; i++)
            {
                values[i] = new GUIContent(names[i].value);
            }

            int selectedIndex = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].value == selectedValue)
                {
                    selectedIndex = i;
                    break;
                }
            }
            
            selectedIndex = EditorGUI.Popup(position, label, selectedIndex, values);
            property.FindPropertyRelative("value").stringValue = names[selectedIndex].value;

            EditorGUI.EndProperty();
        }
    }
}
