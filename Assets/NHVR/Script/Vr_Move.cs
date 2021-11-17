using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vr_Move : MonoBehaviour
{
    public float Speed = 1.0f;
    public GameObject Player;
    public float Sensibility = 100f;
    float xRot = 0f; 
    float yRot = 0f; 

    // Update is called once per frame
    void Update()
    {

        

        if(Input.GetKey("right ctrl"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            float mouse_X = Input.GetAxis("Mouse X") * Sensibility * Time.deltaTime;
            float mouse_Y = Input.GetAxis("Mouse Y") * Sensibility * Time.deltaTime;

            xRot -= mouse_Y;
            xRot = Mathf.Clamp(xRot,-90f,90f);
            yRot += mouse_X;

            Player.transform.localRotation = Quaternion.Euler(xRot,yRot,0f);

        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");
        

        Vector3 move = transform.right * x + transform.forward * z;

        Player.transform.Translate(move * Speed * Time.deltaTime);
            
            //Player.transform.Rotate(Vector3.up * mouse_X);
        }
        else{
             Cursor.lockState = CursorLockMode.None;
        }
    }
}
