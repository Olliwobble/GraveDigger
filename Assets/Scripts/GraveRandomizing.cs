using UnityEngine;

public class GraveRandomizing : MonoBehaviour
{

    public GameObject[] stuckColliders;

    void Start()
    {
        foreach (GameObject collider in stuckColliders)
        {
            collider.SetActive(false);
        }

        int randomIndex = Random.Range(0, stuckColliders.Length);

        stuckColliders[randomIndex].SetActive(true);

        Debug.Log("Getting stuck in grave " + stuckColliders[randomIndex].name);
    }
}
