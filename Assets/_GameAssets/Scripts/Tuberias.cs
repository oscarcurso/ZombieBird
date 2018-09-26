using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour
{

    // Use this for initialization

    [SerializeField] int speed = 3;
    void Start()
    {
        float factorPosicion = Random.RandomRange(-1, 1);
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

            if (transform.position.x < -30)
            {
                Destroy(this.gameObject);
            }

        }


    }
}