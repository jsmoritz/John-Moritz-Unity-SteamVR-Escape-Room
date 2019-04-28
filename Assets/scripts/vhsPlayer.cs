using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
//using Valve.VR.InteractionSystem;


public class vhsPlayer : MonoBehaviour
{
    public GameObject tape;
    public GameObject tape2;
    public Animator vhsTape;
    public GameObject screen1;
    public GameObject screen2;
    public VideoPlayer vPlayer2;
    public AudioSource aPlayer2;
    public VideoPlayer vPlayer;
    public AudioSource aPlayer;
    public soundManager soundManager;
    public variableManager varmanager;

    
    private void OnTriggerEnter(Collider coll)
    {

        if (coll.tag == "tape")
        {
            if(varmanager.tvOn==1 && varmanager.vcrOn==1)
            {
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                tape.transform.SetParent(null);
                tape.SetActive(false);
                tape2.SetActive(true);
                screen1.SetActive(false);
                screen2.SetActive(true);
                aPlayer.Stop();
                vPlayer.Stop();
                vPlayer2.Play();
                aPlayer2.Play();
            }
            
            
            
        }
    }
}
