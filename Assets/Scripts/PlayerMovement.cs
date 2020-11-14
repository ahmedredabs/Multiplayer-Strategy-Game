using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    
    private float horizontalMove;
    private float verticalMove;

    private bool isAttacking;
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Interact"))
        {
            isAttacking = true;
        }
    }

    private void FixedUpdate()
    {
        characterController.Move(horizontalMove,verticalMove, isAttacking);
        isAttacking = false;
    }
    
}
