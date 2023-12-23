using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SImageCheck : MonoBehaviour
{
    private Animator mAnimator; //identify new object

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>(); // specifying that new object - animator from Unity
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ArriveScale() // when this function is called...
    {
        mAnimator.SetTrigger("STrigger"); //... then it will launch my trigger animation (I will apply this when the image target is found)
        mAnimator.ResetTrigger("SReverse"); // resetting the reverse in case it has already been activated
    }

    public void ArriveScaleDown() // when the target is lost, I need to reset ready for the next trigger animation...
    {
        mAnimator.SetTrigger("SReverse"); // resetting the animation ready for next time
        mAnimator.ResetTrigger("STrigger"); //... then it will launch my trigger animation (I will apply this when the image target is found)
    }
}
/// note: parts of this script were inspired from a YouTube Tutorial by ProfMoto (2023), which I accessed, followed and recreated on Dec 2023 from: https://www.youtube.com/watch?v=5-fEzg3ryss
