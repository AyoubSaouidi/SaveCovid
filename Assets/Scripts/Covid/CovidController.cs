using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CovidController : MonoBehaviour
{
    // Managers reference
    public MouvementManager mouvementManager;
    public CollisionManager collisionManager;
    public AnimationManager animationManager;

    // Animator Field
    [HideInInspector]
    public Animator animator;
    // Circle Collider 2D
    [HideInInspector]
    public CircleCollider2D circleCollider;

    // Start is called before the first frame update
    void Awake()
    {   
        animator = GetComponent<Animator>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

}
