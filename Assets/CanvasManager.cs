using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour {

    [SerializeField]
    private Text playerText;
    [SerializeField]
    private Text[] totals;
    private Player player;
    [SerializeField]
    private GameManager manager;
    
	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {

        totals[0].text ="Max Circles: "+  manager.maxCircles.ToString();
        totals[1].text = "Max Squares: " +manager.maxSquares.ToString();
        totals[2].text = "Max Triangles: " + manager.maxTriangles.ToString();

        playerText.text = "Circles: " + player.CircleCount.ToString() + " Squares:" + player.SquareCount.ToString() + " Triangles:" + player.TriangleCount.ToString();
    }
}
