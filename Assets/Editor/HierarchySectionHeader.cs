using UnityEditor;
using UnityEngine;

namespace GameUtility.Editor
{
	/// <summary>
	/// Simply re-styles a gameObject name in the Hierarchy window to be black and all caps.
	/// <para>Allows us to separate our gameObjects and not lose our minds.</para>
	/// </summary>
	[InitializeOnLoad]
	public static class HierarchySectionHeader
	{
		static HierarchySectionHeader ()
		{
			EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemOnGUI;
		}

		static void HierarchyWindowItemOnGUI (int instanceId, Rect selectionRect)
		{
			var gameObject = EditorUtility.InstanceIDToObject (instanceId) as GameObject;

			if (gameObject != null && gameObject.name.StartsWith ("//", System.StringComparison.Ordinal))
			{
				EditorGUI.DrawRect (selectionRect, Color.black);
				EditorGUI.DropShadowLabel (selectionRect, gameObject.name.Replace ("/", "").ToUpperInvariant ());
			}
		}
	}
}