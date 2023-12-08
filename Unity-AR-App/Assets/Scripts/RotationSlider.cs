using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // calls on a unity UI library

public class RotationSlider : MonoBehaviour
{

    public Slider rotationSlider;

    // Start is called only once before the first frame update
    void Start()
    {

    }

    // Update is called on repeat once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0,rotationSlider.value,0); //only looking to rotate on single y axis with no adjustment to x and z axis
    }
}
