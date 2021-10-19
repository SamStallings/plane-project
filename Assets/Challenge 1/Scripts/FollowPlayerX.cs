using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //plane is set, but 999+ errors continue to show up
    public GameObject plane;
    private Vector3 offsetMainCam = new Vector3(20, 0, 0);
    private Vector3 camRotation = new Vector3(0, -90, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = plane.transform.position + offsetMainCam;
        // transform.rotation = Quaternion.Euler(camRotation);


        //the 2 lines of code above can be combined into 1 line as shown below:

        transform.SetPositionAndRotation(plane.transform.position + offsetMainCam, Quaternion.Euler(camRotation));
    }
}