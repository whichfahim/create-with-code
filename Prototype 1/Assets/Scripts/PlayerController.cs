using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    public GameObject mainCamera;
    public GameObject hoodCamera;
    public KeyCode switchKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get player input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        if (Input.GetKeyDown(switchKey))
        {
            if (mainCamera.activeInHierarchy)
            {
                mainCamera.SetActive(false);
                hoodCamera.SetActive(true);
            } else
            {
                hoodCamera.SetActive(false);
                mainCamera.SetActive(true);
            }
            //mainCamera.SetActive(!mainCamera.activeSelf);
            //hoodCamera.SetActive(!hoodCamera.activeSelf);
        }



    }
}
