using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    // Main Covid Controller
    public CovidController covidController;


    public void SetTriggerDeathAnimation(){
        covidController.animator.SetTrigger("CovidDie");
    }

    public void ResetTriggerDeathAnimation(){
        covidController.animator.ResetTrigger("CovidDie");
    }
}
