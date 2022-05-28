using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enter_FloorTwo : MonoBehaviour
{
    public Animator anim;
    public static enter_FloorTwo instance;
    private bool ifEnter = false;
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            return;
        }
        else
        {
            instance = this;
            //避免场景加载时该对象销毁
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && ifEnter == true&& DialogueManager.instance.dialogueBox.activeInHierarchy == false)
        {
            anim.SetBool("ifopen", true);
            Invoke("delayOpen", 2);
        }
    }

    private void delayOpen()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ifEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ifEnter = false;
        }
    }

}
