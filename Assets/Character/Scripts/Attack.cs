using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the effect of an attack
public class Attack : MonoBehaviour
{
    public int attackIndex;
    private int dmg;
    private BoxCollider2D col;
    private Core core;
    // Start is called before the first frame update
    void Start()
    {
        core = transform.parent.GetComponent<Core>();
        col = GetComponent<BoxCollider2D>();
        col.enabled = false;
        dmg = core.atkModel.dmg[attackIndex - 1];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log(collision.name + " takes " + dmg + " damage.");
        }
    }

    public void startAttack()
    {
        col.enabled = true;
        core.model.attackTimer = 0f;
    }

    public void endAttack()
    {
        col.enabled = false;
        if(attackIndex < core.model.maxCombo && Input.GetKey(KeyCode.J)) core.model.characterAnim.SetInteger(core.model.attackStateHash, attackIndex+1);
        else core.model.characterAnim.SetInteger(core.model.attackStateHash, 0);
    }
}
