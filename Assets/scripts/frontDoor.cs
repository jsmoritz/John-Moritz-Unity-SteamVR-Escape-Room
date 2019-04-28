using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class frontDoor : MonoBehaviour
{
    public Animator anim;
    public Collider collide;
    public soundManager soundManager;


    // Start is called before the first frame update
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
    
    private void OnTriggerEnter(Collider coll)
    {

        if (coll.tag == "key2")
            {
                soundManager.source.clip = soundManager.teleport;
                soundManager.source.Play();
                SteamVR_LoadLevel.Begin("win");

            }
     }
     private void OnTriggerExit(Collider coll)
     {
        collide.enabled = false;
     }
     
}
