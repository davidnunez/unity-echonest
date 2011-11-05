using UnityEngine;
using System.Collections;
//using JSONObject;


public class EchoNestPlaylist : MonoBehaviour {
	private string apiurl = "";
	public string apikey = "";
	public string bucket = "";
	public int type = 0;
	
	public string[] TYPE_OPTIONS = new string[] { "artist-radio","song-radio"};
	public float variety = 0.5f;
	public float adventurousness = 0.2f;
	public string artist = "";
	public int style = 0;
	public string [] STYLE_OPTIONS = new string[] {"none", "8-bit", "acoustic", "adult contemporary", "alternative", "ambient", "americana", "avant-garde", "ballad", "big band", "black metal", "bluegrass", "blues", "bossa nova", "celtic", "chanson", "christian", "classic rock", "classical", "club", "comedy", "country", "dance", "dark wave", "death metal", "disco", "drum and bass", "dub", "electronic", "electronica", "electropop", "emo", "experimental", "female volcalists", "folk", "funk", "fusion", "glitch", "gospel", "gothic", "grunge", "guitar virtuoso", "gypsy", "hardcore", "heavy metal", "hip hop", "house", "indie", "industrial", "instrumental", "j-pop", "j-rock", "jazz", "kpop", "latin", "lo-fi", "lounge", "male vocalist", "mediaeval", "metal", "minmimal", "motown", "musical", "new wave", "noise", "old school", "opera", "pop", "psychedelic", "punk", "r&amp;b", "rap", "reggae", "rock", "romantic", "roots", "singer-songwriter", "ska", "soul", "soundtrack", "style", "surf music", "swing", "symphonic", "tango", "techno", "trance", "trip hop", "turnablism", "world", "worship music"};
	
	public int mood = 0;
	
	public string [] MOOD_OPTIONS = new string[] {"none", "aggressive", "ambient", "angry", "angst-ridden", "bouncy", "calming", "carefree", "cheerful", "cold", "complex", "cool", "dark", "disturbing", "dramatic", "dreamy", "eerie", "elegant", "energetic", "enthusiastic", "epic", "fun", "funky", "futuristic", "gentle", "gleeful", "gloomy", "groovy", "happy", "harsh", "haunting", "humorous", "hypnotic", "industrial", "intense", "intimate", "joyous", "laid-back", "light", "lively", "manic", "meditation", "melancholia", "mellow", "mystical", "ominous", "party music", "passionate", "pastoral", "peaceful", "playful", "poignant", "quiet", "rebellious", "reflective", "relax", "romantic", "rowdy", "sad", "sentimental", "sexy", "smooth", "soothing", "sophisticated", "spacey", "spiritual", "strange", "sweet", "theater", "trippy", "warm", "whimsical"};
	
	
	public int results = 15;
	public float max_tempo = 500.0f;
	public float min_tempo = 0.0f;
	public float max_duration = 3600.0f;
	public float min_duration = 0.0f;
	public float max_loudness = 100.0f;
	public float min_loudness = -100.0f;

	public float max_dancability = 1.0f;
	public float min_dancability = 0.0f;
	public float max_energy = 1.0f;
	public float min_energy = 0.0f;
	
	
	public float artist_max_familiarity = 1.0f;
	public float artist_min_familiarity = 0.0f;
	public float artist_max_hotttnesss = 1.0f;
	public float artist_min_hotttnesss = 0.0f;
	public float song_max_hotttnesss = 1.0f;
	public float song_min_hotttnesss = 0.0f;

	
	
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
	
	void ExecuteSongSearch() {
		
		
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


