using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zabor : MonoBehaviour
{
    public Sprite zaborF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.E))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = zaborF;
        }  
    }
}