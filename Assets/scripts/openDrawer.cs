using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDrawer : MonoBehaviour
{
    public Animator anim;
    public GameObject tape;


    private void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "ball")
        {
            tape.SetActive(true);
            anim.SetTrigger("slideDrawer");
        }
        
    }


    
}
