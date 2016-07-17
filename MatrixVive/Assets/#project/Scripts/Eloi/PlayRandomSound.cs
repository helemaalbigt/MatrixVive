using UnityEngine;
using System.Collections;

public class PlayRandomSound : MonoBehaviour {

    public AudioSource _audioSource;
    public AudioClip[] _randomSound;

	void Start () {
        _audioSource.clip = _randomSound[Random.Range(0, _randomSound.Length)];
        _audioSource.Play();


    }
	
}
