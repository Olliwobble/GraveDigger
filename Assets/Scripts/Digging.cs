using UnityEngine;
using UnityEngine.InputSystem;

public class Digging : MonoBehaviour
{
    // public GameObject graveHole;
    // public GameObject dirtPile;

    public GameObject dirt1;
    public GameObject dirt2;
    public GameObject dirt3;

    public GameObject dirtPile1;
    public GameObject dirtPile2;
    public GameObject dirtPile3;

    public float digTime = 3f;
    public float progress = 0f;

    void Start()
    {
        dirt1.SetActive(true);
        dirt2.SetActive(true);
        dirt3.SetActive(true);

        dirtPile1.SetActive(false);
        dirtPile2.SetActive(false);
        dirtPile3.SetActive(false);
    }

    void Update()
    {
        // check if LMB or E key is pressed
        if ((Mouse.current != null && Mouse.current.leftButton.isPressed) || (Keyboard.current != null && Keyboard.current.eKey.isPressed))
        {
            progress += Time.deltaTime;

            /* dirt pile grows in size
             dirtPile.SetActive(true);
             dirtPile.transform.localScale = Vector3.one * Mathf.Clamp01(progress / digTime);
            */

                

                //dirt2.SetActive(false);
                //dirt3.SetActive(false);
             
           }
     }
}
