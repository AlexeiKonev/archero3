using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour
{
  public  Transform startPosition;

  public  Transform target;

  public int damage = 10;

  private  void Start()
    {
        Move();
    }

    // Update is called once per frame
    //private void Update()
    //{
        
    //}
    private void Reload( )
    {
        this.transform.position = startPosition.position;
        Move();
    }
    private void Move()
    {
        transform.DOMove(target.position, 2)
            .OnComplete(Reload);
    }
}
