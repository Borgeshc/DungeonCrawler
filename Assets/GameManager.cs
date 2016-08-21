using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public string[] playerOneTags;
    public GameObject[] playerOneUnits;
    public GameObject[] playerOneStuctures;
    public GameObject[] playerOneBases;

    public string[] playerTwoTags;
    public GameObject[] playerTwoUnits;
    public GameObject[] playerTwoStuctures;
    public GameObject[] playerTwoBases;


    void Start ()
    {
        playerOneBases = GameObject.FindGameObjectsWithTag("PlayerOneBase");
        playerTwoBases = GameObject.FindGameObjectsWithTag("PlayerTwoBase");
    }

	void Update ()
    {
        playerOneUnits = GameObject.FindGameObjectsWithTag("PlayerOneUnit");
        playerOneStuctures = GameObject.FindGameObjectsWithTag("PlayerOneStructure");

        playerTwoUnits = GameObject.FindGameObjectsWithTag("PlayerTwoUnit");
        playerTwoStuctures = GameObject.FindGameObjectsWithTag("PlayerTwoStructure");
    }
}
