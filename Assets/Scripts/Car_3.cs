using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_3 : MonoBehaviour
{
    public GameObject EstadoSemaforo;
    public float Speed = 6f;
    public bool Controlador_3;

    // Start is called before the first frame update
    void Start()
    {
        Controlador_3 = false;
        EstadoSemaforo = GameObject.Find("Traffic Light 3");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo_1_y_3>().Semaforo_UnoTres_Verde || Controlador_3)
        {
            transform.Translate(new Vector2(0, 6f) * Speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collider_4")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Trigger_3")
        {
            Controlador_3 = true;
        }
    }
}
