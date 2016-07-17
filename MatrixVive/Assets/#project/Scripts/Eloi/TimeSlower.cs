using UnityEngine;
using System.Collections;

public class TimeSlower : MonoBehaviour {

    public float _timeScaleWanted=0.5f;
	void Start () {
        Time.timeScale = _timeScaleWanted;

    }
}
