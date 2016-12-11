#pragma strict

var CameraTrigger = Camera;


function OnTriggerEnter (other : Collider) {
    if(other.gameObject.name == "Player"){
        GetComponent(CameraMain);
        CameraMain.CameraMain == CameraTrigger;
        
    

    
    
    
    }
}

function Update () {

}