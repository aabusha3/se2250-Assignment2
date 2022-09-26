using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefabs = new GameObject[2];//contains the enemy prefabs

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RepeatSpawn());
    }

    // Repeats the spawn of the enemy every 2 or 3 seconds
    IEnumerator RepeatSpawn()
    {
        yield return new WaitForSeconds(0.6f);
        while (true)
        {
            SpawnEnemy(Random.Range(0, 2));
            yield return new WaitForSeconds(Random.Range(2, 4));
        }
    }

    //Spawns Either Enemy of type 1 or 2
    void SpawnEnemy(int type)
    {
        GameObject enemy = Instantiate(enemyPrefabs[type]);//instantiates prefabs

        //sets enemy location in a random x-pos at the top of the screen
        enemy.transform.position = new Vector2(Random.Range(-FinalFields.CAMERA_WIDTH + FinalFields.RADIUS, FinalFields.CAMERA_WIDTH - FinalFields.RADIUS), 
                                               FinalFields.CAMERA_HEIGHT);

        enemy.name = enemyPrefabs[type].name;//names enemies the same name as the prefab
    }
}
