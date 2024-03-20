//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Bootstrap : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
//using UnityEngine;

//public class Bullet : MonoBehaviour, IMovable
//{
//    public Transform startPosition;
//    private Vector3 targetPosition;

//    public void StartMoving()
//    {
//        MoveTo(targetPosition);
//    }

//    public void MoveTo(Vector3 targetPosition)
//    {
//        transform.DOMove(targetPosition, 2).OnComplete(() => Reload());
//    }

//    private void Reload()
//    {
//        transform.position = startPosition.position;
//        StartMoving();
//    }
//}

////public class DistanceCalculator : MonoBehaviour
////{
////    public ITargetable currentTarget;
////    public ITargetable otherTarget;
////    public Transform player;

////    private void Update()
////    {
////        if (currentTarget != null && otherTarget != null)
////        {
////            if (CalculateDistance(currentTarget.Target) > CalculateDistance(otherTarget.Target))
////            {
////                SwitchTarget();
////            }
////        }
////    }

////    private float CalculateDistance(Transform target)
////    {
////        return Vector3.Distance(target.position, player.position);
////    }

////    private void SwitchTarget()
////    {
////        ITargetable temp = currentTarget;
////        currentTarget = otherTarget;
////        otherTarget = temp;
////    }
////}

////public class EnemyBehavior : MonoBehaviour, ITargetable, IMovable
////{
////    public Transform Target { get; set; }
////    public Animator anim;

////    private void Start()
////    {
////        if (Target != null)
////        {
////            MoveTo(Target.position);
////        }
////    }

////    public void MoveTo(Vector3 targetPosition)
////    {
////        transform.DOMove(targetPosition, 2).OnComplete(() => Attack());
////    }

////    private void Attack()
////    {
////        Debug.Log($"Player is attacked by {gameObject.name}");
////        anim.SetTrigger("attack");
////    }

////    private void OnTriggerEnter(Collider other)
////    {
////        if (other.CompareTag("Player"))
////        {
////            Target = other.transform;
////            MoveTo(Target.position);
////        }
////    }
////}

////public class SpawnEnemy : MonoBehaviour
////{
////    public Transform enemy1;
////    public Transform enemy2;
////    public Transform[] spawnPool;

////    private void Start()
////    {
////        DoSpawnEnemy();
////    }

////    public void DoSpawnEnemy()
////    {
////        if (spawnPool.Length > 0)
////        {
////            int index1 = Random.Range(0, spawnPool.Length);
////            int index2 = Random.Range(0, spawnPool.Length);

////            enemy1.position = spawnPool[index1].position;
////            enemy1.gameObject.SetActive(true);

////            enemy2.position = spawnPool[index2].position;
////            enemy2.gameObject.SetActive(true);
////        }
////        else
////        {
////            Debug.LogError("Spawn pool is empty!");
////        }
////    }
////}
