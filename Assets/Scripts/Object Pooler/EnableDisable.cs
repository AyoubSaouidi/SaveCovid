using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{

    public float duration;

    private void OnEnable() {
        Invoke("Destroy", duration);
    }

    private void OnDisable() {
        CancelInvoke();
    }

    void Destroy(){
        gameObject.SetActive(false);
    }
}
