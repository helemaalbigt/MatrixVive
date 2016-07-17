using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
	public static int _bestScoreShooter=1000;
	public static int _bestScoreRunner=0;
    public int _score = 0;
	public Text _textDisplayer;
	public Text _textBestDisplay;
	public Text _textBestRunnerDisplay;
    public GameObject _textRoot;


	public void SaveActualScore(){
		if (_score < _bestScoreShooter)
		{

			_bestScoreShooter = _score;
			_textBestDisplay.text = ""+_bestScoreShooter;

		}
		if (_score > _bestScoreRunner)
		{

			_bestScoreRunner = _score;
			_textBestRunnerDisplay.text = ""+_bestScoreRunner;

		}

	}
	public void Start(){
		_textBestDisplay.text = ""+_bestScoreShooter;
		_textBestRunnerDisplay.text = ""+_bestScoreRunner;
		_textDisplayer.text = ""+0;

	}

    public void AddScore() {
        _score++;
        _textDisplayer.text = "" + _score;
    }

    public void ResetScore() {
        _score = 0;
        _textDisplayer.text = "" + 0;

    }

    public void DisplayScore(bool isDisplay)
    {
        _textRoot.SetActive(isDisplay);
    }

}
