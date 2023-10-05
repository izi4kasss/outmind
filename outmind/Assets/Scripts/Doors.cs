using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator anim;
    public AstarPath path;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            anim.SetTrigger("open");
            Invoke("Rescan", 1.44674547454523456789234567890234567890458765678908090f);
            print("Peep");
        }
    }
    private void Rescan()
    {
        path.Scan();
    }
}
