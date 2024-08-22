using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class descbutton : MonoBehaviour
{
    private GameObject qh;
    // Start is called before the first frame update
    void Start()
    {
        qh = GameObject.FindGameObjectWithTag("questbarcontroller");
    }

    // Update is called once per frame
    public void loadQuest()
    {
        string tw = this.gameObject.GetComponentInParent<questHandler>().questDesc;
        string tn = this.gameObject.GetComponentInParent<questHandler>().questName;
        qh.GetComponent<questBarController>().loadQuestDesc(tw, tn);
    }
}
