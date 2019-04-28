using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch2 : MonoBehaviour
{
    public GameObject s2ON;
    public soundManager soundManager;

    private void OnTriggerEnter(Collider coll)
    {

        if (coll.tag == "lTip")
        {
            soundManager.source.clip = soundManager.click;
            soundManager.source.Play();
            gameObject.SetActive(false);
            s2ON.SetActive(true);

        }
    }
}
