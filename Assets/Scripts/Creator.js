#pragma strict

var thePre : GameObject; 
var isCreated: boolean;

function Update () 
{
	if (GameObject.Find("HowTo") == null && !isCreated)
	{
	var instance : GameObject = Instantiate(thePre, transform.position, transform.rotation);
	var instance2 : GameObject = Instantiate(thePre,  Vector2(.65, -0.4176471), transform.rotation);
	isCreated = true;
	}
}


