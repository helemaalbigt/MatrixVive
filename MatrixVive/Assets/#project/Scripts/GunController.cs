using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class GunController : MonoBehaviour {

	public float _ReloadTime;
	public int _MagazineSize = 15;

	private bool _ReadyToFire = true;
	private bool _Recharging = false;
	private int _Bullets = 6;

	private AudioSource _Empty;

	public WandController _Controller;
	public Transform _GunTip;
	public GameObject _BulletPrefab;


    [Header("Events")]
    public UnityEvent _onBulletFiredEvent;

	// Use this for initialization
	void Start () {
		_Empty = GetComponent<AudioSource> ();
		_Bullets = _MagazineSize;
	}

	// Update is called once per frame
	void Update () {
		if (_Controller.triggerDown)
		{
			if (_ReadyToFire && _Bullets > 0)
			{
				_Bullets--;
				FireBullet ();
			} else
			{
				StartCoroutine (EmptyRumble ());
				_Empty.Play ();
				_ReadyToFire = false;

				if (!_Recharging)
				{
					_Recharging = true;
					StartCoroutine (Recharge ());
				}
			}
		}
	}

	private void FireBullet(){
		//instantiate bullet
		GameObject createdBullet = Instantiate (_BulletPrefab, _GunTip.position, Quaternion.identity) as GameObject;
		createdBullet.transform.forward = _GunTip.transform.forward;
        _onBulletFiredEvent.Invoke();
        //vibrate controller
		StartCoroutine(FireRumble(10, 0.075f*TimeSlower.factor));

	}
		
	IEnumerator Recharge(){
		Debug.Log (_ReloadTime * TimeSlower.factor);
		yield return new WaitForSeconds (_ReloadTime*TimeSlower.factor);

		StartCoroutine (RechargeRumble ());
		_Bullets = _MagazineSize;
		_ReadyToFire = true;
		_Recharging = false;
	}

	IEnumerator RechargeRumble(){
		_Controller.Vibrate (2000);
		yield return new WaitForSeconds (0.05f*TimeSlower.factor);
		_Controller.Vibrate (2000);
	}

	IEnumerator EmptyRumble(){
		_Controller.Vibrate (2000);
		yield return new WaitForSeconds (0.05f*TimeSlower.factor);
	}

	IEnumerator FireRumble(int rumbles, float duration){
		float timePassed = 0;

		while (timePassed < duration)
		{
			timePassed += ( duration / rumbles );

			_Controller.Vibrate (2000);
			yield return new WaitForSeconds ((duration / rumbles)*TimeSlower.factor);
		}
	}

}
