using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class TentController : MonoBehaviour
{
    public Vector3 tentPos;
    public Vector3 tentEntPos;

    private void Start()
    {

        tentPos = transform.position;
        tentEntPos.x = tentPos.x;
        tentEntPos.y = tentPos.y + 3f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player Resting...");
            GameObject.FindWithTag("Player").transform.position = tentPos;
            GameObject.FindWithTag("Player").GetComponent<PlayerController>().playerStop = true;
            GameObject.FindWithTag("Player").GetComponent<PlayerHealthController>().leftHelath = GameObject.FindWithTag("Player").GetComponent<PlayerHealthController>().maxHealth;

            //Thread.Sleep(5000);

            Debug.Log("Player Done Resting");
            GameObject.FindWithTag("Player").transform.position = tentEntPos;
        }
    }
}
