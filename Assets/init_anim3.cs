using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init_anim3 : MonoBehaviour {

    public Animator electronAnim;

    // Use this for initialization
    void Start()
    {

        electronAnim.GetComponent<Animator>();
        electronAnim.Play("electron3");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
