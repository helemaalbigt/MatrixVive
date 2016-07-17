using UnityEngine;
using System.Collections;

public class Destroyable : MonoBehaviour {

    public Transform _affected;
    public void Reset() {
        if(!_affected) _affected = this.transform; }
    public void Destroy() {

        GameObject.Destroy(_affected.gameObject);
    }
}
