using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data : Model
{
    public int Hp;
    public int maxHp;
    public Rigidbody2D characterRB;

    [System.NonSerialized] public int combo = 0;
    public int maxCombo;

    public float attackTimer = 0;
    public float maxAttackTimer = 1f;

    public Animator characterAnim;
    public int isGroundedHash;
    public int isMovingHash;
    public int attackStateHash;
}
