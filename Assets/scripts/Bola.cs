using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public float VelocidadeDaBola;

    public float direcaoAleatoriaX;
    public float direcaoAleatoriaY;

    public Rigidbody2D oRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        MovimentoBola();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MovimentoBola()
    {
        oRigidBody2D.velocity = new Vector2(VelocidadeDaBola, VelocidadeDaBola);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        oRigidBody2D.velocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriaY);
    }
}
