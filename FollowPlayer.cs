using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Transform player;
    protected float speed = 7f;
    protected float dislimit = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Follow();
    }
    void Follow()
    {
        Vector3 distance = this.player.position - transform.position;

        if (distance.magnitude >= dislimit)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * dislimit;

            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}
