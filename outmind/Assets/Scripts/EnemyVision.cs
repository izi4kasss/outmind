using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public Transform[] points;
    public AIDestinationSetter looksAt;
    // Update is called once per frame
    void Start()
    {
        looksAt = transform.parent.GetComponent<Pathfinding.AIDestinationSetter>();
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            looksAt.target = collision.gameObject.transform;
        }
       
    }
    
}
