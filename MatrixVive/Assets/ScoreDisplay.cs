using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public int _score = 0;
    public Text _textDisplayer;
    public GameObject _textRoot;


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
