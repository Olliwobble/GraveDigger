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
        // checks if the player is stuck
        if (playerStuck)

        // player must spam space key a required amount of times
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // increments how many times space was pressed
            spamClicksAmount++;

            // if space is spammed as much as needed
            if (spamClicksAmount >= spamClicksNeeded)
            {
                Escape();
            }
        }
    }

    void FixedUpdate()
    {
        // checks if player is stuck
        if (playerStuck)
        {
            // player slowly sinks
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

        // player is given a jumpforce to jump out of the grave
        player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
