using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour
{

    // Use this for initialization

    [SerializeField] int speed = 3;
    [SerializeField] float limiteInfTuberia = -1;
    [SerializeField] float limiteSupTuberia = 1;
    [SerializeField] float limiteDistanciaDestruccion = -20;

    void Start()
    {
        float factorPosicion = Random.Range(limiteInfTuberia, limiteSupTuberia);
        transform.position = new Vector3
            (transform.position.x,
            transform.position.y + factorPosicion,
            transform.position.z);


    }

    // Update is called once per frame
    void Update()
    {

        if (GameConfig.IsPlaying())
        {


            transform.Translate(Vector3.left * Time.deltaTime * speed);

            if (transform.position.x < limiteDistanciaDestruccion)
            {
                Destroy(this.gameObject);
            }

        }


    }
}