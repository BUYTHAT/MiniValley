using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class DropItemController : MonoBehaviour
{
    [SerializeField] float itemSpeed = 4f;
    [SerializeField] float pickUpDistance = 2.5f;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, GameObject.FindWithTag("Player").transform.position);
        if (distance > pickUpDistance)
            return;

        transform.position = Vector3.MoveTowards(transform.position, GameObject.FindWithTag("Player").transform.position, itemSpeed * Time.deltaTime);
        if (distance < 0.1f)
        {
            Destroy(this.gameObject);
        }
    }
}
