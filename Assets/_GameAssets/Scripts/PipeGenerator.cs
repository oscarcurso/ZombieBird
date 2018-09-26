using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {
    [SerializeField] Transform Tuberia;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GeneratePipe", 0, 2);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void GeneratePipe()
    {
        
        Instantiate(Tuberia, transform.position, Quaternion.identity);

        
        }

   



}
