using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnBigZombie : MonoBehaviour
{
  public Waves waves;

  public GameObject YakuZombee;

  public float spawnTime;

  public Vector3 SpawnPlace;    

  private void Start()
  {
    YakuZombee = Resources.Load("Prefabs/BigYakuZombee") as GameObject; // Сделали путь к обьекту , перезаписываем как игровой обьект
    StartCoroutine("SpawnBigZombiesTaimer");
    waves = FindObjectOfType<Waves>();
  }

  private IEnumerator SpawnBigZombiesTaimer() 
  {
    while (true)
    { 
        if(waves.ZombieCount.Length < waves.maxZombiesOnWave )  
        {
              SpawnPlace = new Vector3(Random.Range(-218,218),1, Random.Range(-288,288) );
              Instantiate(YakuZombee.gameObject, gameObject.transform.position,Quaternion.identity);
              spawnTime = 5f;
              yield return new WaitForSeconds(spawnTime);
        }
        else 
        {
          yield return new WaitForSeconds(spawnTime);
        }
    }
  }
}
