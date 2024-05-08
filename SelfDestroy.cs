using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    void Start()
    {
        Invoke("Destroy", 10f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
