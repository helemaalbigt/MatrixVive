using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static int currentScore = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private IEnumerator GameLoop(){
		yield return StartCoroutine(RoundStarting());
		yield return StartCoroutine(RoundPlaying());
		yield return StartCoroutine(RoundEnding());
	}

	private IEnumerator RoundStarting(){
		yield return new WaitForSeconds (1f);
	}

	private IEnumerator RoundPlaying(){
		yield return new WaitForSeconds (1f);
	}

	private IEnumerator RoundEnding(){
		yield return new WaitForSeconds (1f);
	}
}
