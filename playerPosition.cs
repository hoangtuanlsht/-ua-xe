using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    List<GameObject> minions;
    public GameObject bomPrefab;
    protected float spawnTime = 0f; 
    protected float spawnDelay = 1f; 
    // Start is called before the first frame update
    private void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    private void Update()
    {
         this.Spawn();

        this.CheckMinionDead();
    }
    private void Spawn()
    {
        this.spawnTime += Time.deltaTime;
        if (spawnTime < this.spawnDelay) return;
        this.spawnTime = 0;
        if (this.minions.Count >= 7) return;
        int index = this.minions.Count + 1;
        GameObject minion = Instantiate(this.bomPrefab);
        minion.name = "Bomb #" + index;

        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);
        

    }

    void CheckMinionDead()
    {
        GameObject minion;
        for(int i =0; i< this.minions.Count; i++)
        {
            minion = this.minions[i];
            if(minion == null) this.minions.RemoveAt(i);
        }
    }

}
