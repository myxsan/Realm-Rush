using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] float buildDelay = 0.25f;
    void Start()
    {
        StartCoroutine(Build());
    }
    [SerializeField] int cost = 75;
    public bool CreateTower(Tower tower, Vector3 position)
    {
        Bank bank = FindObjectOfType<Bank>();

        if(bank == null) { return false; }

        if(bank.CurrentBalance >= cost)
        {
            Instantiate(tower.gameObject, position, Quaternion.identity);
            bank.Withdraw(cost);
            return true;
        }
        return false;
    }

    IEnumerator Build()
    {
        foreach(Transform child in this.transform)
        {
            child.gameObject.SetActive(false);

            foreach(Transform grandChild in child)
            {
                grandChild.gameObject.SetActive(false);
            }
        }
        
        foreach(Transform child in this.transform)
        {
            child.gameObject.SetActive(true);

            yield return new WaitForSeconds(buildDelay);

            foreach(Transform grandChild in child)
            {
                grandChild.gameObject.SetActive(true);
            }
        }
    }
}
