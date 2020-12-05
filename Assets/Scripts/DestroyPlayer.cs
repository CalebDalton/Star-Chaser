using System.Collections;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BottomWall")
        {
            collision.gameObject.SetActive(false);
            SubtractScore();
            StartCoroutine(Respawn(collision.gameObject));
        }
    }

    void SubtractScore()
    {
        ScoreTracker.totalScore--;
    }

    IEnumerator Respawn(GameObject gameObject)
    {
        yield return new WaitForSeconds(0.2f);
        transform.position = new Vector3(-6, 2, 0);
        gameObject.SetActive(true);
    }

}
