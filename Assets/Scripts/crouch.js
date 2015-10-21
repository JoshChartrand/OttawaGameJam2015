var tongle = 0; var localScale : Vector3; //var JumpSpeed = 100.0f;

function Start () {  }

function Update () {

if (tongle == 0){ if (Input.GetKeyDown (KeyCode.LeftControl)) { 
transform.localScale += Vector3(0.0,-1,0); tongle = 1; 
} return; }

if (tongle == 1){ if (Input.GetKeyDown (KeyCode.LeftControl)) { 
transform.position.y += 0.5; 
transform.localScale += Vector3(0.0,1,0); tongle = 0; 
} return; } }