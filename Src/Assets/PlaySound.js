#pragma strict

var audioClip : AudioClip;

function Awake () {

GetComponent.<AudioSource>().PlayOneShot(audioClip);
	
}


