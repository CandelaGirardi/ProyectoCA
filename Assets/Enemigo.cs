using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Personaje
{
    public override void Atacar(Collider2D collider)
    {
        Debug.Log("Enemigo atacando...");
    }

    public virtual void HabilidadEspecial()
    {
        Debug.Log("Enemigo usando habilidad especial");
    }
}