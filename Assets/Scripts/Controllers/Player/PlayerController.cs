using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;





    public Vector3 target;
    public Vector3 movement;
    public Animator animator;
    public bool treeChopped = false;
    public bool playerStop = false;




    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            // we're not clicking on a UI object, so do your normal movement stuff here
            if (playerStop != true)
            {
                if (Input.GetMouseButton(0))
                {
                    target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    target.z = transform.position.z;
                }
            }
            else
            {
                target = transform.position;
                playerStop = false;
            }


            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

            //애니메이션
            movement.x = target.x - transform.position.x;
            movement.y = target.y - transform.position.y;

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);

        }
    }
}