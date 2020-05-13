using UnityEngine;
using UnityEditor;

static class CardUnityIntegration 
{

	[MenuItem("Assets/Create/Card")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<Card>();
	}

}
