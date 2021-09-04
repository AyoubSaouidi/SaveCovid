using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementManager : MonoBehaviour
{

    // Main Covid Controller
    public CovidController covidController;

    // Transforms
    public Transform soap;
    private Vector2 _mousePosition;

    // Public Fieds
    public float speed = 1f;
    public bool isDragged = false;

    // Start is called before the first frame update
    void Start()
    {
        isDragged = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDragged){
           transform.position =  Vector2.MoveTowards(transform.position ,soap.position , speed * Time.deltaTime);
        }
    }

     private void OnMouseDown() {
        isDragged = true;
    }

    private void OnMouseDrag() {
        if(isDragged)
        {
            Vector2 tempMousePosition = Input.mousePosition;
            _mousePosition = Camera.main.ScreenToWorldPoint(tempMousePosition);
            transform.position = _mousePosition;
        }
    }

    private void OnMouseUp() {
        isDragged = false;
    }
}
