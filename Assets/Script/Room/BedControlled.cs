using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedControlled : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    public GameObject end1;
    public GameObject toRestroom;
    public GameObject black;

    public GameObject PressQ;
    public GameObject PressQrestroom;
    public bool hasBeenDead = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && isEntered)
        {
            if (closeDoor.instance.secure <= 1)
            {
                black.SetActive(true);
                end1.gameObject.SetActive(true);
            }
            else
            {
                hasBeenDead = true;
                toRestroom.gameObject.SetActive(true);
                PressQ.gameObject.SetActive(false);
                PressQrestroom.gameObject.SetActive(false);
            }
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
