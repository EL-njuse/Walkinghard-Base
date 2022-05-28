using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOn : MonoBehaviour
{
    public GameObject deleteButton1;
    public GameObject deleteButton2;
    public GameObject things;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<playerControlled>().canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Delect()
    {
        deleteButton1.SetActive(false);
        deleteButton2.SetActive(false);
    }

    public void DestroyThing()
    {
        things.SetActive(false);
    }

    public void canMove()
    {
        FindObjectOfType<playerControlled>().canMove = true;
    }
}
