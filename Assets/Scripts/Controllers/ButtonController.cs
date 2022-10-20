using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void OnButtonClicked()
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerController>().playerStop = true;
        GameObject.FindWithTag("Player").GetComponent<PlayerToolController>().axeLevel += 1;
        Debug.Log("Axe Upgraded");
    }
}
