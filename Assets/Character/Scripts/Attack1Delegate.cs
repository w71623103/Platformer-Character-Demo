using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1Delegate : MonoBehaviour
{
    public void startAttack()
    {
        transform.Find("Attack1").GetComponent<Attack>().startAttack();
    }

    public void endAttack()
    {
        transform.Find("Attack1").GetComponent<Attack>().endAttack();
    }
}
