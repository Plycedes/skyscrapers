using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;  //creating a referance to this script

    public BoxSpawner box_Spawner;     //Giving the BoxSpawner.cs a variable to access its functions  


    [HideInInspector]
    public BoxScript currentBox;   //Giving BoxScr a variable          
        

    void Awake()
    {
        if (instance == null)       
            instance = this;        //Probably locating an instance for the box
    }

    void Start()
    {
        box_Spawner.SpawnBox();
        BoxScript.score = 0;
    }
        
    void Update()
    {
              //Calling the drop function  
    }

    public void DetectInput()          //Dropping the box on click
    {
        currentBox.DropBox();          
    }  
   
    
    public void SpawnNewBox()
    {
        Invoke("NewBox", 3f);
    }

    void NewBox()
    {
        box_Spawner.SpawnBox();        
    }   

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);    //Load the current/active scene
    }
}
