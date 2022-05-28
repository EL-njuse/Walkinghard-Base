using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enter_FIre : MonoBehaviour
{
    // Start is called before the first frame update
    public static enter_FIre instance;
    public Animator anim;
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
            DontDestroyOnLoad(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
