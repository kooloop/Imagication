using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;

public class questBarController : MonoBehaviour
{
    public bool menuOpen = true;
    public Animator anim;
    public List<GameObject> quests;
    public bool inDesc = false;
    private GameObject qbh;
    public GameObject exitbutton;
    public GameObject questDesc;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        qbh = GameObject.FindGameObjectWithTag("questboxHeader");
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("menuOpen", menuOpen);
    }
    
    public void toggleMenu()
    {
        menuOpen = !menuOpen;
    }

    public void loadQuestDesc(string questdesc, string questname)
    {
        questDesc.SetActive(true);
        exitbutton.SetActive(true);
        qbh.GetComponent<TextMeshProUGUI>().text = questname;
        questDesc.GetComponent<TextMeshProUGUI>().text = questdesc;
        foreach (GameObject quest in quests)
        {
            quest.SetActive(false);
        }
    }
    public void hideQuestDesc()
    {
        questDesc.SetActive(false);
        exitbutton.SetActive(false);
        qbh.GetComponent<TextMeshProUGUI>().text = "Quests";
        foreach (GameObject quest in quests)
        {
            quest.SetActive(true);
        }
    }
}
