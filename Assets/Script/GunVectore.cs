using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunVectore : MonoBehaviour
{
    // Start is called before the first frame update
      public Camera cam;

    public float range = 50f ;

    public float MarkDamage = 10f;

    public int BagAmmo = 0;

    public ParticleSystem ShootEffect;

    public int Zombedamage = 50;
     
    public ParticleSystem HitEffect;

    public AudioSource ShootAudio;

  // Перемены для очереди стрельбы
    public float reloatTime = 5f;

    private bool isRoading = false;

    public int currentAmmo;

    public int maxAmmo = 10; 


    public float ImpactForce = 300f;

    public float FireRate = 1f;

     public float NextTimeToFire = 0f;


      void Start ()
      {
        StartCoroutine(Reload());
      }



    void Update() {

      
      if (isRoading)
      {
        return;
      }


     if( currentAmmo <= 0 )
     {
        StartCoroutine(Reload());
        return;
     }

       // print (Time.time);
      if (Input.GetMouseButtonDown(0) && Time.time >= NextTimeToFire)
       {
         
         Shoot();
      // наша нынешняя время + 1 секунда
      NextTimeToFire = Time.time + 0.2f/FireRate; 

       }

         }


 IEnumerator Reload ()
     {

           
      if ( BagAmmo > 0)
      {
        isRoading = true;

      Debug.Log("Reloading...");
       yield return new WaitForSeconds(reloatTime);
       currentAmmo = maxAmmo;
       BagAmmo = BagAmmo - maxAmmo;

       isRoading = false;
     }

      
     }
        


        

        void Shoot ()
        {

             currentAmmo --;

          ShootEffect.Play();
          ShootAudio.Play();
          
             // RaycastHit переменая которая сохраняет название обьектов которые столкнулись с нашем лучом
              RaycastHit hit;
            
                          
            if (Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range))
            {
                // Вызываем 
              Debug.Log(hit.collider.gameObject.name);


               Target target  = hit.transform.GetComponent<Target>();
               ZombeMove zombeMove = hit.transform.GetComponent<ZombeMove>();
              if( target !=null)
              {
                target.TakeDamage(MarkDamage);
              }     
                 if (hit.rigidbody != null)
                 {
                  hit.rigidbody.AddForce(-hit.normal * ImpactForce);
                 }

                  if ( zombeMove != null)
                  {
                    zombeMove.TakeDamage(Zombedamage);
                  }
                ParticleSystem CreatHit = Instantiate(HitEffect,hit.point,Quaternion.LookRotation(hit.normal));
                Destroy (CreatHit.gameObject,1f);
            }
            
           
            

        }
}
