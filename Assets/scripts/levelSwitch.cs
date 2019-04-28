using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class levelSwitch : MonoBehaviour
{
    public SteamVR_Action_Boolean newScene;
    public int currLevel = 0;
    public string[] levelNames = new string[3] {"intro","SampleScene","win"};

    // Update is called once per frame
    void Update()
    {
        if (newScene.GetStateDown(SteamVR_Input_Sources.Any))
        {
            currLevel = (currLevel + 1) % 2;
            SteamVR_LoadLevel.Begin(levelNames[currLevel]);
        }
    }
}
