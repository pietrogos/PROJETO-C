#pragma strict

var Camera1 : Camera;
var Camera2 : Camera;
var myTimer : float = 140.0;
var musica : AudioSource;
var MAINCAMERA : GameObject;
var CAMERACarro : GameObject;
var trigger1 : float = 0;
var trigger2 : float = 0;

function Start () {
        Camera1.enabled = true;
        Camera2.enabled = false;
        musica.enabled = false;
        MAINCAMERA.SetActive(false);
        CAMERACarro.SetActive(true);
}

function Update () {
	if(myTimer > 0){
  		myTimer -= Time.deltaTime;
}
	if(myTimer <= trigger1){
		Camera1.enabled = false;
        Camera2.enabled = true;
        MAINCAMERA.SetActive(true);
        CAMERACarro.SetActive(false);
        }

	if(myTimer <= trigger2){
		musica.enabled = true;
		}


}