using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_2 : MonoBehaviour
{
    public GameObject EstadoSemaforo;
    public float Speed = 6f;
    public bool Controlador_2;

    // Start is called before the first frame update
    void Start()
    {
        Controlador_2 = false;
        EstadoSemaforo = GameObject.Find("Traffic Light 2");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo_2_y_4>().Semaforo_DosCuatro_Verde || Controlador_2)
        {
            transform.Translate(new Vector2(0, 6f) * Speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Collider_2")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Trigger_2")
        {
            Controlador_2 = true;
        }
    }
}
