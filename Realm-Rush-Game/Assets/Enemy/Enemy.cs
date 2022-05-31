using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldReward = 25;
    [SerializeField] int goldPenalty = 25;

    Bank bank;
    void Start()
    {
        bank = GameObject.Find("Bank").GetComponent<Bank>();
    }

    public void ReawardGold()
    {
        if(bank == null) { return; }
        bank.Deposit(goldReward);
    }

    public void StealGold()
    {
        if(bank == null) { return; }
        bank.Withdraw(goldPenalty);
    }
}
