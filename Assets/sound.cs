using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {
	public AudioSource[] musicsound; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("w"))
		{
            musicsound[0].Play();
		}
		if(Input.GetKeyDown("a"))
		{
            musicsound[1].Play();
		}
		if(Input.GetKeyDown("s"))
		{
            musicsound[2].Play();
		}
		if(Input.GetKeyDown("d"))
		{
            musicsound[3].Play();
		}
        if (Input.GetKeyDown("space"))
        {
            musicsound[5].Play();
		}
        if (Input.GetMouseButtonDown(0))
        {
            musicsound[4].Play();
		}
			
	}
}
