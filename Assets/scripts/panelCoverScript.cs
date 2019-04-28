using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelCoverScript : MonoBehaviour
{
    Animator anim;
    //Collider collide;
    public GameObject s1Off;
    public GameObject s2Off;
    public GameObject s3Off;
    public GameObject s4Off;
    public soundManager soundManager;


    private void Start()
    {
        anim = GetComponent<Animator>();
        //collide = GetComponent<Collider>();
        
    }

    private void OnTriggerEnter(Collider coll)
    {
        Debug.Log(coll.tag);
        if (coll.tag == "key")
        {
            soundManager.source.clip = soundManager.squeek;
            soundManager.source.Play();
            s1Off.SetActive(true);
            s2Off.SetActive(true);
            s3Off.SetActive(true);
            s4Off.SetActive(true);
            anim.SetTrigger("openDoor");
            Debug.Log("collided");
            
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        //collide.enabled = false;
    }
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
