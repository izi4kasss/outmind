using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyVision ev;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tochka"))
        {
            ev.looksAt.target = ev.points[Random.Range(0, ev.points.Length)];
        }
    }
}
