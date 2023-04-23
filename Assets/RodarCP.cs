using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RodarCP : MonoBehaviour
{
    public InputActionReference rotateActionReference;
    public InputActionReference rotateEsqActionReference;
    public InputActionReference resetActionReference;
    public float rotateForce = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        rotateActionReference.action.performed += OnRotate;
        rotateEsqActionReference.action.performed += OnRotateEsq;
        resetActionReference.action.performed += OnReset;
    }

    private void OnRotate(InputAction.CallbackContext obj)
    {
        transform.Rotate(new Vector3(0.0f,1.0f,0.0f) * Time.deltaTime * rotateForce);
    }

    private void OnRotateEsq(InputAction.CallbackContext obj)
    {
        transform.Rotate(new Vector3(0.0f,1.0f,0.0f) * Time.deltaTime * -rotateForce);
    }

    private void OnReset(InputAction.CallbackContext obj)
    {
        transform.rotation = Quaternion.identity;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0.0f,1.0f,0.0f) * Time.deltaTime * rotateForce);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0.0f,1.0f,0.0f) * Time.deltaTime * -rotateForce);
        }

        // Reset
        if (Input.GetKey(KeyCode.R))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
