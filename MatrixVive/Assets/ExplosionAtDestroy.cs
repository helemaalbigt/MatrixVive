using UnityEngine;
using System.Collections;

public class ExplosionAtDestroy : MonoBehaviour {


	public LayerMask _layerAllow;
	public float explosionRadius = 0.5f;
	public float explosionForce = 1f;


	void OnDestroy () {
	
		Collider[] allAffected = Physics.OverlapSphere (transform.position, explosionRadius, _layerAllow);
		for (int i = 0; i < allAffected.Length; i++)
		{
			Collider affected = allAffected [i];
			Rigidbody rig = affected.gameObject.GetComponent<Rigidbody> ();
			if (rig)
			{
				rig.AddExplosionForce (explosionForce, transform.position, explosionRadius, 1f, ForceMode.Impulse);

			}
		}

	}
}
