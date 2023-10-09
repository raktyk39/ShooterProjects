using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousLook : MonoBehaviour
{


    
    // Start is called before the first frame update
    public Vector2 turn;

    public float sensitivity = 0.5f;

    public float horizontalMove;

    public float verticalMove;


    public float JumpSpeed = 2f;

     public float jump;

    public float speed = 4f;

    private  bool isGraund ;


    public GameObject player;
        
    private Animator PlayerAnimator;

    public Vector3 deltaMove;


    // Update is called once per frame

    void Start () {
        // Заприщвем курсору выходить за рамки окна игры
        
        
        PlayerAnimator = player.GetComponent<Animator>();
    }





    void Update()
    {

      

        //Получаем кардинаты мышки
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        // Ограничиваем повород по оси Y

          turn.y = Mathf.Clamp(turn.y,-20, 20);
          

        //Применяем поворот для камеры

       transform.localRotation = Quaternion.Euler(-turn.y,0,0);


       // Приминение поворота для игрока

        player.transform.localRotation = Quaternion.Euler(0,turn.x,0);


       // Приминение движение длдя игрока

       horizontalMove = Input.GetAxis("Horizontal");
       verticalMove = Input.GetAxis("Vertical");
       jump = Input.GetAxis("Jump") * JumpSpeed ;
       deltaMove = new Vector3 (horizontalMove * speed,  jump * JumpSpeed ,  verticalMove * speed) * Time.deltaTime;
       player.transform.Translate(deltaMove);
        
        
       PlayerController();
    }

    void PlayerController()
    {

        // Если что-то есть под игроком то isGraunt = true если не то  isGraunt = false
         isGraund = Physics.Raycast(player.transform.position, Vector3.down, 0.1f);

         if ( verticalMove > 0){
            PlayerAnimator.SetInteger("Move",1);
            speed = 2f;
    
  
                if ( Input.GetKey(KeyCode.LeftShift))
                {
                    PlayerAnimator.SetInteger("Move",2);
                    speed = 4f;
                }

                else{
                    PlayerAnimator.SetInteger("Move",1);
                    speed = 2f;
                }

                
         }
         else if (verticalMove < 0)
         {
             PlayerAnimator.SetInteger("Move",-1);
             speed = 2f;
         }


         else {
            PlayerAnimator.SetInteger("Move",0);
            
         }




         if ( horizontalMove > 0)
         {
            PlayerAnimator.SetInteger("Move",4);
            speed = 2f;
         }
         
         else if ( horizontalMove < 0)
         {
            PlayerAnimator.SetInteger("Move",3);
            speed = 2f;
         }



         if (isGraund && jump>0){
            

            deltaMove.y = JumpSpeed;
            isGraund = false;
            
            
         }

         else {
            jump = 0f;
         }

         

    }


   

}

