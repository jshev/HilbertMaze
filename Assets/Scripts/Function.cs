using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour {

	int myInt = 3;

	void Start (){
		myInt = Square(myInt);
		Debug.Log (myInt);
	}


	int Square (int number){
		int ret;
		ret = number * number;
		return ret;
	}
}
