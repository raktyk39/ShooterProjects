using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnZombes : MonoBehaviour
{
    // Start is called before the first frame update
    public Waves _waves;

    public GameObject YakuZombee;

    public GameObject YakuBigZombe;

    public GameObject [] YakuZombes ;

    public float spawnTime;

    private float  minSpawnTime = 0f;

    private float  maxSpawnTime = 1f;

    public Vector3 SpawnPlace;

   public int randomIndex;

   public  GameObject selectedZombie;


    void Start()
    {
      // Сделали путь к обьекту , перезаписываем как игровой обьект
        _waves = FindObjectOfType<Waves>();
      YakuZombee = Resources.Load("Prefabs/YakuZombee") as GameObject;
      YakuBigZombe = Resources.Load("Prefabs/BigYakuZombee") as GameObject;

     YakuZombes = new GameObject[2];
     YakuZombes[0] = Resources.Load<GameObject>("Prefabs/YakuZombee");
     YakuZombes[1] = Resources.Load<GameObject>("Prefabs/BigYakuZombee");

     StartCoroutine("WaitTimeForSpawn");

    
    }





    IEnumerator WaitTimeForSpawn() {

  while (true)
  { 

    if(_waves.ZombieCount.Length < _waves.maxZombiesOnWave) {

      randomIndex = Random.Range(0, YakuZombes.Length ); // Генерируем случайный индекс
    selectedZombie = YakuZombes[randomIndex]; // Выбираем объект из массива по случайному индексу
 
SpawnPlace = new Vector3(Random.Range(-218, 218), 1, Random.Range(-288, 288));
 Instantiate(selectedZombie, SpawnPlace, Quaternion.identity);
       spawnTime = Random.Range(minSpawnTime,maxSpawnTime);
       yield return new WaitForSeconds(spawnTime);

    } 
    
    
    else {
           yield return new WaitForSeconds(spawnTime);
    }
     
  }
  
 }


   
}
