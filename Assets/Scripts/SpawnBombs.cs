﻿ using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{

    public GameObject bomb;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while(!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2f, 2f), 6.5f), Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
    }
}
