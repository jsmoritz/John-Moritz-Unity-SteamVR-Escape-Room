using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class turn : MonoBehaviour
{
    public SteamVR_Action_Vector2 turnPlayer;
    public float sensitivity = 0.5f;
    public bool hasSwipedLeft;
    public bool hasSwipedRight;
    public Player player;

    // Update is called once per frame
    void Update()
    {
        var leftHoriz = turnPlayer.GetAxis(SteamVR_Input_Sources.RightHand);
        var rightHoriz = turnPlayer.GetAxis(SteamVR_Input_Sources.RightHand);
        if (!hasSwipedLeft)
        {
            if (leftHoriz.x < -0.5f)
            {
                swipeLeft();
                hasSwipedLeft = true;
                hasSwipedRight = false;
            }
        }

        if (!hasSwipedRight)
        {
            if (rightHoriz.x > 0.5f)
            {
                swipeRight();
                hasSwipedRight = true;
                hasSwipedLeft = false;
            }
        }
        if (leftHoriz.x > -0.5f & rightHoriz.x < 0.5f)
        {
            hasSwipedLeft = false;
            hasSwipedRight = false;
            leftHoriz.x = 0;
            rightHoriz.x = 0;
        }
        void swipeLeft()
        {
            player.transform.Rotate(0, player.transform.rotation.y - 45, 0);
            Debug.Log("SwipeLeft");
        }
        void swipeRight()
        {
            player.transform.Rotate( 0,player.transform.rotation.y + 45,0);
            Debug.Log("SwipeRight");
        }
    }
}
