using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementVersionKeybind : MonoBehaviour
{

    // Physics
    public Rigidbody2D rigidBody2D;

    // Animation
    public Animator walkAnimator;

    //Bool
    public bool AnimationSwitch = false;

    // User state
    private float _walkSpeed = 5f;
    private float _stairsSpeed = 0.5f;
    private float _runSpeed = 2f;
    public Vector2 Direction; //{ get; set; }
    public Vector2 Speed; //{ get; set; }
    
    //Multipliers
    private float SpeedMultiplier = 1f;
    private float StairsMultiplier = 1f;

    // Update is called once per frame
    void Update()
    {
        //Assign
        SpeedMultiplier = 1f;
        StairsMultiplier = 1f;
        Direction.x = 0f;
        Direction.y = 0f;     

        //Input
        if(GameInputManager.GetKey("Left") && GameInputManager.GetKey("Right"))
        {
            Direction.x = 0f;
            Debug.Log("Not Moving");
        }
        else if (GameInputManager.GetKey("Right")) // Horizontal check
        {
            Direction.x = 1f;
        }        
        else if (GameInputManager.GetKey("Left"))
        {
            Direction.x = -1f;
        }
        
        if (GameInputManager.GetKey("Up") && GameInputManager.GetKey("Down"))
        {
            Direction.y = 0f;
        }
        else if (GameInputManager.GetKey("Up")) // Vertical check
        {
            Direction.y = 1f;
        }        
        else if (GameInputManager.GetKey("Down"))
        {
            Direction.y = -1f;
        }

        Direction = Direction.normalized; // Really improtant step, pls don't delete it!!!
        
        if (GameInputManager.GetKey("Run"))
        {
            SpeedMultiplier *= _runSpeed;
        }
        
        Speed = Direction * _walkSpeed * SpeedMultiplier * StairsMultiplier;

        if (AnimationSwitch)
        {
            UpdateWalkAnimator();
        }
    }

    void FixedUpdate()
    {
        Vector2 deltaPosition = rigidBody2D.position + Speed * Time.fixedDeltaTime;
        rigidBody2D.MovePosition(deltaPosition);
    }

// ↓↓↓ to open folds use za / zo / zR, to close za / zc / zM ↓↓↓

    #region Movement
    void Normalization()//TODO fix
    {
        Direction = Direction.normalized;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Stairs
        if (other.tag == "Stairs")
        {
            //When Player Enters Staris collider his current speed is multiplayed by starisSpeed
            StairsMultiplier *= _stairsSpeed;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // if player leavs stairs it returns its StairsMultiplayer back to 1
        if (other.tag == "Stairs")
        {
            StairsMultiplier = 1f;
        }
    }
    
    #endregion

    #region Animation
    private void UpdateWalkAnimator()
    {
        walkAnimator.SetFloat("Horizontal", Direction.x);
        walkAnimator.SetFloat("Vertical", Direction.y);
        walkAnimator.SetFloat("Walk Speed", Direction.sqrMagnitude);
    }
    
    #endregion
}
