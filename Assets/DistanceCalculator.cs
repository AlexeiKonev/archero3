using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
   public Bullet bullet;
   public Transform enemyOther;
    

    public Transform player;

    public Transform targetCurent;
    void Start()
    {
        targetCurent =  bullet.target;
    }

    // Update is called once per frame
    void Update()
    {
        Target();
    }

    public void Target()
    {
        //if distance to target more than to other enemy, change target
        if (Calculate(targetCurent) > Calculate(enemyOther))
        {
            SwitchTarget();
        }
    }

    public float Calculate(Transform tr)
    {
        float dist = Vector3.Distance(tr.position, player.transform.position);
        print("Distance to other: " + dist);
        return dist;
    }
    void SwitchTarget()
    {
         var  enemy = targetCurent;

        targetCurent = enemyOther;

        enemyOther = enemy;

        bullet.target= targetCurent;

    }
}
