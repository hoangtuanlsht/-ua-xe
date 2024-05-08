using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceived : DamageReceived
{
    protected PlayerCtrl playerCtrl;
    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {

            this.playerCtrl.playerStatus.Dead();
            UIManage.Instance.bnGameOver.SetActive(true);
        }
    }


}
