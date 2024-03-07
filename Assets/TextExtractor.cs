using UnityEngine;
using System.Collections;
using System.IO;

public class TextExtractor : MonoBehaviour {
	
	public TextAsset text;
	
	void Start () {
		File.WriteAllText("../data.prefab", text.text);           
	}
	
	void Update () {
		
	}
}