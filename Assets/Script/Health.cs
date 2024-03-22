using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int healthMax = 100;

    public int healthCurent;

    private void Awake()
    {
        healthCurent = healthMax;
    }
    public void TakeDamage(int damage)
    {
        if (healthCurent >= 0)
        {
            healthCurent -= damage;
        }
        else
        {
            Debug.Log($"{gameObject.name} is Dead");
        }
    }
       
}
