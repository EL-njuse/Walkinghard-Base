using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callGirl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject deleteButton1;
    public GameObject deleteButton2;
    public GameObject girl;
    public GameObject boy;
    public GameObject phone;
    public GameObject black;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Delete()
    {
        deleteButton1.SetActive(false);
        deleteButton2.SetActive(false);
    }

    public void Moveplayer_delay()
    {
        Invoke("Moveplayer",  1 ) ;
    }


    public void Moveplayer()
    {
        black.SetActive(true);
        FindObjectOfType<playerControlled>().canMove = false;
        FindObjectOfType<playerControlled>().GetComponent<Transform>().position =
            new Vector3(14, -1.44F, 0);
        FindObjectOfType<playerControlled>().GetComponent<Transform>().localScale =
            new Vector3(-1, 1, 1); ;
    }

    public void talkonce()
    {
        phone.SetActive(true);
    }

    public void canMove()
    {
        FindObjectOfType<playerControlled>().canMove = true;
    }
}
