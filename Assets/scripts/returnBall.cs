using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnBall : MonoBehaviour
{
    public GameObject ballStart;

    // Update is called once per frame
    void Update()
    {
        Transform ballTransform = gameObject.transform;
        Vector3 ballPos = ballTransform.position;
        float ypos = ballPos.y;

        if (ypos < .3f)
        {
            gameObject.transform.position = ballStart.transform.position;
        }
    }
}
