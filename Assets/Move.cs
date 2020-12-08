using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *=
            Quaternion.AngleAxis((float) (Input.GetAxis("Horizontal") * 30.0 * Time.deltaTime), new Vector3(0, 0, 1));
        transform.rotation *=
        Quaternion.AngleAxis((float)(Input.GetAxis("Vertical") * 30.0 * Time.deltaTime), new Vector3(1, 0, 0));
        
        //for mobile device
        transform.rotation *= Quaternion.AngleAxis((float) (Input.acceleration.y * 60.0 * Time.deltaTime), new Vector3(1, 0, 0));
        transform.rotation *= Quaternion.AngleAxis((float) (Input.acceleration.x * 60.0 * Time.deltaTime), new Vector3(0, 0, -1));

    }
}
