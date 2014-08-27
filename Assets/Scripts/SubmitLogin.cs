using UnityEngine;
using System.Collections;

public class SubmitLogin : MonoBehaviour {


	public UILabel userInput;
	public UILabel passInput;

	public static string user = "", name = "";
	private string password = "";

	// Use this for initialization
	void OnClick () {

		user = userInput.text;
		password = passInput.text;


		Debug.Log (user);
		Debug.Log (password);

		WWWForm form = new WWWForm();
		form.AddField("user", user);
		form.AddField("password", password);
		WWW w = new WWW("http://austinhatem.com/MasterMind/login.php", form);
		StartCoroutine(login(w));
	
	}

	IEnumerator login(WWW w)
	{
		yield return w;
		if (w.error == null)
		{
			if (w.text == "login-SUCCESS")
			{
				Debug.Log ("WOOOOOOOOOOOOOOO!");
				userInput.text = "u got it!";
			}
			else
				Debug.Log (w.text);
		}
		else
		{
			Debug.Log (w.error);
		}
	}


}
