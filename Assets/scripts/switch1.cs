using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class switch1 : MonoBehaviour
{
    
    public GameObject s1ON;
    public soundManager soundManager;
    public VideoPlayer vPlayer;
    public AudioSource aPlayer;
    public GameObject screen;
    public variableManager varManager;
    //public Light tvLight;


    private void OnTriggerEnter(Collider coll)
    {

        if (coll.tag == "lTip")
        {
            soundManager.source.clip = soundManager.click;
            soundManager.source.Play();
            gameObject.SetActive(false);
            s1ON.SetActive(true);
            vPlayer.Play();
            aPlayer.Play();
            screen.SetActive(false);
            varManager.tvOn = 1;
            //tvLight.enabled = true;
        }
    }
}
