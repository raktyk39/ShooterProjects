using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombeMove : MonoBehaviour
{
    
    public Waves _waves;
    private GameObject Player;

    public float ZombeSpeed = 0.5f;

    private Animator ZombeAnimator;

    public int DamageforPlayer = 10;

    private GameObject ammo;

    public int ZombiHealth = 100;

    public List<Rigidbody> GetRigidbodies = new List<Rigidbody>();

    private AnimatorStateInfo ZombiStateInfo;


    void Start()
    {
         _waves = FindObjectOfType<Waves>();

        ammo = Resources.Load("Prefabs/AmmoPistol") as GameObject;

       Player = GameObject.FindGameObjectWithTag("Player");
       
          ZombeAnimator = gameObject.GetComponent<Animator>();
         ZombeSpeed = 0.5f;

         RigidbodyisKinimaticOn();
         gameObject.GetComponent<CapsuleCollider>().enabled = true;

         DamageforPlayer = DamageforPlayer + _waves.DamageforPlayerAdding;

         ZombiHealth = ZombiHealth + _waves.ZombiHealthAdding;
           
    }

    // Update is called once per frame
    void Update()
    {
      
        ZombeController();

    }




     void OnCollisionEnter(Collision other) {
            
      if ( other.gameObject.tag == "Player")
      {
        ZombeAnimator.SetBool("Atack", true);

        other.gameObject.GetComponent<PlayerHealth>().TakePlayerDamage(DamageforPlayer);
      }

   }


   void OnCollisionExit(Collision other) {
            
      if ( other.gameObject.tag == "Player")
      {
        ZombeAnimator.SetBool("Atack", false);
      }

   }





void RigidbodyisKinimaticOn ()
{
   ZombeAnimator.enabled = true;

for ( int countHips =0; countHips < GetRigidbodies.Count; countHips++)
{

GetRigidbodies [countHips].isKinematic = true;

}

 


}



void RigidbodyisKinimaticOff ()

{

   ZombeAnimator.enabled = false;


for ( int countHips =0; countHips < GetRigidbodies.Count; countHips++)
{

GetRigidbodies [countHips].isKinematic = false;

}

 


}






void ZombeController ()
{
    ZombiStateInfo = ZombeAnimator.GetCurrentAnimatorStateInfo(0);

   if ( ZombiHealth > 0)
   {
   
 
   

      if ( ZombiStateInfo.IsName("Zombie Attack") || ZombiStateInfo.IsName("Zombie Reaction Hit"))

      {

         ZombeSpeed = 0f;
      }
      else {
         ZombeSpeed = 0.5f;
             gameObject.transform.LookAt(Player.transform.position);
             gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,Player.transform.position, ZombeSpeed * Time.deltaTime);
      }
   }
 }



public void TakeDamage (int damage)
{

   ZombiHealth = ZombiHealth - damage;

   ZombeAnimator.SetTrigger("Hit");

   if ( ZombiHealth <= 0 )
{
 RigidbodyisKinimaticOff();
 gameObject.GetComponent<CapsuleCollider>().enabled = false;

 Instantiate(ammo.gameObject, gameObject.transform.position,Quaternion.identity);

_waves.ZombieKillOnWave++;




}
 }




}
