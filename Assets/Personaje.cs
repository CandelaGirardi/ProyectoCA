using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Personaje:MonoBehaviour
{
    public string Nombre;

    public abstract void Atacar(Collider2D collider);
}









