using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : Personaje
{
    private Rigidbody2D rb2d;
    public float velocidad = 5;
    public Transform puntodedisparo;
    public GameObject balaprefab;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        Caminar();
        Saltar();
        if (Input.GetKeyDown("space"))
        {
            HabilidadEspecial();

        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("enemigo"))
        {
            Atacar(collider);
        }
    }

    void Caminar()
    {
        var Movimiento_X = Input.GetAxisRaw("Horizontal");

        rb2d.velocity = new Vector2(Movimiento_X * velocidad, 0);
    }
    void Saltar() 
    {
        if (Input.GetKeyDown("w") )
        {
            rb2d.AddForce(Vector2.up * 10000);
            
        }
    }
public override void Atacar(Collider2D collider)
    {
        Debug.Log("Héroe atacando...");
        collider.gameObject.SetActive(false);
    }

    public virtual void HabilidadEspecial()
    {
        Debug.Log("Héroe usando habilidad especial");
        Instantiate(balaprefab, puntodedisparo.position,transform.rotation);
       
    }
}


