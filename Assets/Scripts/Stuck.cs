using UnityEngine;
using UnityEngine.InputSystem;

public class Stuck : MonoBehaviour
{
    // initializing variables
    public Rigidbody player;

    public float sinkingSpeed = 0.1f;
    public float jumpForce = 5f;

    private int spamClicksNeeded = 10;
    private int spamClicksAmount = 0;
    private bool playerStuck = false;

    void Update()
    {
        if (playerStuck)

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            spamClicksAmount++;

            if (spamClicksAmount >= spamClicksNeeded)
            {
                Escape();
            }
        }
    }

    void FixedUpdate()
    {
        if (playerStuck)
        {
            player.linearVelocity = new Vector3(0f, -sinkingSpeed, 0f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody == player)
        {
            playerStuck = true;
            spamClicksAmount = 0;

            player.useGravity = false;
            player.linearVelocity = Vector3.zero;
        }
    }

    void Escape()
    {
        playerStuck = false;
        spamClicksAmount = 0;

        player.useGravity = true;
        player.linearVelocity = Vector3.zero;

        player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
