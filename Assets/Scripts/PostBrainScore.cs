using UnityEngine;
using System.Collections;

public class PostBrainScore : MonoBehaviour {

	public UILabel thePostScore;

	public float brainScoreS2;
	public float brainScoreS3;
	public float brainScoreS4;
	public float brainScoreS5;

	public float brainScore;
	public string brainScoreTxt;

	// Use this for initialization
	void Start () {

		brainScoreS2 = PlayerPrefs.GetInt("S2brainScore");
		brainScoreS3 = PlayerPrefs.GetInt("S3brainScore");
		brainScoreS4 = PlayerPrefs.GetInt("S4brainScore");
		brainScoreS5 = PlayerPrefs.GetInt("S5brainScore");

		brainScoreS2 = brainScoreS2 / 40;
		brainScoreS3 = brainScoreS3 / 18;
		brainScoreS4 = brainScoreS4 / 20;
		brainScoreS5 = brainScoreS5 / 27;

	

		Debug.Log (brainScoreS2);
		Debug.Log (brainScoreS3);
		Debug.Log (brainScoreS4);
		Debug.Log (brainScoreS5);

		brainScore = ((brainScoreS2 + brainScoreS3 + brainScoreS4 + brainScoreS5) / 3) * 100;

		brainScoreTxt = brainScore.ToString ("F2");

		thePostScore.text = brainScoreTxt+" %";



	
	}

}
