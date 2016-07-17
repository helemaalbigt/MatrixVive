using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	public WandController _Controller;
	public Transform _GunTip;
	public GameObject _BulletPrefab;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if(_Controller.triggerDown)
			FireBullet ();
	}

	private void FireBullet(){
		GameObject createdBullet = Instantiate (_BulletPrefab, _GunTip.position, Quaternion.identity) as GameObject;
		createdBullet.transform.up = _GunTip.transform.forward;
	}
}
