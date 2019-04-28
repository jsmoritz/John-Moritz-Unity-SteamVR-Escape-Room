using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch4 : MonoBehaviour
{
    public GameObject s4ON;
    public soundManager soundManager;

    private void OnTriggerEnter(Collider coll)
    {

        if (coll.tag == "lTip")
        {
            soundManager.source.clip = soundManager.click;
            soundManager.source.Play();
            gameObject.SetActive(false);
            s4ON.SetActive(true);

        }
    }
}
