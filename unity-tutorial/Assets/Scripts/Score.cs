using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public Transform Player;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
