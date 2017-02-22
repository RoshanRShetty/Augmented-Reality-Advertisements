using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_info : MonoBehaviour {

	// Update is called once per frame
	public void if_clicked (string show_info) {
		Application.LoadLevel(show_info);
	}
}
