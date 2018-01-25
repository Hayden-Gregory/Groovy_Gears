using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject quarterNote;
    private float x;
    public Vector2 velocity;
    public GameObject spawnLine;
    public float divisor;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            GameObject quartNote = (GameObject)Instantiate(quarterNote, new Vector2(spawnLine.transform.position.x, spawnLine.transform.position.y + (spawnLine.GetComponent<SpriteRenderer>().bounds.size.y/divisor)), Quaternion.identity);
            quartNote.GetComponent<Rigidbody2D>().velocity = velocity;
        }
    }
}