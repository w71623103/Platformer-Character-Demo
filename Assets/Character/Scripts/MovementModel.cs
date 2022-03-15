using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MovementModel : Model
{
    public float moveSpeed;
    public float horizontalMovement;
    public bool isLeft;
    public bool isGrounded;
}
