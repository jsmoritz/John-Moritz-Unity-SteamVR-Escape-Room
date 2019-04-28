using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class instructions : MonoBehaviour
{
    public SteamVR_Action_Boolean nextLevel;
    public GameObject startLocal;
    public Player player;
    public soundManager soundManager;
    private float _fadeDuration = 2f;
    public variableManager varManager;



    // Update is called once per frame
    void Update()
    {
        if (nextLevel.GetStateDown(SteamVR_Input_Sources.Any))
        {
            if (varManager.introFinished == 0)
            {
                soundManager.source.clip = soundManager.teleport;
                soundManager.source.Play();
                FadeToWhite();
                Invoke("tele", _fadeDuration);
                Invoke("FadeFromWhite", _fadeDuration);
                varManager.introFinished = 1;
            }

        }
    }
    private void tele()
    {
        player.transform.position =startLocal.transform.position;
    }
    private void FadeToWhite()
    {
        //set start color
        SteamVR_Fade.Start(Color.clear, 0f);
        //set and start fade to
        SteamVR_Fade.Start(Color.white, _fadeDuration);
    }
    private void FadeFromWhite()
    {
        //set start color
        SteamVR_Fade.Start(Color.white, 0f);
        //set and start fade to
        SteamVR_Fade.Start(Color.clear, _fadeDuration);
    }
    
}
