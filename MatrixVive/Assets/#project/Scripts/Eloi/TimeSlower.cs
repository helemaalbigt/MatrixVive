using UnityEngine;
using System.Collections;

public class TimeSlower : MonoBehaviour {

    public float _timeScaleWanted=0.5f;
	public static float factor;

	void Start () {
        Time.timeScale = _timeScaleWanted;
		factor = _timeScaleWanted;
    }
}
