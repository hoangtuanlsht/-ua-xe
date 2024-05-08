using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSended : MonoBehaviour
{
    protected EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceived damageReceiver = collision.GetComponent<DamageReceived>();
        damageReceiver.Receive(1);

        this.enemyCtrl.despawner.Despawn();

        Debug.Log(collision.name);
    }
}
