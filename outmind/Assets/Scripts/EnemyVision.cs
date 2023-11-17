using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public Vector2[] points;
    // Update is called once per frame
    void Update()
    {
        
    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            transform.parent.GetComponent<Pathfinding.AIPath>().enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.parent.GetComponent<Pathfinding.AIPath>().enabled = false;
    }
}
