using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public GameObject camera_main;
    public GameObject camera_secondary;

    private Vector3 offset1 = new Vector3(0, 5, -8);
    private Vector3 offset2 = new Vector3(0, 3, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (camera_main.activeInHierarchy)
        {
            transform.position = player.transform.position + offset1;
        } else
        {
            transform.position = player.transform.position + offset2;
        }
    }
}
