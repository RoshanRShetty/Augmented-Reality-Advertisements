using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class hide1 : MonoBehaviour {


	public Text abc;

	// Use this for initialization
	public void Start () {
		abc = GetComponent<Text> ();
		abc.enabled = false; 
	}

	// Update is called once per frame
	public void info_show () {
		abc = GetComponent<Text> ();

		if (abc.enabled == true) {
			abc.enabled = false; 


		} else {

			abc.enabled = true; 

		}
	}
}
