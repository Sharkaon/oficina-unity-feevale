using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    private float spawnRate = 2;
    private float heightOffset = 5;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        this.timer += Time.deltaTime;
        if (this.timer > spawnRate) {
            this.timer = 0;
            this.SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        float lowest = transform.position.y - this.heightOffset;
        float highest = transform.position.y + this.heightOffset;
        Vector3 pos = new Vector3(transform.position.x, Random.Range(lowest, highest), 0f);
        Instantiate(pipe, pos, transform.rotation);
    }
}
