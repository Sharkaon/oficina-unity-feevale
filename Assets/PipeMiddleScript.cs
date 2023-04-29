using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicManagerScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = FindObjectOfType<LogicManagerScript>();
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag != "Player") return;

        logic.AddScore();
    }
}
