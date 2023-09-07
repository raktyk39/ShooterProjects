using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnBigZombie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject YakuZombee;

    public float spawnTime;

    public Vector3 SpawnPlace;    

    




    void Start()
    {
      // Сделали путь к обьекту , перезаписываем как игровой обьект
      YakuZombee = Resources.Load("Prefabs/BigYakuZombee") as GameObject;
       StartCoroutine("WaitTimeForSpawn");
    }

    IEnumerator WaitTimeForSpawn() {

  while (true)
  { 
      SpawnPlace = new Vector3(Random.Range(-218,218),1, Random.Range(-288,288) );
      
    yield return new WaitForSeconds(spawnTime);
    Instantiate(YakuZombee.gameObject, gameObject.transform.position,Quaternion.identity);
  }
  
 }

   
}
