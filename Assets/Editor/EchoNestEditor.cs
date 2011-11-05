using UnityEngine;
using UnityEditor;
using System.Collections;
 
[CustomEditor (typeof(EchoNest))]
public class EchoNestEditor : Editor
{
	EchoNest echoNest;

	public void OnEnable() {
		echoNest = (EchoNest)target;
	//	SceneView.onSceneGUIDelegate = EchoNestUpdate;
	}

	void EchoNestUpdate(SceneView sceneview) {
		Event e = Event.current;
	}
		
	public override void OnInspectorGUI()
    {
		GUILayout.BeginHorizontal();
	    GUILayout.Label(" API key ");
	    echoNest.apikey = EditorGUILayout.TextField(echoNest.apikey,  GUILayout.ExpandWidth(true));
	    GUILayout.EndHorizontal();
		SceneView.RepaintAll();



    }
}
