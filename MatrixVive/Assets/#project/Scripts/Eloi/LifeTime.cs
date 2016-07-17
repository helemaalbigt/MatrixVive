using UnityEngine;
using System.Collections;

public class LifeTime : MonoBehaviour {

	public float _lifeTime=10;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, _lifeTime);
	}

}
