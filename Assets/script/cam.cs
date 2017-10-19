using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {
    

    private void Update()
    {
        Vector3 movement = Vector3.zero;
        Vector3 camEuler = Camera.main.transform.rotation.eulerAngles;
        camEuler.x = 0f;
        Quaternion normalizedRotation = Quaternion.Euler(camEuler);

        if (Input.GetKey(KeyCode.W))
        {
            movement += normalizedRotation * Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement -= normalizedRotation * Vector3.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement -= normalizedRotation * Vector3.right;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += normalizedRotation * Vector3.right;
        }

        if (movement.magnitude > 1f)
        {
            movement = movement.normalized;
        }
        
    }
}
