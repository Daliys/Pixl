using UnityEditor;
using UnityEngine;

namespace Localization
{
    /// <summary>
    /// This class is used to store localization ids in the inspector
    /// </summary>
    [CustomPropertyDrawer(typeof(LocalizationsIds))]
    public class LocalizationsIdsDrawer : UnityEditor.PropertyDrawer
    {
        private static GUIContent[] _cachedValues;
        private static LocalizationsIds[] _cachedNames;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            if (_cachedNames == null)
            {
                _cachedNames = LocalizationsIds.GetAllValues();
                _cachedValues = new GUIContent[_cachedNames.Length];
                for (int i = 0; i < _cachedNames.Length; i++)
                {
                    _cachedValues[i] = new GUIContent(_cachedNames[i].value);
                }
            }

            var selectedValue = property.FindPropertyRelative("value").stringValue;

            int selectedIndex = 0;
            for (int i = 0; i < _cachedNames.Length; i++)
            {
                if (_cachedNames[i].value == selectedValue)
                {
                    selectedIndex = i;
                    break;
                }
            }
            
            selectedIndex = EditorGUI.Popup(position, label, selectedIndex, _cachedValues);
            property.FindPropertyRelative("value").stringValue = _cachedNames[selectedIndex].value;

            EditorGUI.EndProperty();
        }
    }
}
