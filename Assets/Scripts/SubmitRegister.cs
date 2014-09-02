using UnityEngine;
using System.Collections;

public class SubmitRegister : MonoBehaviour {


	public UILabel userInput;
	public UILabel passInput;
	public UILabel alertTxt;

	public GameObject alertTxtObj;

	public static string user = "", name = "";
	private string password = "";

	// Use this for initialization
	void OnClick () {

		user = userInput.text;
		password = passInput.text;

		if(user != "Username" && password != "Password"){
		WWWForm form = new WWWForm();
		form.AddField("user", user);
		form.AddField("password", password);
		WWW w = new WWW("http://austinhatem.com/MasterMind/register.php", form);
		StartCoroutine(login(w));
		}
	
	}

	IEnumerator login(WWW w)
	{
		yield return w;
		if (w.error == null)
		{
			if (w.text == "Succesfully Created User!")
			{
				Debug.Log ("WOOOOOOOOOOOOOOO!");
				alertTxt.text = w.text;

				TweenAlpha tween = TweenAlpha.Begin (alertTxtObj, 1, 1);
				tween.from = 0F; 
				tween.to = 1F;
				StartCoroutine (slowFade());
			}

			else
			{
				alertTxt.text = w.text;

				TweenAlpha tween1 = TweenAlpha.Begin (alertTxtObj, 1, 1);
				tween1.from = 0F; 
				tween1.to = 1F;
				StartCoroutine (slowFade());
				Debug.Log (w.text);
			}
		}
		else
		{
			Debug.Log (w.error);
		}
	}


	IEnumerator slowFade() {
		yield return new WaitForSeconds (2F); 
		TweenAlpha tween3 = TweenAlpha.Begin (alertTxtObj, 1, 0);
		tween3.from = 1F; 
		tween3.to = 0F;
		
	}


}
