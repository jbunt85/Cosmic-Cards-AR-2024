using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //calling on the Unity Engine UI library

public class ScaleSlider : MonoBehaviour
{

    public Slider sliderScale;

    // Start is called once before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3 (sliderScale.value, sliderScale.value, sliderScale.value); //sets a new scale value for x, y and z axis updated in realtime
    }
}
