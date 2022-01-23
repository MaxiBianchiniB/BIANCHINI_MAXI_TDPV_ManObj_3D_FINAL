using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRay : MonoBehaviour
{
    public GameObject Rayo;

    float Cronometro;

    // Start is called before the first frame update
    void Start()
    {
        Cronometro = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Cronometro += Time.deltaTime;

        if (Cronometro >= 3) CrearNuevoRayo();
    }

    void CrearNuevoRayo()
    {
        GameObject G = Instantiate(Rayo);
        G.transform.position = this.transform.position;
        G.transform.rotation = this.transform.rotation;

        Cronometro = 0;
    }
}