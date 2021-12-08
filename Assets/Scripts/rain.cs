using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Rain", 0f, 20f);

        InvokeRepeating("StopRain", 10f, 20f);
    }

    void Rain()
    {
        gameObject.SetActive(true);
    }

    void StopRain()
    {
        gameObject.SetActive(false);
    }
}
