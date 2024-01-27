using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Declare Private Variables
    public static InputActions playerInput;
    private Vector2 movement;
    private Rigidbody2D rigidbody;
    private Animator animator;
    
    //Declare Public Variables
    public float moveSpeed;
    public static bool interaction;
    
    //Enable input action map
    private void Awake() { playerInput = new InputActions(); }
    private void OnEnable() { playerInput.Enable(); }
    private void OnDisable() { playerInput.Disable(); }

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        interaction = false;
        
            //Player Movement
        movement = playerInput.PlayerMovement.Movement.ReadValue<Vector2>();
        //Debug.Log("Player Movement: " + movement);
        rigidbody.velocity += (movement * moveSpeed) / 10;

        if (playerInput.PlayerMovement.Interact.triggered)
        {
            interaction = true;
        }
        
        AnimatePlayer();
    }

    private void AnimatePlayer()
    {
       
        return;
    }
    
}
