using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zabor : MonoBehaviour
    
{
    public GameObject zaborF;
    public Player script;
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(KeyCode.E) && script.hasLom)
        {
            Instantiate(zaborF, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
