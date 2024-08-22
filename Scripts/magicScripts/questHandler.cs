using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class questHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite checkedbox;
    public GameObject checkbox;
    public string questName;
    public string questDesc;
    public bool questDone = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(questDone)
        {
            checkbox.GetComponent<Image>().sprite = checkedbox;
        }
    }
}
