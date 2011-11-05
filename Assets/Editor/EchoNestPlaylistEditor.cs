using UnityEngine;
using UnityEditor;
using System.Collections;
 
[CustomEditor (typeof(EchoNestPlaylist))]
public class EchoNestPlaylistEditor : Editor
{
	EchoNestPlaylist echoNest;

	public void OnEnable() {
		echoNest = (EchoNestPlaylist)target;
	}

		
	public override void OnInspectorGUI() {

	    echoNest.apikey = EditorGUILayout.TextField(new GUIContent("API Key"),echoNest.apikey,  GUILayout.ExpandWidth(true));
	    echoNest.bucket = EditorGUILayout.TextField(new GUIContent("Bucket "),echoNest.bucket,  GUILayout.ExpandWidth(true));
		echoNest.artist = EditorGUILayout.TextField(new GUIContent("Seed Artist(s)"),echoNest.artist,  GUILayout.ExpandWidth(true));
		echoNest.results = (int) EditorGUILayout.Slider(new GUIContent("Number of Results"),echoNest.results, 0, 100);
		
	    
		echoNest.type = EditorGUILayout.Popup("Type", echoNest.type, echoNest.TYPE_OPTIONS, GUILayout.ExpandWidth(true));
		echoNest.style = EditorGUILayout.Popup("Style", echoNest.style, echoNest.STYLE_OPTIONS, GUILayout.ExpandWidth(true));
		echoNest.mood = EditorGUILayout.Popup("Mood", echoNest.mood, echoNest.MOOD_OPTIONS, GUILayout.ExpandWidth(true));

		echoNest.variety = EditorGUILayout.Slider(new GUIContent("Variety"),echoNest.variety, 0, 1);
		echoNest.adventurousness = EditorGUILayout.Slider(new GUIContent("Adventurousness"),echoNest.adventurousness, 0, 1);

        EditorGUILayout.MinMaxSlider(new GUIContent("Tempo"), ref echoNest.min_tempo, ref echoNest.max_tempo, 0, 500);
		EditorGUILayout.MinMaxSlider(new GUIContent("Duration"), ref echoNest.min_duration, ref echoNest.max_duration, 0, 3600);
		EditorGUILayout.MinMaxSlider(new GUIContent("Loudness"), ref echoNest.min_loudness, ref echoNest.max_loudness, -100, 100);
		EditorGUILayout.MinMaxSlider(new GUIContent("Dancability"), ref echoNest.min_dancability, ref echoNest.max_dancability, 0, 1);
		EditorGUILayout.MinMaxSlider(new GUIContent("Energy"), ref echoNest.min_energy, ref echoNest.max_energy, 0, 1);
		EditorGUILayout.MinMaxSlider(new GUIContent("Artist Familiarty"), ref echoNest.artist_min_familiarity, ref echoNest.artist_max_familiarity, 0, 1);
		EditorGUILayout.MinMaxSlider(new GUIContent("Artist Hotttnesss"), ref echoNest.artist_min_hotttnesss, ref echoNest.artist_max_hotttnesss, 0, 1);
		EditorGUILayout.MinMaxSlider(new GUIContent("Song Hotttnesss"), ref echoNest.song_min_hotttnesss, ref echoNest.song_max_hotttnesss, 0, 1);


	
	
	
		
	
		SceneView.RepaintAll();
    }
}
