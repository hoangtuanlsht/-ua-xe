using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManage : MonoBehaviour
{
    static public UIManage Instance;

    public GameObject bnGameOver;

    private void Awake()
    {
        UIManage.Instance = this;
        this.bnGameOver = GameObject.Find("Button");
        this.bnGameOver.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
