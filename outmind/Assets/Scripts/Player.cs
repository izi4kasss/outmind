using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Camera cam;
    private Vector2 mousePos;
    private bool hasBackpack;
    private bool hasLom;
    public Checkpoint checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(KeyCode.E) && collision.gameObject.CompareTag("DeskBackpack") && !hasBackpack)
        {
            hasBackpack = true;
            print(hasBackpack);
        }
        if (Input.GetKey(KeyCode.E) && collision.gameObject.CompareTag("Lom") && hasBackpack)
        {
            hasLom = true;
        }
        if (collision.gameObject.CompareTag("Enemy")){
            transform.position = checkpoint.transform.position;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            if (checkpoint.number + 1 == collision.gameObject.GetComponent<Checkpoint>().number)
            {
                checkpoint = collision.gameObject.GetComponent<Checkpoint>();
            }
        }
    }
}

