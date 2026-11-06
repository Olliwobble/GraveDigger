using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Digging : MonoBehaviour
{
    public GameObject dirtGround;
    public GameObject graveHole;
    public GameObject dirtPile;

    public float digTime = 3f;
    public float progress = 0f;

    void Start()
    {
        graveHole.SetActive(false);
        dirtPile.SetActive(false);
    }

    void Update()
    {
        if ((Mouse.current != null && Mouse.current.leftButton.isPressed) || (Keyboard.current != null && Keyboard.current.eKey.isPressed))
        {
            progress += Time.deltaTime;

            dirtPile.SetActive(true);
            dirtPile.transform.localScale = Vector3.one * Mathf.Clamp01(progress / digTime);

            if (progress >= digTime)
            {
                dirtGround.SetActive(false);
                graveHole.SetActive(true);
            }
        }
    }
}
