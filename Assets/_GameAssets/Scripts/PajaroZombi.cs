using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PajaroZombi : MonoBehaviour {
    
    [SerializeField] Text marcadorPuntos;
    [SerializeField] float fuerza = 8f;
    [SerializeField] ParticleSystem explosion;

    private int puntos = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ActualizarMarcador();
    }

    private void ActualizarMarcador()
    {
        marcadorPuntos.text = "Score: "+puntos.ToString();// No haria falte el ToString ya que al juntar una cadena de texto con el + ya lo converte en texto //
    }

    void Update() {

        if (Input.GetKeyDown("space"))
        {
           
            rb.AddForce(transform.up * fuerza);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        puntos++;
        ActualizarMarcador();
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        Instantiate(explosion, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
        Invoke("FinalizarPartida", 3.5f);
        
    }

    private void FinalizarPartida()
    {
        
        
        SceneManager.LoadScene(0);
    }

    
}
