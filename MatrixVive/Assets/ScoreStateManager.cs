using UnityEngine;
using System.Collections;

public class ScoreStateManager : MonoBehaviour {


    public ScoreDisplay _scoreDisplayer;

	void Start () {
        _scoreDisplayer.ResetScore();

	}
	
	
}
