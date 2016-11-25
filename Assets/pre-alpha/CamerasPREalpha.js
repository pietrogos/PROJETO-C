var Camera1 : Camera;
var Camera2 : Camera;
var Camera3 : Camera; 
var Camera4 : Camera; 
var Camera5 : Camera; 
var Camera6 : Camera; 
var Camera7 : Camera;
var Camera8 : Camera;
var Camera9 : Camera;
var Camera10 : Camera;


function Start(){
    
    
        Camera1.enabled = true;
        Camera2.enabled = false;
        Camera3.enabled = false;
        Camera4.enabled = false;
        Camera5.enabled = false;
}
 
function OnTriggerEnter (other : Collider) {
 
    if(other.gameObject.name == "Camera2Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = true;
        Camera3.enabled = false;
        Camera4.enabled = false;
        Camera5.enabled = false;
    }

	if(other.gameObject.name == "Camera1Trigger"){
 
        Camera1.enabled = true;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
     }
     if(other.gameObject.name == "Camera3Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = true;
		Camera4.enabled = false;
		Camera5.enabled = false;
     }
     if(other.gameObject.name == "Camera4Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = true;
		Camera5.enabled = false;
     }
     if(other.gameObject.name == "Camera5Trigger"){
 
         Camera1.enabled = false;
         Camera2.enabled = false;
         Camera3.enabled = false;
         Camera4.enabled = false;
         Camera5.enabled = true ;
     }
     }