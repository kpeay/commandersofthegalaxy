using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour {

    static Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent <Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (PlayerMove.playerMoving == false)
        {
            anim.SetBool("Running", false);
        }

        else
        {
            anim.SetBool("Running", true);
        }

	}

    /**
    void OnAnimatorMove()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            Vector3 newPosition = transform.position;
            newPosition.z += animator.GetFloat("Runspeed") * Time.deltaTime;
            transform.position = newPosition;
        }
    }
    **/
}
