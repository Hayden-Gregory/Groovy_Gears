using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour {

    //Conductor
    public float bpm = 180;
    public float crotchet;
    public float songposition;
    public float offset = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      //  songposition = (float)(AudioSettings.dspTime – dsptimesong) *song.pitch – offset;
    }
}
