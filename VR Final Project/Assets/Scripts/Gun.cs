using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    public InputActionProperty PinchAnimationAction;
    private void Update()
    {
        if (PinchAnimationAction.action.triggered)
        {
            Debug.Log(PinchAnimationAction.action.ReadValue<bool>());

         var x =   Instantiate(bulletPrefab, this.transform.position + Vector3.forward *3, this.transform.rotation);
            x.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000);
        }
    }
}
