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
var Camera11 : Camera;
var Camera12 : Camera;

function Start(){
    
    
        Camera1.enabled = true;
        Camera2.enabled = false;
        Camera3.enabled = false;
        Camera4.enabled = false;
        Camera5.enabled = false;
        Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
}
 
function OnTriggerEnter (other : Collider) {
 
    if(other.gameObject.name == "Camera2Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = true;
        Camera3.enabled = false;
        Camera4.enabled = false;
        Camera5.enabled = false;
        Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
    }

	if(other.gameObject.name == "Camera1Trigger"){
 
        Camera1.enabled = true;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
     if(other.gameObject.name == "Camera3Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = true;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
     if(other.gameObject.name == "Camera4Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = true;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
     if(other.gameObject.name == "Camera5Trigger"){
 
         Camera1.enabled = false;
         Camera2.enabled = false;
         Camera3.enabled = false;
         Camera4.enabled = false;
         Camera5.enabled = true ;
         Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
          if(other.gameObject.name == "Camera6Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = true;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
          if(other.gameObject.name == "Camera7Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = true;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
          if(other.gameObject.name == "Camera8Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = true;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
          if(other.gameObject.name == "Camera9Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = true;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
          if(other.gameObject.name == "Camera10Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = true;
        Camera11.enabled = false;
        Camera12.enabled = false;
     }
        if(other.gameObject.name == "Camera11Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = true;
        Camera12.enabled = false;
     }
        if(other.gameObject.name == "Camera12Trigger"){
 
        Camera1.enabled = false;
        Camera2.enabled = false;
		Camera3.enabled = false;
		Camera4.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
        Camera7.enabled = false;
        Camera8.enabled = false;
        Camera9.enabled = false;
        Camera10.enabled = false;
        Camera11.enabled = false;
        Camera12.enabled = true;
     }




     }

