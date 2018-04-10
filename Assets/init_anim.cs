using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class init_anim : MonoBehaviour {

    public Animator electronAnim;

	// Use this for initialization
	void Start ()
    {

        electronAnim.GetComponent<Animator>();
        electronAnim.Play("electron");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
