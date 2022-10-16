using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float _speed = 5.0f;

    public Vector3 target;
    public Vector3 movement;

    public Animator animator;

    void Start()
    {
        target = transform.position;
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, _speed * Time.deltaTime);

        // if (target.x != transform.position.x || target.y != transform.position.y)
        // {
        //     animator.SetFloat("Speed", 1f);
        // }
        // else
        //     animator.SetFloat("Speed", 0f);
        movement.x = target.x - transform.position.x;
        movement.y = target.y - transform.position.y;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}