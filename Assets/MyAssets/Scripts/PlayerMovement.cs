using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField]
    private float moveSpeed = 1;
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * moveSpeed, moveVertical * moveSpeed, 0);
            transform.position += movement;
        }
    }

    void Update() 
    {
        HandleMovement();
    }

}
