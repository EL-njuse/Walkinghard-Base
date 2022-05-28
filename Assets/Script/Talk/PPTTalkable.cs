using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPTTalkable : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    [TextArea(1, 3)]
    public string[] lines;
    public bool hasName = true;
    public int delayTime;
    private int hasBeenShow = 0;
    public bool ifBlace = false;

    public bool ifNext = false;//是否有下一步trigger
    public GameObject nextTrigger;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")&&hasBeenShow == 0)
        {
            isEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
        }
    }

    private void Update()
    {
        if (isEntered && DialogueManager.instance.dialogueBox.activeInHierarchy == false && hasBeenShow == 0)
        {
            Invoke("saySomething", delayTime);
            hasBeenShow++;
        }

        if (ifNext && DialogueManager.instance.ifFinished&&hasBeenShow == 1)
        {
            nextTrigger.SetActive(true);
        }
    }

    private void saySomething()
    {
        DialogueManager.instance.ShowDialogue(lines);

    }


}
