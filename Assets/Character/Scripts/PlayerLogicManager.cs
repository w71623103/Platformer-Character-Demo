using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogicManager: CharacterLogicManager
{
    public override bool attackCondition()
    {
        return Input.GetKeyDown(KeyCode.J) && GetComponent<Core>().model.attackTimer >= GetComponent<Core>().model.maxAttackTimer;
    }

    public override float hMovementCondition()
    {
        return Input.GetAxisRaw("Horizontal");
    }
    

}
