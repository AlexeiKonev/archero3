using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    const string BULLET = "Bullet";
    const string SWORD = "Sword";

  private  Health health;

    private void Awake()
    {
        health = GetComponent<Health>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(BULLET) )
        {
         var damage =   other.gameObject.GetComponent<Bullet>().damage;

            health.TakeDamage(damage);
            Debug.Log($"Take damage from {BULLET}");
        }

        if (other.gameObject.CompareTag(SWORD))
        {
            Debug.Log($"Take damage from {SWORD}");
        }
    }
}
