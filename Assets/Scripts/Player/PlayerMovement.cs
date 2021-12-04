using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Physics
    public Rigidbody2D rigidBody2D;

    // Animation
    public Animator walkAnimator;

    //Bool
    public bool AnimationSwitch = false;

    // User state
    private float _walkSpeed = 100f;
    public Vector2 Direction; //{ get; set; }
    public Vector2 Speed; //{ get; set; }

    // Update is called once per frame
    void Update()
    {
        //Input
        Direction.x = Input.GetAxisRaw("Horizontal");
        Direction.y = Input.GetAxisRaw("Vertical");
        Direction = Direction.normalized;
        Speed = Direction * _walkSpeed;

        if(AnimationSwitch)
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
