// valA ---------> is the value we are given to compare
// baseLine---> this is the value we want to  achieve
// range --------> how far off the ValA can be compared to baseLine

private bool CompareValueWithTolerance(float valA, float valB, float range)
    {
        if(valA + range >= -(valB + range) && valA + range <= valB + range)
        {
            return true;
        }
        return false;
    }


//----------------------------- UNITY -----------------------------------------------------
#region Bit Mask Serialization Support

// Full Credit https://forum.unity.com/threads/editor-bit-mask.16841/
// Developer https://forum.unity.com/members/theonlysake.4105905/

#if UNITY_EDITOR
using System;
using UnityEditor;
using UnityEngine;

public class EnumMaskAttribute : PropertyAttribute
{
	public Type EnumType;
	public Enum Enum;
	public EnumMaskAttribute(Type enumType)
	{
		EnumType = enumType;
		Enum = (Enum)Enum.GetValues(enumType).GetValue(0);
	}
}

[CustomPropertyDrawer(typeof(EnumMaskAttribute))]
public class EnumMaskDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		EnumMaskAttribute enumMaskAttribute = attribute as EnumMaskAttribute;
		enumMaskAttribute.Enum = EditorGUI.EnumFlagsField(position, label, enumMaskAttribute.Enum);
		if (enumMaskAttribute.EnumType == typeof(Enum))
		{
			Debug.Log(enumMaskAttribute.Enum);
			property.intValue = Convert.ToInt32(Enum.Parse(enumMaskAttribute.EnumType, Enum.GetName(enumMaskAttribute.EnumType, enumMaskAttribute.Enum)));
		}
		else
		{
			property.intValue = Convert.ToInt32(enumMaskAttribute.Enum);
		}
	}
}
#endif 

// Use as follows
	[EnumMask(typeof(ECollectibles)), SerializeField]
	ECollectibles Item = 0;
#endregion
