using UnityEngine;

public class Block : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject block;
    private float timeToSpawn = 2f;
    private float spawnWindow = 2f;

    private void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i != randomIndex)
            {
                Instantiate(block, spawnPoints[i].position, Quaternion.identity);
            }

        }
    }

    void Update()
    {
        /*
         *
        * if((int)Time.time%timeToSpawn == 0)
        * {
        *     SpawnBlocks();
        * }
        * 
        */
        if(Time.timeSinceLevelLoad >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn += spawnWindow;
        }
    }
    
}
