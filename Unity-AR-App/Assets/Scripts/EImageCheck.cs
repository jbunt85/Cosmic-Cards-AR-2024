using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EImageCheck : MonoBehaviour
{
    private Animator mAnimator; // Identify new object

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>(); // Specifying that new object - animator from Unity
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic here if needed
    }

    public void ArriveScale() // When this function is called...
    {
        if (mAnimator != null)
        {
            mAnimator.SetTrigger("ETrigger"); // ...then it will launch my trigger animation (I will apply this when the image target is found)
            mAnimator.ResetTrigger("EReverse"); // Resetting the reverse in case it has already been activated
        }
    }

    public void ArriveScaleDown() // When the target is lost, I need to reset ready for the next trigger animation...
    {
        if (mAnimator != null)
        {
            mAnimator.SetTrigger("EReverse"); // Launching the reverse animation
            mAnimator.ResetTrigger("ETrigger"); // Resetting the trigger animation ready for next time
        }
    }
}

/// note: parts of this script were inspired from a YouTube Tutorial by ProfMoto (2023), which I accessed, followed and recreated on Dec 2023 from: https://www.youtube.com/watch?v=5-fEzg3ryss
/// note 2: I did create just one of these for all planet animations but it was too buggy and I ran out of time to create an efficient single script for all so I had to make the tradeoff of seperate script per planet - sigh... efficient coding will be a focus area for next semester! #learning
