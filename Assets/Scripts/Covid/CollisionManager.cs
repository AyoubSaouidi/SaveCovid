using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    // Main Covid Controller
    public CovidController covidController;

    private void OnTriggerEnter2D(Collider2D collider) {
        ProcessCollision(collider);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        ProcessCollision(collision.collider);
        
    }

    private void ProcessCollision(Collider2D collider){
        if(collider.CompareTag("Danger")){
            

            //Show Death Effects
            GameObject deathEffect = Pool.instance.getObjectFromPool("PE_CovidDie");
            if(deathEffect == null) return;
            deathEffect.transform.position = transform.position;
            deathEffect.transform.rotation = transform.rotation;

            // DIE
            StartCoroutine("Die");
        }
    }


    IEnumerator Die(){
        // Is Dead Triggered
        covidController.animationManager.SetTriggerDeathAnimation();

        // Die
        Debug.Log("-- DEAD");
        yield return new WaitForSeconds(0.3f);

        // Reset Death Trigger
        covidController.animationManager.SetTriggerDeathAnimation();
        gameObject.SetActive(false);
    }
}
