using UnityEngine;
using UnityEngine.SceneManagement;
// Create by <NDC>
using Tags;
using ScreenGame;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TagConst.PLAYER_TAG))
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            SceneManager.LoadScene(ScreenConst.GAME_OVER);
        }
    }
}
