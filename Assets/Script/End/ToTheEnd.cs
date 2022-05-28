using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTheEnd : MonoBehaviour
{
    public GameObject End;
    public GameObject nextButton;
    // Start is called before the first frame update
    void Start()
    {
        ToEnd();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToEnd()
    {
        FindObjectOfType<playerControlled>().canMove = false;
        Invoke("delay", 2);
    }

    public void delay()
    {
        End.SetActive(true);
        nextButton.SetActive(true);
    }
}
