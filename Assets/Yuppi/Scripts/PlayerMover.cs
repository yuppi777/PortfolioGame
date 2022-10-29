using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Mover
{
    public class PlayerMover : MonoBehaviour
    {
        Rigidbody Rb;
        float X;
        float Z;

        public void OnInitialize()
        {
            Rb = GetComponent<Rigidbody>();

        }

        public void PlayerMove(float moveSpeed)
        {
            X = Input.GetAxisRaw("Horizontal");
            Z = Input.GetAxisRaw("Vertical");
            Rb.velocity = new Vector3(X, 0, Z) * moveSpeed;
        }
        public void PlayerJump(float jumPower)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rb.AddForce(transform.up * jumPower, ForceMode.Impulse);
            }
        } 
    }
}
