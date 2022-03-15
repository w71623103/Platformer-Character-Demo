using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2Delegate : MonoBehaviour
{
    public void startAttack()
    {
        transform.Find("Attack2").GetComponent<Attack>().startAttack();
    }

    public void endAttack()
    {
        transform.Find("Attack2").GetComponent<Attack>().endAttack();
    }
}
