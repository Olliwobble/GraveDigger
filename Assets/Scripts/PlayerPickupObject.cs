using UnityEngine;
using System.Collections.Generic;
public class PlayerPickupObject : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickUpLayerMask;


    private void Update()
    {
        if (Input.GetKeyDown (KeyCode.E))
        {
            float pickUpDistnce = 5f;
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistnce, pickUpLayerMask)) ;
            {

                if (raycastHit.transform.TryGetComponent(out ObjectGrabable objectGrabable))
                {
                Debug.Log(objectGrabable);
                }
            }
        }
    }
    
}
