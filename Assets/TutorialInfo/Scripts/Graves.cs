using UnityEngine;

public class Interract : MonoBehaviour
{
    public GameObject cube;
    public GameObject broken_Wall;
    public GameObject fixed_wall;
    // Start is called before the first frame update
    void Start()
    {
        fixed_wall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("Entered");
        }
        broken_Wall.SetActive(false);
        fixed_wall.SetActive(true);

    }
}