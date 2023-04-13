using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Enemy;
    [SerializeField] private Transform upPos , up2Pos , up3Pos , up4Pos , up5Pos , up6Pos, up7Pos, up8Pos, up9Pos, up10Pos, up11Pos, up12Pos;
    private GameObject enemySpawns;

    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerMonsters());
    }

    IEnumerator SpawnerMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, Enemy.Length);
            randomSide = Random.Range(0, 12);
            enemySpawns = Instantiate(Enemy[randomIndex]);


            
            if (randomSide == 0)
            {
                
                enemySpawns.transform.position = upPos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);
            }
            else if (randomSide == 1)
            {
                enemySpawns.transform.position = up2Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);
                
            }
            else if (randomSide == 2)
            {
                enemySpawns.transform.position = up3Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 3)
            {
                enemySpawns.transform.position = up4Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 4)
            {
                enemySpawns.transform.position = up5Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 5)
            {
                enemySpawns.transform.position = up6Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 6)
            {
                enemySpawns.transform.position = up6Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 7)
            {
                enemySpawns.transform.position = up6Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 8)
            {
                enemySpawns.transform.position = up6Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 9)
            {
                enemySpawns.transform.position = up6Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 10)
            {
                enemySpawns.transform.position = up6Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }
            else if (randomSide == 11)
            {
                enemySpawns.transform.position = up6Pos.position;
                enemySpawns.GetComponent<Enemy>().speed = Random.Range(4, 10);

            }

        }

    }
}
