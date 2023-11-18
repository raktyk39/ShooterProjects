using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnZombes : MonoBehaviour
{
  public Waves _waves;

  public GameObject YakuZombee;

  public GameObject YakuZombeeSpeed;

  public GameObject YakuBigZombe;

  public GameObject[] YakuZombes;

  public float spawnTime;

  private float minSpawnTime = 0f;

  private float maxSpawnTime = 1f;

  public Vector3 SpawnPlace;

  public int randomIndex;
      
  public GameObject selectedZombie;

  private void Start()
  {
    _waves = FindObjectOfType<Waves>();
    YakuZombeeSpeed = Resources.Load("Prefabs/YakuZombeeSpeed") as GameObject; // Сделали путь к обьекту , перезаписываем как игровой обьект
    YakuZombee = Resources.Load("Prefabs/YakuZombee") as GameObject;
    YakuBigZombe = Resources.Load("Prefabs/BigYakuZombee") as GameObject;
        
    YakuZombes = new GameObject[3];
    YakuZombes[0] = Resources.Load<GameObject>("Prefabs/YakuZombee");
    YakuZombes[1] = Resources.Load<GameObject>("Prefabs/BigYakuZombee");
    YakuZombes[2] = Resources.Load<GameObject>("Prefabs/YakuZombeeSpeed");
    StartCoroutine("WaitTimeForSpawn");
  }

  private IEnumerator WaitTimeForSpawn()
  {
    while (true)
    {
        if (_waves.ZombieCount.Length < _waves.maxZombiesOnWave)
        {
          randomIndex = Random.Range(0, YakuZombes.Length); // Генерируем случайный индекс
          selectedZombie = YakuZombes[randomIndex]; // Выбираем объект из массива по случайному индексу
          SpawnPlace = new Vector3(Random.Range(-218, 218), 1, Random.Range(-288, 288));
          Instantiate(selectedZombie, SpawnPlace, Quaternion.identity);
          spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
          yield return new WaitForSeconds(spawnTime);
        }
        else
        {
          yield return new WaitForSeconds(spawnTime);
        }
    }
  }
}
