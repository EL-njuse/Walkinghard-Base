using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedToFire : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    public GameObject end1;
    public GameObject black;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && isEntered)
        {
            black.SetActive(true);
            end1.SetActive(true);
         
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
