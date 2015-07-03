﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 movement;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLength = 100f;

    void Awake() {
        floorMask = LayerMask.GetMask ("Floor");
        playerRigidbody = GetComponent<Rigidbody> ();
    }

    void FixedUpdate(){
        Turning ();
    }

    void Move (float h,float v){
        movement.Set (h, 0f, v);

        playerRigidbody.MovePosition (transform.position + movement); 

    }

    void Turning(){
        Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);

        RaycastHit floorHit;

        if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) {
            Vector3 playerToMouse = floorHit.point - transform.position;
            playerToMouse.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
            playerRigidbody.MoveRotation (newRotation);

        }
    }
}
