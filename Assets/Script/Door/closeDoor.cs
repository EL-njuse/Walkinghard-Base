using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDoor : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    public int secure = 0;
    public Animator anim;
    public GameObject cheet;
    public GameObject chain;
    public GameObject talkingBox;
    // Start is called before the first frame update

    public static closeDoor instance;
    private void Awake()//单例模式
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
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && isEntered)
        {
            if (secure == 0)
            {
                anim.SetBool("close", true);
                secure++;
            }
            else if(secure == 1)
            {
                //添加铁链
                chain.SetActive(true);
                Invoke("delayOpen", 2);
                secure++;
            }
        }
    }

    private void delayOpen()
    {
        cheet.SetActive(true);
        talkingBox.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
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

}
