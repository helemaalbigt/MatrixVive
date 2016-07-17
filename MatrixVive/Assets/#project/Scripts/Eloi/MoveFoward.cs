using UnityEngine;
using System.Collections;

public class MoveFoward : MonoBehaviour {

    public bool _allowToMove;
    public bool _allowMoaveAtStart=true;

    public float _speed = 1f;
    public Transform _affected;
    public Transform _direction;


    void Start() {

        if (_allowMoaveAtStart)
            _allowToMove = true;

    }

    void Reset()
    {
        if(!_affected)
            _affected = this.transform;
        if (!_direction)
            _direction = this.transform;
    }

	void Update () {
        if (!_allowToMove) return;
        _affected.position += _direction.forward * ( Time.deltaTime * _speed); 
	}

}
