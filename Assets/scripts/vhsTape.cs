using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class vhsTape : MonoBehaviour
    {
        [System.NonSerialized]
        public Hand attachedToHand;
        

        private void OnAttachedToHand(Hand hand)
        {
            attachedToHand = hand;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;



        }

        
    }
}



