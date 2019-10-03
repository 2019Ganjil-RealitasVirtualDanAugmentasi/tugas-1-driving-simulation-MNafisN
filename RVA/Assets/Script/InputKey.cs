using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour
{
    public float penggerak;
    public float stir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        penggerak = Input.GetAxis("Vertical");
        stir = Input.GetAxis("Horizontal");
    }
}
