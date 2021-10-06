using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_4 : MonoBehaviour
{
    public GameObject EstadoSemaforo;
    public float Speed = 6f;
    public bool Controlador_4;

    // Start is called before the first frame update
    void Start()
    {
        Controlador_4 = false;
        EstadoSemaforo = GameObject.Find("Traffic Light 4");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo_2_y_4>().Semaforo_DosCuatro_Verde || Controlador_4)
        {
            transform.Translate(new Vector2(6f, 0) * Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Collider_1")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Trigger_4")
        {
            Controlador_4 = true;
        }
    }
}
