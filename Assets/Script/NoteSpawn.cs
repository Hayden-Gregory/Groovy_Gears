using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject quarterNote;
    private float x;
    public Vector2 velocity;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            GameObject quartNote = (GameObject)Instantiate(quarterNote, new Vector2(-2, 3), Quaternion.identity);
            quartNote.GetComponent<Rigidbody2D>().velocity = velocity;
        }
    }
}