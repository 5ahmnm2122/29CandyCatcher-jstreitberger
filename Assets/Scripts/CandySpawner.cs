using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] candy;

    private BoxCollider2D col;

    float x1, x2;

    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnCandy(1f));
    }

    IEnumerator SpawnCandy(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);

        Instantiate(candy[Random.Range(0, candy.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnCandy(Random.Range(1f, 2f)));

    }
}
