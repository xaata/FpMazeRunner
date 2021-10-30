using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] enemies;

    [SerializeField]
    private MazeRenderer mazeRenderer;

    [SerializeField]
    private int enemyCount;
    protected float xScale;
    protected float zScale;
    protected int mazeHeight;
    protected int mazeWidth;
    void Start()
    {
        mazeHeight = mazeRenderer.GetComponent<MazeRenderer>().mazeHeight;
        mazeWidth = mazeRenderer.GetComponent<MazeRenderer>().mazeWidth;
        xScale = mazeRenderer.GetComponent<MazeScaler>().xScale;
        zScale = mazeRenderer.GetComponent<MazeScaler>().zScale;

        for (int i = 0; i < enemyCount; i++)
        {
            var enemyType1 = Instantiate(enemies[0], transform); //Random.Range(0, enemies.Length)
            enemyType1.localPosition = new Vector3(Random.Range((-mazeWidth / 2 - 0.5f) * xScale, (mazeWidth / 2 - 0.5f) * xScale), 0.1f, Random.Range((-mazeHeight / 2 - 0.5f) * zScale, (mazeHeight / 2 - 0.5f) * zScale));
        }
    }
}
