using UnityEngine;
using System.Collections.Generic;
public class PlayerPickupObject : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private Transform objectGrabPointTransform;

    private ObjectGrabable objectGrabbable;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabbable == null)
            {
                // Not carrying a n object, try to grab
                float pickUpDistnce = 5f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistnce, pickUpLayerMask)) ;
                {

                    if (raycastHit.transform.TryGetComponent(out objectGrabbable))
                        objectGrabbable.Grab(objectGrabPointTransform);
                    {
                        Debug.Log(objectGrabbable);
                    }
                }
            }
            else
            {
                // Curenty carrying something, drop
                objectGrabbable.Drop();
                objectGrabbable = null;
            }
        }
    }

}
