#pragma strict

var rotatespeed = 140;
var speed = 7;
var run = false;


function Update () {

	var controller : CharacterController = GetComponent(CharacterController);
	var y : float = Input.GetAxis ("Horizontal");
	var z : float = Input.GetAxis("Vertical");

transform.Rotate(Vector3(0,y,0) * Time.deltaTime * rotatespeed);

var forward = transform.TransformDirection(Vector3.forward);
     var curSpeed = speed * Input.GetAxis("Vertical");
     controller.SimpleMove(forward * curSpeed);
if(Input.GetButtonDown ("Fire1"))
    {   
    speed = 15;
    run = true;
}
else if (Input.GetButtonUp("Fire1")) {
 
      run = false;
	  speed = 7;

}
}