using DG.Tweening;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    public Transform target = null;

    public Animator anim;

    void Start()
    {

    }
    private void Move()
    {
        transform.DOMove(target.position, 2).OnComplete(Attack);
    }
    private void Attack()
    {
        Debug.Log($"Player is attacked  of {transform.gameObject.name}");
        anim.SetTrigger("attack");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject.transform;
            Debug.Log($"Player is target for{transform.gameObject.name}");

            Move();
        }

    }
}
