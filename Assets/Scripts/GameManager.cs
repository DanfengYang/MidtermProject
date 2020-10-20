using UnityEngine;
using UnityEngine.SceneManagement;

//Game Restart

public class GameManager : MonoBehaviour
{
    //public float restartDelay = 1f;
    bool gameHasEnded = false;
    public void EndGame()
    {
        
        Debug.Log("endgame");
      
        Restart();
      
    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Global.health = 10;
    }
}
