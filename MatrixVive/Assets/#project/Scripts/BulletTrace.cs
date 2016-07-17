using UnityEngine;
using System.Collections;

public class BulletTrace : MonoBehaviour {

	public float _MaxLineDistance = 4;
	private bool _MaxDistanceReached = false;
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
		if (Vector3.Distance (_StartPos, transform.position) < _MaxLineDistance)
		{
			LR.SetPosition (1, transform.position);
		} else
		{
			if(!_MaxDistanceReached){
				_MaxDistanceReached = true;
				LR.useWorldSpace = false;
				LR.SetPosition (0, transform.InverseTransformPoint(_StartPos));
				LR.SetPosition (1, transform.InverseTransformPoint( transform.position));
			}
		}

	}
}
