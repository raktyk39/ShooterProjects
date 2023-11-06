using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombeeBig : MonoBehaviour
{
    public GameObject YakuZombee;
    public float spawnTime;

        void Start()
        {
          YakuZombee = Resources.Load("Prefabs/BigYakuZombee") as GameObject; // Сделали путь к обьекту , перезаписываем как игровой обьект
          StartCoroutine("WaitTimeForSpawn");
        }

        IEnumerator WaitTimeForSpawn() 
        {
            while (true)
            { 
              spawnTime = 25f;
              yield return new WaitForSeconds(spawnTime);
              Instantiate(YakuZombee.gameObject, gameObject.transform.position,Quaternion.identity);
            }
        }
}
