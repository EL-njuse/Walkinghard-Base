using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public GameObject dialogueBox;//Display or hide
    public Text dialogueText, nameText;
    private bool isScrolling = true;
    [SerializeField] private float textSpeed;

    [TextArea(1, 3)]
    public string[] dialogueLines;
    [SerializeField] private int currentline;
    public bool ifFinished = false;

    private void Awake()//µ¥ÀýÄ£Ê½
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        //dialogueText.text = dialogueLines[currentline];
    }


    // Update is called once per frame
    void Update()
    {
        ifFinished = false;
        if (dialogueBox.activeInHierarchy)
        {
            if (Input.GetMouseButtonUp(0) && dialogueText.text == dialogueLines[currentline])
            {
                if (isScrolling == false)
                {
                    currentline++;

                    if (currentline < dialogueLines.Length)
                    {
                        CheckName();
                        //dialogueText.text = dialogueLines[currentline];
                        StartCoroutine(ScrollingText());
                    }
                    else
                    {
                        dialogueBox.SetActive(false);
                        FindObjectOfType<playerControlled>().canMove = true;
                        ifFinished = true;
                    }
                }

            }
        }

    }

    public void ShowDialogue(string[] _newLines)
    {
        dialogueLines = _newLines;
        currentline = 0;

   
            CheckName();
    

        //dialogueText.text = dialogueLines[currentline];
        StartCoroutine(ScrollingText());
        dialogueBox.SetActive(true);
        FindObjectOfType<playerControlled>().canMove = false;
    }

    public void CheckName()
    {
        if (dialogueLines[currentline].StartsWith("n-"))
        {
            nameText.text = dialogueLines[currentline].Replace("n-", "");
            currentline++;
        }
    }

    private IEnumerator ScrollingText()
    {
        isScrolling = true;
        dialogueText.text = "";

        foreach (char letter in dialogueLines[currentline].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
        isScrolling = false;
    }

    
}
