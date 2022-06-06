using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    private float scoreminus;
    public Transform player;
    public TextMeshProUGUI scoretext;
    void Update()
    {
        scoreminus = -(player.position.x - 470);
        scoretext.text = scoreminus.ToString("0");
    }
}
