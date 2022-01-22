using UnityEngine;

public static partial class Constant
{
	public static class Path
	{
#if UNITY_EDITOR
		public static readonly string SavePath = Application.dataPath + "/Saves";
#else
		public static readonly string SavePath = Application.persistentDataPath + "/Saves";
#endif

	}
}
