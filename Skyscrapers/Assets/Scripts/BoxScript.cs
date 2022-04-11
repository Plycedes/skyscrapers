using UnityEngine;

public class BoxScript : MonoBehaviour
{
    private float min_X = -2.2f, max_X = 2.2f;  //create boundaries for the box

    private bool canMove;   
    private float move_Speed = 2f;
    public static int score;

    private Rigidbody2D myBody; //Rigidbody component for the box

    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;
    private bool isDone = false;
    

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();   //call the rigidbodycomponent when the scene is loaded
        myBody.gravityScale = 0f;        
    }

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        
        if(Random.Range(0, 2) > 0)  //check if box is under the range then move the box initially
        {
            move_Speed *= -1f;
        }

        GameplayController.instance.currentBox = this;  //using GameplayCont scr ref to connect with this box  
    }

    // Update is called once per frame
    void Update()
    {
        MoveBox();  //movebox as the gameplay progresses
    }

    void MoveBox()
    {
        if (canMove)
        {
            Vector3 temp = transform.position;

            temp.x += move_Speed * Time.deltaTime;

            if(temp.x > max_X)  //if box reaches max limit flip the direction of movement
            {
                move_Speed *= -1f;
            }
            else if (temp.x < min_X)    //if box reaches max limit flip the direction of movement
            {
                move_Speed *= -1f;
            }
            transform.position = temp;
        }
    }

    public void DropBox()
    {
        canMove = false;        
        myBody.gravityScale = Random.Range(2, 4);   //box stops moving horizontally and drops
    }

    void Landed()
    {
        if (gameOver)
            return;      

        ignoreCollision = true;
        ignoreTrigger = true; 
        
        
        GameplayController.instance.SpawnNewBox();  //spawn new box        
    }

    void RestartGame()
    {
        GameplayController.instance.RestartGame();
        score = 0;
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (ignoreCollision)
            return;

        if(target.gameObject.tag == "Platform") //spawn box if the previous landed on platform
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;

            FindObjectOfType<AudioManager>().Play("hit");

            if (isDone == false)
            {
                score++;
                isDone = true;
            }
        }

        if (target.gameObject.tag == "Block")   //spawn box if the previous landed on block
        {
            Invoke("Landed", 2f);
            ignoreCollision = true;
            score++;

            FindObjectOfType<AudioManager>().Play("hit");
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {        
        if (ignoreTrigger)
            return;
                
        if (target.tag == "GameOver")    //restart game if the earlier fell down the platform
        {
            CancelInvoke("Landed");
            gameOver = true;
            ignoreTrigger = true;

            FindObjectOfType<AudioManager>().Play("gameOver");

            Invoke("RestartGame", 0.1f);
        }        
    }    
}
