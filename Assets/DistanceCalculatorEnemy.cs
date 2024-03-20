using System;
using UnityEngine;

public class DistanceCalculatorEnemy : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float distanceWarning = 18.22f;
    public static Action OnAtack;
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Calculate(target) < distanceWarning)
        {
            Debug.Log($"player captured;");
            if (OnAtack != null)
            {
                OnAtack.Invoke();

            }
        }
    }

    public float Calculate(Transform tr)
    {
        float dist = Vector3.Distance(tr.position, transform.position);

        return dist;
    }
}
