using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlComeIn : MonoBehaviour
{
    public int hasBeenShow;

    public GameObject black;
    public GameObject girl;
    public GameObject Talk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (hasBeenShow == 0)
        {
            Invoke("DoSomething", 2);
            hasBeenShow++;
        }

    }

    private void DoSomething()
    {
        black.SetActive(false);
        girl.SetActive(true);
        Talk.SetActive(true);
    }
}
