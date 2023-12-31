using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
  public Camera cam;
  public float range = 50f ;
  public float MarkDamage = 10f;
  public int BagAmmo = 0;
  public ParticleSystem ShootEffect;
  private int Zombedamage = 50;
  public ParticleSystem HitEffect;
  public AudioSource ShootAudio;
  public float reloatTime = 5f;   // Перемены для очереди стрельбы
  private bool isRoading = false;
  public int currentAmmo;
  public int maxAmmo = 10; 
  public float ImpactForce = 300f;
  public float FireRate = 1f;
  public float NextTimeToFire = 0f;
  public MeshRenderer meshRenderer;

  private void Start ()
  {
    StartCoroutine(Reload());
    meshRenderer = GetComponent<MeshRenderer>();
    cam = Camera.main;
  }

  private void Update() 
  {
    if ( !meshRenderer.enabled)
    {
      return;
    } 
      if (isRoading)
      {
        return;
      }
        if( currentAmmo <= 0 )
        {
            StartCoroutine(Reload());
            return;
        }
          if (Input.GetMouseButtonDown(0) && Time.time >= NextTimeToFire)
          {
            Shoot();
        
            NextTimeToFire = Time.time + 1f/FireRate;  // наша нынешняя время + 1 секунда
          }
  }

  private IEnumerator Reload ()
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
        
  private void Shoot ()
  {
        currentAmmo --;
        Debug.Log("Мы стреляем") ;
        ShootEffect.Play();
        ShootAudio.Play();
              
        RaycastHit hit;  // RaycastHit переменая которая сохраняет название обьектов которые столкнулись с нашем лучом
                    
      if (Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range))
      {
          Debug.Log(hit.collider.gameObject.name);   // Вызываем 

          Target target  = hit.transform.GetComponent<Target>();
          ZombeMove zombeMove = hit.transform.GetComponent<ZombeMove>();
          BigYakuZombee bigzombee = hit.transform.GetComponent<BigYakuZombee>();
          ZombeMoveSpeed zombeMoveSpeed = hit.transform.GetComponent<ZombeMoveSpeed>();

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
                  if ( bigzombee != null)
                  {
                    bigzombee.TakeDamage(Zombedamage);
                  }
                  if ( zombeMoveSpeed != null) 
                  {
                     zombeMoveSpeed.TakeDamage(Zombedamage);
                  }
                ParticleSystem CreatHit = Instantiate(HitEffect,hit.point,Quaternion.LookRotation(hit.normal));
                Destroy (CreatHit.gameObject,1f);
      }
  }
}
