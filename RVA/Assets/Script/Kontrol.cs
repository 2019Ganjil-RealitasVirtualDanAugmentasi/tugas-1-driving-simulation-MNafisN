using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputKey))]
public class Kontrol : MonoBehaviour
{
    public InputKey masukkan;
    public List<WheelCollider> rodaPenggerak;
    public List<GameObject> rodaStir;
    public List<GameObject> rodaPutar;
    public Rigidbody rb;
    public int torsi=0;

    // Start is called before the first frame update
    void Start()
    {
        masukkan = GetComponent<InputKey>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(WheelCollider roda in rodaPenggerak)
        {
            roda.motorTorque = torsi * Time.deltaTime * masukkan.penggerak; 
        }

        foreach(GameObject roda in rodaStir)
        {
            roda.GetComponent<WheelCollider>().steerAngle = 30f * masukkan.stir;
            roda.transform.localEulerAngles = new Vector3(0f, masukkan.stir * 30f, 0f);
        }

        foreach (GameObject putar in rodaPutar)
        {
            putar.transform.Rotate(rb.velocity.magnitude * (transform.InverseTransformDirection(rb.velocity).z>=0 ? 1 : -1) / (0.5f * Mathf.PI * 0.33f), 0f, 0f);
        }
    }
}
