using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public PlayerCtrl Instance;

    public DamageReceived damageReceiver;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        PlayerCtrl.Instance = this;
        this.damageReceiver = GetComponent<DamageReceived>(); 
        this.playerStatus = GetComponent<PlayerStatus>(); 
    }
}
