using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumpForce = 10.0f;
    public float gravityModifer = 1.0f;
    private bool isOnGround = true;
    // public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        isOnGround = true;
        // if (collision.gameObject.CompareTag("Ground")) {
        //     isOnGround = true;
        // } else if (collision.gameObject.CompareTag("Obstacle")) {
        //     gameOver = true;
        //     Debug.Log("Game Over!");
        // }
    }
}
