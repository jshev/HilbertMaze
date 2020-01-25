using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

	string[] games = {"Bioshock", "Alice: Madness Returns", "Portal 2"};

	void Start () {  
		for(int i = 0; i < games.Length; i++) {
			Debug.Log(games[i]);
		}
	}
}
