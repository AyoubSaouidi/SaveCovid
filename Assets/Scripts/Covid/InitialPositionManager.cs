using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPositionManager : MonoBehaviour
{

    // Main Covid Controller
    public CovidController covidController;

    // Public fields
    private float minimumX;
    private float maximumX;    
    private float minimumY;
    private float maximumY;
    private float dangerZoneExtent = 4.3f;

    private void OnEnable()
    {
        float verticalExtent = Camera.main.orthographicSize;    
        float horizontalExtent = verticalExtent * Screen.width / Screen.height;
 
         // Calculations assume map is position at the origin
         minimumX = -1 * horizontalExtent + covidController.circleCollider.bounds.size.x / 2 + 1;
         maximumX = -1 * minimumX;
         minimumX = -1 * verticalExtent + covidController.circleCollider.bounds.size.y / 2 + 1;
         maximumX = -1 * minimumY;

         GenerateRandomPosition(minimumX,maximumX,minimumY,maximumY);
    }

    private void GenerateRandomPosition(float minX,float maxX, float minY, float maxY){

        // Random Position
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        transform.position = new Vector2(randomX, randomY);

        // Recursivity to Assure that the Generated Position is Correct
        if(transform.position.x <= dangerZoneExtent 
        && transform.position.x >= -1*dangerZoneExtent
        && transform.position.y <= dangerZoneExtent 
        && transform.position.y >= -1*dangerZoneExtent)
            GenerateRandomPosition(minX,maxX,minY,maxY);
    }
}
