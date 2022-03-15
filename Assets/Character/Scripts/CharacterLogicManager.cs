using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterLogicManager : MonoBehaviour
{
    //[SerializeField] private Data data;

    private void Start()
    {
        //data = GetComponent<Core>().model;
    }

    public abstract bool attackCondition();

    public abstract float hMovementCondition();
    

}
