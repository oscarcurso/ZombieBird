﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {
    [SerializeField] Transform Tuberia;
    [SerializeField] float ratioTuberia = 2f;

    // Use this for initialization
    void Start () {
        InvokeRepeating("GeneratePipe", 0, ratioTuberia);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void GeneratePipe()
    {
        if (GameConfig.IsPlaying())
        {

            Instantiate(Tuberia, transform.position, Quaternion.identity);
        }
    }

   



}
