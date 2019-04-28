using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class keyFinal : MonoBehaviour
{
    private Interactable interactable;
    public Hand hand;
    public GameObject newLocal;
    public Player player;
    private float _fadeDuration = 2f;
    public variableManager varManager;
    public soundManager soundManager;


    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand)
        {
            if (varManager.teleported == 0)
            {
                soundManager.source.clip = soundManager.teleport;
                soundManager.source.Play();
                FadeToWhite();
                Invoke("tele", _fadeDuration);
                Invoke("FadeFromWhite", _fadeDuration);
                varManager.teleported = 1;
            }
        }
    }
    private void tele()
    {
        player.transform.position = newLocal.transform.position;
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
