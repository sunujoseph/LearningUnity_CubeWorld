using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public GameObject give a lot of information on player obj

    public Transform player; // responsible for positon, rotation and scale
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
