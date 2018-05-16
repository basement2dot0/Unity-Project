using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField]
    private GameObject[] shapes;
    private float spawnDelay;
    WaitForSeconds wait = new WaitForSeconds(5.0f);
    Vector3 position = Vector3.zero;
    private int shapeIndex;
    private float lastSpawnTime;
    // Use this for initialization
    void Start () {
        // spawnDelay = Random.Range(0, 3);
        spawnDelay = 0;
    }
	
	// Update is called once per frame
	void Update () {
        shapeIndex = Random.Range(0, shapes.Length);

        if (shapeIndex == 0)
            position = new Vector3(0, 20, -5);
        if (shapeIndex == 1)
            position = new Vector3(-5, 20, -5);
        if (shapeIndex == 2)
            position = new Vector3(5, 20, -5);
        if ((Time.time - lastSpawnTime) > spawnDelay)
        {
            Instantiate(shapes[shapeIndex], position, Quaternion.identity);
            lastSpawnTime = Time.time;
        }


    }

    private IEnumerator DelaySpawner()
    {
       yield return wait;
        Instantiate(shapes[shapeIndex], position, Quaternion.identity);
        lastSpawnTime = Time.time;





    }
}
