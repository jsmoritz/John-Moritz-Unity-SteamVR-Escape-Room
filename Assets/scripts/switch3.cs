using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch3 : MonoBehaviour
{
    public GameObject s3ON;
    public soundManager soundManager;
    public GameObject vcrLight;
    public variableManager varManager;

    private void OnTriggerEnter(Collider coll)
    {

        if (coll.tag == "lTip")
        {

            soundManager.source.clip = soundManager.click;
            soundManager.source.Play();
            gameObject.SetActive(false);
            s3ON.SetActive(true);
            vcrLight.SetActive(true);
            varManager.vcrOn = 1;
        }
    }
}
