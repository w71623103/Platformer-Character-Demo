using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public AttackModel atkModel = new AttackModel();
    public MovementModel movModel = new MovementModel();
    public Data model = new Data();
    [SerializeField] private CharacterLogicManager logic;

    private Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = new Movement(movModel, model);

        model.characterRB = GetComponent<Rigidbody2D>();

        model.characterAnim = GetComponent<Animator>();
        model.isMovingHash = Animator.StringToHash("isMoving");
        model.isGroundedHash = Animator.StringToHash("isGrounded");
        model.attackStateHash = Animator.StringToHash("attackState");
    }

    // Update is called once per frame
    void Update()
    {
        //Logics=======================================================================
        movModel.horizontalMovement = logic.hMovementCondition()  * movModel.moveSpeed;
        if (logic.attackCondition()) model.characterAnim.SetInteger(model.attackStateHash, 1);

        //=============================================================================


        //Timer========================================================================
        model.attackTimer += Time.deltaTime;

        //=============================================================================
        //hMovement
        movement.hMovement();
        model.characterAnim.SetBool(model.isMovingHash, movModel.horizontalMovement != 0f);
        model.characterAnim.SetBool(model.isGroundedHash, movModel.isGrounded);
        //ScaleControl
        movement.scaleControl();
        var scale = transform.localScale;
        if (movModel.isLeft)
            transform.localScale = new Vector3(scale.x < 0 || movModel.horizontalMovement == 0 ? scale.x : -scale.x, scale.y, scale.z);
        else
            transform.localScale = new Vector3(scale.x > 0 || movModel.horizontalMovement == 0 ? scale.x : -scale.x, scale.y, scale.z);
    }
}
