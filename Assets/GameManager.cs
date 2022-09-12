using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //public references
    public Rotate rotate;
    public SpawnPoint spawner;
    public Animator animator;

    private bool gameEnded = false;

    public void endGame() {

      if(gameEnded){
        return;
      }

      //stopping the game when we die
      rotate.enabled = false;
      spawner.enabled = false;

      animator.SetTrigger("EndGame"); //activating the animation for when we die

      gameEnded = true;
      Debug.Log("Game Ended");
    }

    //restarting the game if we lose
    public void restartLvL() {

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
