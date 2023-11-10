using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals : MonoBehaviour
{
    void Update()
    {

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.transform.position = new Vector2(-55.18f, 8.69f);
            collision.gameObject.GetComponent<SpriteRenderer>().color= Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
