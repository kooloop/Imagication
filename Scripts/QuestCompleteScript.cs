using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;


using Photon.Pun;
using Photon.Realtime;

public class QuestCompleteScript : MonoBehaviour
{
    public TextMeshProUGUI questComplete;
    public TextMeshProUGUI subText;

    public Image questCompleteBase;

    private float delayTimer = 4.5f;

    void Awake(){
        questComplete.gameObject.SetActive(false);
        subText.gameObject.SetActive(false);
        questCompleteBase.gameObject.SetActive(false);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("QuestComplete Script Started");
    }

    // Update is called once per frame
    void Update()
    {
        if(PopUpSystem.nameOfBuildings.Count == 4 && PopUpSystem.questCompleted){
            questComplete.gameObject.SetActive(true);
            subText.gameObject.SetActive(true);
            questCompleteBase.gameObject.SetActive(true);
            Debug.Log("Object is active as true");

            delayTimer -= Time.deltaTime;

            if(delayTimer <= 0){
                questComplete.gameObject.SetActive(false);
                subText.gameObject.SetActive(false);
                questCompleteBase.gameObject.SetActive(false);
            }
        }
    }
}
