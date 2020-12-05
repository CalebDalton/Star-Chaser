using System.Collections;
using UnityEngine;

public class StarCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {   
            AddScore();
            collision.gameObject.SetActive(false);
            StartCoroutine(Respawn(collision.gameObject));
        }
    }

    void AddScore()
    {
        ScoreTracker.totalScore += 2;
    }

    private IEnumerator Respawn(GameObject starObject)
    {
        yield return new WaitForSeconds(0);
        
        float randX = Random.Range(-6.7f, 6.6f);
        float randY = Random.Range(-3.91f, 3.9f);
        Debug.Log(randX + ", " + randY);
                
        transform.position = new Vector3(randX, randY, 0);
        starObject.SetActive(true);
    }
}
