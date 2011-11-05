using UnityEngine;
using System.Collections;
//using JSONObject;


public class EchoNest : MonoBehaviour {
	public string apikey = "";
	// Use this for initialization
	IEnumerator Start () {
		string url =
		"http://developer.echonest.com/api/v4/song/search?api_key=" + apikey + "&format=json&results=1&artist=radiohead&title=karma%20police";
		WWW www = new WWW(url);
		yield return www;

		string encodedString = www.text; 
		JSONObject j = new JSONObject(encodedString);
		accessData(j);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void accessData(JSONObject obj){
	    switch(obj.type){
	        case JSONObject.Type.OBJECT:
	            for(int i = 0; i < obj.list.Count; i++){
	                string key = (string)obj.keys[i];
	                JSONObject j = (JSONObject)obj.list[i];
	                Debug.Log(key);
	                accessData(j);
	            }
	            break;
	        case JSONObject.Type.ARRAY:
	            foreach(JSONObject j in obj.list){
	                accessData(j);
	            }
	            break;
	        case JSONObject.Type.STRING:
	            Debug.Log(obj.str);
	            break;
	        case JSONObject.Type.NUMBER:
	            Debug.Log(obj.n);
	            break;
	        case JSONObject.Type.BOOL:
	            Debug.Log(obj.b);
	            break;
	        case JSONObject.Type.NULL:
	            Debug.Log("NULL");
	            break;

	    }
	}
	
	
	
}


