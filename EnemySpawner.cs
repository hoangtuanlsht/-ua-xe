using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    protected GameObject enemyPrefab;
    protected float timer = 0;
    protected float delay = 2f;

    private void Awake()
    {
        this.enemyPrefab = GameObject.Find("EnemyPrefab");
        this.enemyPrefab.SetActive(false);
    }
    private void Update()
    {
        this.Spawn();
    }
    protected virtual void Spawn()
    {
        if (PlayerCtrl.Instance.damageReceiver.IsDead()) return;

        this.timer += Time.deltaTime;
        if (timer < this.delay) return;
        this.timer = 0;

        GameObject enemy = Instantiate(this.enemyPrefab);
        enemy.transform.position= transform.position;
        enemy.SetActive(true);
        
    }
}
