using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_script : MonoBehaviour
{
    // Start is called before the first frame update
    void awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
