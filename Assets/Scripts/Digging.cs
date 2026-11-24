using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ProBuilder.MeshOperations;

public class Digging : MonoBehaviour
{

    public GameObject dirt1;
    public GameObject dirt2;
    public GameObject dirt3;

    //public GameObject dirtPile1;
    //public GameObject dirtPile2;
    //public GameObject dirtPile3;


    private int digCount = 0;
    private bool isPlayerNearby = false;

    void Start()
    {
        dirt1.SetActive(true);
        dirt2.SetActive(true);
        dirt3.SetActive(true);

        //dirtPile1.SetActive(false);
        //dirtPile2.SetActive(false);
        //dirtPile3.SetActive(false);
    }

    void Update()
    {
        if (isPlayerNearby && Keyboard.current != null && Keyboard.current.qKey.wasPressedThisFrame)
        {
            Dig();
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            Debug.Log("Player entered collider");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            Debug.Log("Player out of range");
        }
    }

    void Dig()
    {
        digCount++;

        Debug.Log(digCount);

        if (digCount == 1)
        {
            dirt1.SetActive(false);
            //dirtPile1.SetActive(true);
        }


        else if (digCount == 2)
        {
            dirt2.SetActive(false);
            //dirtPile2.SetActive(true);
        }

        else if (digCount == 3)
        {
            dirt3.SetActive(false);
            //dirtPile3.SetActive(true);              
        }
    }
}
             
        
 


