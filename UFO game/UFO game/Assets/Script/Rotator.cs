using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pick up rotator, no comment necessary here
public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
