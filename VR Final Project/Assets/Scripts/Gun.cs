using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    public InputActionProperty PinchAnimationAction;
    bool HoldingMe;

    private void Update()
    {
        if (HoldingMe)
        {
            Debug.Log(PinchAnimationAction.action.ReadValue<bool>());

            var x = Instantiate(bulletPrefab, this.transform.position + Vector3.forward * 3, this.transform.rotation);
            x.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 1000);
            //.AddForce(this.transform.forward * 1000);
        }
    }

    
    public void HoldGun( )
    {
       
            print("HoldingMe = true");
            HoldingMe = true;
        
    }
    public void ReleaseGun()
    {
       
            print("HoldingMe = false");
            HoldingMe = false;
        
    }
}
