using UnityEngine;

public class PreviewObject : MonoBehaviour
{
    public float speed = 5;

    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") *speed * Time.deltaTime, 0);

    }
}
