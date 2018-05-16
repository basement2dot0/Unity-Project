using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour {

    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private int size;
    [SerializeField]
    private float scale;
    private Player player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        for (int x = 0; x < player.Total; x++)
        {
            for (int y = 0; y < player.Total; y++)
            {
                for (int z = 0; z < player.Total; z++)
                {
                    var c = Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
                    c.transform.parent = transform;
                }
            }
        }

        foreach (Transform child in transform)
        {
            var height = Mathf.PerlinNoise(child.transform.position.x / scale, child.transform.position.y / scale);
        }
    }

    private void Update()
    {
        foreach (Transform child in transform)
        {
            var height = Mathf.PerlinNoise(child.transform.position.x / scale, child.transform.position.y / scale);
        }
    }
}
