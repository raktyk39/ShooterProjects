using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigYakuZombee : MonoBehaviour
{
    private GameObject Player;

    public float ZombeSpeed = 0.2f;

    private Animator ZombeAnimator;

    private GameObject ammo;

    public int ZombiHealth = 300;

    public List<Rigidbody> GetRigidbodies = new List<Rigidbody>();

    private AnimatorStateInfo ZombiStateInfo;


    void Start()
    {

        ammo = Resources.Load("Prefabs/AmmoP90") as GameObject;

       Player = GameObject.FindGameObjectWithTag("Player");
       
          ZombeAnimator = gameObject.GetComponent<Animator>();

         ZombiHealth = 300;
         ZombeSpeed = 0.2f;

         RigidbodyisKinimaticOn();
         gameObject.GetComponent<CapsuleCollider>().enabled = true;
           
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

        other.gameObject.GetComponent<PlayerHealth>().TakePlayerDamage(30);
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
         ZombeSpeed = 0.2f;
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






}
 }
   }
