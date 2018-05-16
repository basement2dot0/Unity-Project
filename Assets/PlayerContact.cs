using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContact : MonoBehaviour
{

    private void Update()
    {
        if(this.transform.position.y <= -5)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Player player = collision.gameObject.GetComponent<Player>();
            switch (this.tag.ToLower())
            {
                case "circle":
                    player.CircleCount++;
                    break;
                case "square":
                    player.SquareCount++;
                    break;
                case "triangle":
                    player.TriangleCount++;
                    break;
                default:
                    break;
            }
            GameObject.Destroy(this.gameObject);
        }
        
    }
}
