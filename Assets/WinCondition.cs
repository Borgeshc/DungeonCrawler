using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public string enemyTag;
    public string playerName;

    public Text text;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == enemyTag)
        {
            text.enabled = true;
            text.text = playerName + " Wins!";
        }
    }
}
