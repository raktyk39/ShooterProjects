using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombes : MonoBehaviour
{
      public Waves _waves;

      public GameObject YakuZombee;

      public float spawnTime;

      private float  minSpawnTime = 5f;

      private float  maxSpawnTime = 15f;

      void Start()
      {
          _waves = FindObjectOfType<Waves>();

          YakuZombee = Resources.Load("Prefabs/YakuZombee") as GameObject; // Сделали путь к обьекту , перезаписываем как игровой обьект
          
          StartCoroutine("WaitTimeForSpawn");
      }

      IEnumerator WaitTimeForSpawn() 
      {
          while (true)
          { 
              if(_waves.ZombieCount.Length < _waves.maxZombiesOnWave) 
              {
                  Instantiate(YakuZombee.gameObject, gameObject.transform.position,Quaternion.identity);
                  spawnTime = Random.Range(minSpawnTime,maxSpawnTime);
                  
                  yield return new WaitForSeconds(spawnTime);
              } 
              else 
              {
                  yield return new WaitForSeconds(spawnTime);
              }
            
          }
      }
}
