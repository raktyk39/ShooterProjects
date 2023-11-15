
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveOfGame : MonoBehaviour
{
  public GameObject Smg ;

  public GameObject P90 ;

  public GameObject Gun ;

  public int bagAmmoGun;

  public int curentAmmoGun;

  public int bagAmmoP90;
  
  public int curentAmmoP90;

  public int bagAmmoSmg;

  public int curentAmmoSmg;

  public GameObject slaiderOfValiune;

  public GameObject Player;

  public float playerHP;

  public float waves;

  public float x,y,z;

  public float killOnZombis;

  public float valuiu ;  

  void Start()
  {
    if ( SceneManager.GetActiveScene().name  == "Parking" && PlayerPrefs.GetInt("beSave") == 1 ) 
    {
      getValuium();
    }
  }

  [ContextMenu("Save")]
  public void saveVoluiums ()
  {
    curentAmmoSmg = Smg.GetComponent<GunVectore>().currentAmmo;
    PlayerPrefs.SetInt("CurentAmmoVectore",curentAmmoSmg);

    bagAmmoSmg = Smg.GetComponent<GunVectore>().BagAmmo;
    PlayerPrefs.SetInt("BagAmmoVector",bagAmmoSmg);

    curentAmmoGun = Gun.GetComponent<Gun>().currentAmmo;
    PlayerPrefs.SetInt("CurentAmmoGun",curentAmmoGun);

    bagAmmoGun = Gun.GetComponent<Gun>().BagAmmo;
    PlayerPrefs.SetInt("BagAmmoGun",bagAmmoGun);

    curentAmmoP90 = P90.GetComponent<GunP90>().currentAmmo;
    PlayerPrefs.SetInt("CurentAmmoP90", curentAmmoP90);

    bagAmmoP90 = P90.GetComponent<GunP90>().BagAmmo;
    PlayerPrefs.SetInt("BagAmmoP90",bagAmmoP90);

    playerHP = Player.GetComponent<PlayerHealth>().playerHealth;
    PlayerPrefs.SetFloat("PlayerHP",(float)playerHP);

    killOnZombis = Player.GetComponent<Waves>().ZombieKillOnWave;
    PlayerPrefs.SetFloat("KillZombes",(float)killOnZombis);

    waves = Player.GetComponent<Waves>().WavesCaunt;
    PlayerPrefs.SetFloat("Waves",(float)waves);

    x = Player.transform.position.x;
    y = Player.transform.position.y;
    z = Player.transform.position.z;

    PlayerPrefs.SetFloat("PositionPlayer-x",x);
    PlayerPrefs.SetFloat("PositionPlayer-y",y);
    PlayerPrefs.SetFloat("PositionPlayer-z",z);
    valuiu = slaiderOfValiune.GetComponent<Slider>().value;

    PlayerPrefs.SetFloat("ValueAudio",valuiu);
    PlayerPrefs.SetInt("beSave", 1);
  }

  [ContextMenu("Get")]
  public void getValuium () 
  {
    Gun.GetComponent<Gun>().currentAmmo = PlayerPrefs.GetInt("CurentAmmoGun");
    Gun.GetComponent<Gun>().BagAmmo = PlayerPrefs.GetInt("BagAmmoGun");

    P90.GetComponent<GunP90>().currentAmmo = PlayerPrefs.GetInt("CurentAmmoP90");
    P90.GetComponent<GunP90>().BagAmmo = PlayerPrefs.GetInt("BagAmmoP90");

    Smg.GetComponent<GunVectore>().currentAmmo = PlayerPrefs.GetInt("CurentAmmoVectore");
    Smg.GetComponent<GunVectore>().BagAmmo = PlayerPrefs.GetInt("BagAmmoVector");

    Player.GetComponent<PlayerHealth>().playerHealth = (int)PlayerPrefs.GetFloat("PlayerHP");

    Player.GetComponent<Waves> ().ZombieKillOnWave = (int)PlayerPrefs.GetFloat("KillZombes");
    Player.GetComponent<Waves> ().WavesCaunt = (int)PlayerPrefs.GetFloat("Waves");
    
    Player.transform.position = new Vector3 (PlayerPrefs.GetFloat("PositionPlayer-x"),PlayerPrefs.GetFloat("PositionPlayer-y"),PlayerPrefs.GetFloat("PositionPlayer-z"));
    slaiderOfValiune.GetComponent<Slider>().value =  PlayerPrefs.GetFloat("ValueAudio") ; 
    Time.timeScale = 1;
  }

  [ContextMenu("Reset")]
  public void Reset () 
  {
    PlayerPrefs.SetInt("beSave", 0);
  }
}

