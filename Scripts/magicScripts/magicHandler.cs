using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicHandler : MonoBehaviour
{
    public int[] infohubFlags = { 0, 0, 0, 0 }; //infohubQuest status
    public int[] questCompletion = { 0, 0 };    //all quest completion status
    public GameObject questObj;
    public GameObject celebrationObj;
    // Start is called before the first frame update
    void Start()
    {

    }


    public void checkForCompletion(int questIndex)
    {
        switch (questIndex)
        {
            case 0: //infohub quest
                if(infohubFlags[0]+ infohubFlags[1] + infohubFlags[2] + infohubFlags[3] == 4 && questCompletion[0] == 0)
                {
                    //yippee!!!!!!!
                    //quest complete splash triggers go here
                    questCompletion[0] = 1;
                    StartCoroutine(celebrationAnim());
                    questObj.GetComponent<questHandler>().questDone = true;
                }
                break;
            default:
                //amongus
                break;
        }
    }

    public IEnumerator celebrationAnim()
    {
        celebrationObj.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        celebrationObj.SetActive(false);
        yield return null;
    }
}
