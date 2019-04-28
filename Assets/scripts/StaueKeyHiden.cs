using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class StaueKeyHiden : MonoBehaviour
{
    private Interactable interactable;
    public Hand hand;
    public GameObject key;

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
            key.SetActive(true);
        }
    }
}
