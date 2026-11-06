using UnityEngine;
using UnityEngine.InputSystem;

public class Stuck : MonoBehaviour
{
    // variables
    public Rigidbody player;

    public float sinkingSpeed = 0.1f;
    public float jumpForce = 10f;

    private int spamClicksNeeded = 10;
    private int spamClicksAmount = 0;
    private bool playerStuck = false;

    void Update()
    {
        // if player is stuck, player slowly sinks
        if (playerStuck)
        {
            player.transform.position += Vector3.down * sinkingSpeed * Time.deltaTime;
        }

        // player must spam space key a required amount of times
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            spamClicksAmount++;

            // if key is spammed as much as needed
            if (spamClicksAmount >= spamClicksNeeded)
            {
                playerStuck = false;
                spamClicksAmount = 0;

                // player is given a jumpforce to jump out of the grave
                player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
