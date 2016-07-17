using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class CollisionWithLayerDetection : MonoBehaviour {

    public LayerMask _layerAllowAsCollision;


    public delegate void OnHitDetected(Transform byWhat, Vector3 where);
    public OnHitDetected _onHitten;
    public UnityEvent _onHittendEvent;
    

    void OnTriggerEnter(Collider col) {

        if (IsInLayerMask(col.gameObject, _layerAllowAsCollision)) {
            
            if (_onHitten != null)
                _onHitten(col.transform, col.ClosestPointOnBounds(transform.position));
            _onHittendEvent.Invoke();

        }

    }

    public static bool IsInLayerMask(GameObject obj, LayerMask mask)
    {
        return ((mask.value & (1 << obj.layer)) > 0);
    }

}
