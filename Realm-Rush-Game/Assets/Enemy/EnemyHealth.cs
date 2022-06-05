using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 2;
    [Tooltip("Adds amount to maxHitPoints when enemy dies")]
    [SerializeField] int difficultyRamp = 1;
    int currentHitPoints = 0;

    Enemy enemy;
    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    void Start() 
    {
        enemy = GetComponent<Enemy>();
    }
    void OnParticleCollision(GameObject other)
    {
        HitProcess();
    }

    void HitProcess()
    {
        currentHitPoints--;

        if (currentHitPoints < 1)
        {
            gameObject.SetActive(false);
            enemy.ReawardGold();
            maxHitPoints += difficultyRamp;
        }
    }
}
