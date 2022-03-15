using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    public MovementModel movModel;
    public Data model;
    private Core core;

    public Movement(MovementModel newModel, Data newData) { movModel = newModel; model = newData; }

    //control player sprite facing left/right
    public void scaleControl()
    {
        if (movModel.horizontalMovement < 0)
            movModel.isLeft = true;
        else if (movModel.horizontalMovement > 0)
            movModel.isLeft = false;

    }

    public void hMovement()
    {
        model.characterRB.velocity = new Vector2(movModel.horizontalMovement, model.characterRB.velocity.y);
    }
}
