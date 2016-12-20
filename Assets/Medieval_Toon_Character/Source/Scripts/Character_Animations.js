#pragma strict
internal var animator:Animator;
var v:float;
var h:float;
var run:float;

function Start () {
	animator=GetComponent (Animator);
}

function Update () {
	
	
}

function FixedUpdate (){
	animator.SetFloat("Walk",v);
	animator.SetFloat("Run",run);
	animator.SetFloat("Turn",h);
}

function Sprinting(){
	if (Input.GetKey(KeyCode.LeftShift)){
		run=0.2;
	}
	else
	{
		run=0.0;
	}
}