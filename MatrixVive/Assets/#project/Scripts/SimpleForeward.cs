using UnityEngine;
using System.Collections;

public class SimpleForeward : MonoBehaviour {

	private LineRenderer LR;
	private Vector3 _StartPos;

	// Use this for initialization
	void OnEnable () {
		LR = GetComponent<LineRenderer> ();
		_StartPos = transform.position;
		LR.SetPosition (0, _StartPos);
		LR.SetPosition (1, _StartPos);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up*0.01f);
		LR.SetPosition (1, transform.position);
	}
}
