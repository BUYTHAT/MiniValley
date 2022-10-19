using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


public class WoodController : MonoBehaviour
{
    public GameObject go;
    void Update()
    {

    }

    public void WoodChopped()
    {
        // 나무 아이템 얻는 함수 실행.
        SpawnItem();

        //나무 삭제
        Destroy(this.gameObject, 1.0f);
        Debug.Log("WoodChopped!");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision w tree");
            WoodChopped();
        }
    }

    async void SpawnItem()
    {
        await Task.Delay(900);
        GameObject go = (GameObject)Instantiate(Resources.Load("Prefabs/Item_Wood"));
        GameObject.FindWithTag("DropItem").transform.position = this.transform.position;
        Debug.Log("Item Spawned");
    }



}
