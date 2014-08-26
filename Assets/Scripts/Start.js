#pragma strict

function OnClick()
{
	PlayerPrefs.SetFloat("currentTime", 60.0F);
    Application.LoadLevel("Scene02");
}