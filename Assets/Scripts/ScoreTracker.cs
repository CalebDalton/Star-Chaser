using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public TMP_Text textDisplay;
    public static int totalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<TMP_Text>().text = "00";
    }

    // Update is called once per frame
    void Update()
    {
        if (totalScore < 10 && totalScore >= 0)
            textDisplay.GetComponent<TMP_Text>().text = "0" + totalScore;
        else if (totalScore > -10 && totalScore < 0)
            textDisplay.GetComponent<TMP_Text>().text = "-0" + (totalScore * -1);
        else
            textDisplay.GetComponent<TMP_Text>().text = "" + totalScore;
    }
}