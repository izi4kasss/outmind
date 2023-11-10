using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    void Update()
    {
        Vector2 target = new Vector2(transform.position.x + 1, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, 13f*Time.deltaTime);

    }
}
