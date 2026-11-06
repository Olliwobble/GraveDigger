using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has tocuhed the trigger");
        }
    }
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
