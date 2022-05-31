using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    int currentHitPoints = 0;
    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }
    void OnParticleCollision(GameObject other)
    {
        HitProcess();
    }

    void HitProcess()
    {
        currentHitPoints--;
        Debug.Log("Now it has " + currentHitPoints + " lives");

        if (currentHitPoints < 1)
        {
            Debug.Log("You killed me!");
            gameObject.SetActive(false);
        }
    }
}
