using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pie : MonoBehaviour
{
    public int pass = 0;
    public GameObject back;
    public bool isEntered;
    public static pie instance;

    public GameObject talkCube;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&&isEntered)
        {
            if(FindObjectOfType<mirror>().ifFound == true)
            {
                pass = 1;
            }
            else
            {
                pass = 0;
            }
            back.SetActive(true);
            talkCube.SetActive(true);
        }
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
