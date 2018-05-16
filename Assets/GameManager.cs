using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    public int maxCircles; 
    [SerializeField]
    public int maxSquares;
    [SerializeField]
    public int maxTriangles;

    [SerializeField]
    public int playersTotal;

    private int lastCirclePosition;
    private int lastSquarePosition;
    private int lastTrianglesPosition;

    [SerializeField]
    private GameObject spheresX;
    [SerializeField]
    private GameObject spheresY;
    [SerializeField]
    private GameObject spheresZ;

    private Player player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.Total = playersTotal;
    }
   
	
	// Update is called once per frame
	void Update ()
     {
        Count();

        if (player.CircleCount > lastCirclePosition)
           UpdateShape(spheresX, "circle");
        if (player.SquareCount > lastSquarePosition)
            UpdateShape(spheresY, "square");
        if (player.TriangleCount > lastTrianglesPosition)
            UpdateShape(spheresZ, "triangles");


    }
    private void UpdateShape(GameObject shape,string Shape)
    {
       // Debug.Log("Total Shape:" + totalShapes.ToString());
        
         switch (Shape.ToLower())
            {
                case "circle":
                    Instantiate(shape, new Vector3(player.CircleCount, 0, 0), Quaternion.identity);
                    lastCirclePosition = player.CircleCount;
                    break;
                case "square":
                    Instantiate(shape, new Vector3(0, player.SquareCount, 0), Quaternion.identity);
                lastSquarePosition = player.SquareCount;
                    break;
                case "triangles":
                    Instantiate(shape, new Vector3(0, 0, player.TriangleCount), Quaternion.identity);
                lastTrianglesPosition = player.TriangleCount;
                    break;
                default:
                    break;
            }


        
    }

    private void Count()
    {
        if ((player.CircleCount + player.SquareCount + player.TriangleCount) > player.Total)
        {
            Debug.Log("Over the limit! Game Over!");
        }
            if (player.CircleCount > maxCircles)
        {
            MeshRenderer circleColor = spheresX.GetComponent<MeshRenderer>();
            circleColor.sharedMaterial.color = Color.black;
            Debug.Log("Too Many Circles!!");
        }
        if (player.SquareCount > maxSquares)
        {
            MeshRenderer circleColor = spheresY.GetComponent<MeshRenderer>();
            circleColor.sharedMaterial.color = Color.black;
            Debug.Log("Too Many Squares!!");
        }
        if (player.TriangleCount > maxTriangles)
        {
            MeshRenderer circleColor = spheresZ.GetComponent<MeshRenderer>();
            circleColor.sharedMaterial.color = Color.black;
            Debug.Log("Too Many Triangles!!");
        }
    }
    
}
