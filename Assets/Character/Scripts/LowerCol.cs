using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerCol : MonoBehaviour
{
    private Core core;
    // Start is called before the first frame update
    void Start()
    {
        core= transform.parent.GetComponent<Core>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            core.movModel.isGrounded= true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            core.movModel.isGrounded = false;
        }
    }
}
