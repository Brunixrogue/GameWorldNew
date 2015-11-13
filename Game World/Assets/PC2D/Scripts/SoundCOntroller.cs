using UnityEngine;
using System.Collections;

public class SoundCOntroller : MonoBehaviour {
    public AudioSource audio;
    public AudioClip jumpSound;




	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown(PC2D.Input.JUMP))
        audio.PlayOneShot(jumpSound);

    }
}
