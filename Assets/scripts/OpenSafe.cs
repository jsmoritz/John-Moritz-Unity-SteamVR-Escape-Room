using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSafe : MonoBehaviour
{
    public List<GameObject> numDisplay;
    public List<GameObject> nums;
    public soundManager soundManager;
    public variableManager variableManager;
    public safeDoorScript safeDoorScript;
    private GameObject clone;
    public GameObject pivot;
    public GameObject remote;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = pivot.GetComponent<Animator>();
        //clone = Instantiate(nums[1], numDisplay[1].transform.position, numDisplay[1].transform.rotation);
        //clone.transform.localScale = new Vector3(1, 1, 1);
        //clone.SetActive(true);
        //numDisplay[1].SetActive(false);

    }
    IEnumerator delay()
    {
        
        yield return new WaitForSeconds(2);
        
    }
    private void OnTriggerEnter(Collider coll)
    {

        string key = coll.tag;

        switch (key)
        {
            case"1":
                clone = Instantiate(nums[1], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                variableManager.OnButton++;
                variableManager.correct = 0;
                break;
            case "2":
                clone = Instantiate(nums[2], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                variableManager.OnButton++;
                variableManager.correct = 0;
                break;
            case "3":
                clone = Instantiate(nums[3], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                if(variableManager.OnButton != 2)
                {
                    variableManager.correct = 0;
                }
                variableManager.OnButton++;
                
                break;
            case "4":
                clone = Instantiate(nums[1], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                variableManager.OnButton++;
                variableManager.correct = 0;
                break;
            case "5":
                clone = Instantiate(nums[5], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                if (variableManager.OnButton != 3)
                {
                    variableManager.correct = 0;
                }
                variableManager.OnButton++;
                break;
            case "6":
                clone = Instantiate(nums[6], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                variableManager.OnButton++;
                variableManager.correct = 0;
                break;
            case "7":
                clone = Instantiate(nums[7], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                if (variableManager.OnButton != 5)
                {
                    variableManager.correct = 0;
                }
                variableManager.OnButton++;
                break;
            case "8":
                clone = Instantiate(nums[8], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                if (variableManager.OnButton != 1)
                {
                    variableManager.correct = 0;
                }
                variableManager.OnButton++;
                break;
            case "9":
                clone = Instantiate(nums[9], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                if (variableManager.OnButton != 4)
                {
                    variableManager.correct = 0;
                }
                variableManager.OnButton++;
                break;
            case "0":
                clone = Instantiate(nums[0], numDisplay[variableManager.OnButton].transform.position, numDisplay[variableManager.OnButton].transform.rotation);
                clone.tag = "clone";
                clone.transform.localScale = new Vector3(1, 1, 1);
                clone.SetActive(true);
                numDisplay[variableManager.OnButton].SetActive(false);
                soundManager.source.clip = soundManager.click;
                soundManager.source.Play();
                variableManager.OnButton++;
                variableManager.correct = 0;
                break;
        }
        
        if (variableManager.OnButton > 5)
        {
            if (variableManager.correct == 1)
            {
                Debug.Log("Open Safe");
                anim.SetTrigger("openSafeDoor");

                GameObject[] killEmAll;
                killEmAll = GameObject.FindGameObjectsWithTag("clone");
                for (int i = 0; i < killEmAll.Length; i++)
                {
                    Destroy(killEmAll[i].gameObject);
                }
                foreach (GameObject go in numDisplay)
                {
                    go.SetActive(true);
                }
                soundManager.source.clip = soundManager.openSafe;
                soundManager.source.Play();
                remote.SetActive(true);

                variableManager.correct = 1;
                variableManager.OnButton = 1;
            }
            else
            {
                StartCoroutine(delay());
                soundManager.source.clip = soundManager.error;
                soundManager.source.Play();
                GameObject[] killEmAll;
                killEmAll = GameObject.FindGameObjectsWithTag("clone");
                for (int i = 0; i < killEmAll.Length; i++)
                {
                    Destroy(killEmAll[i].gameObject);
                }
                foreach (GameObject go in numDisplay)
                {
                    go.SetActive(true);
                }
                variableManager.correct = 1;
                variableManager.OnButton = 1;
            }
        }
    }

}
