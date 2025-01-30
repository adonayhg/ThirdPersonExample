using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GenericPool bulletPool;
    public float speed = 1;
    float timer = 5f;

    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        timer -= Time.deltaTime;
        if(timer< 0)
        {
            bulletPool.ReturnToPool(gameObject);
            timer = 5f;
        }
    }
}
