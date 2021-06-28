using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSaw : MonoBehaviour
{
    float sawspeed = 1f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, sawspeed);
    }
}
