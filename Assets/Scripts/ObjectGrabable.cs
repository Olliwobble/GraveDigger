using UnityEngine;

public class ObjectGrabable : MonoBehaviour
{


    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;
    private float userYawOffset;
    private float snapRotateDegrees;

    private float snapRotaterDegrees = 90f;
    [SerializeField] private bool followPlayerLook = true;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }



    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        objectRigidbody.useGravity = false;
    }

    public void Drop()
    {
        this.objectGrabPointTransform = null;
        objectRigidbody.useGravity = true;
    }

    private void Update()
    {
        if (objectGrabPointTransform == null) return;

        // Press R or Q to rotate in crisp building increments
        if (Input.GetKeyDown(KeyCode.R))
        {
            userYawOffset += snapRotateDegrees;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            userYawOffset -= snapRotateDegrees;
        }
    }

    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
    }
}

