using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class Car_1 : MonoBehaviour
{
    public GameObject EstadoSemaforo;
    public float Speed = 6f;
    public bool Controlador_1;

    // Start is called before the first frame update
    void Start()
    {
        Controlador_1 = false;
        EstadoSemaforo = GameObject.Find("Traffic Light 1");
    }

    // Update is called once per frame
    void Update()
    {
        if (EstadoSemaforo.GetComponent<Semaforo_1_y_3>().Semaforo_UnoTres_Verde || Controlador_1)
        {
            transform.Translate(new Vector2(0, 6f) * Speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collider_3")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Trigger_1")
        {
            Controlador_1 = true;
        }
    }

}
