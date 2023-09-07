using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombeeBig : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject YakuZombee;

    public float spawnTime;

    




    void Start()
    {
      // Сделали путь к обьекту , перезаписываем как игровой обьект
      YakuZombee = Resources.Load("Prefabs/BigYakuZombee") as GameObject;
       StartCoroutine("WaitTimeForSpawn");
    }

    IEnumerator WaitTimeForSpawn() {

  while (true)
  { 
      spawnTime = 25f;
    yield return new WaitForSeconds(spawnTime);
    Instantiate(YakuZombee.gameObject, gameObject.transform.position,Quaternion.identity);
  }
  
 }

   
}
