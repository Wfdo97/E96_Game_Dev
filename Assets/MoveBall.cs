using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        // rb.velocity = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime make the function dependend on the time rather than frames
        // transform.position += Time.deltaTime * new Vector3(10 * Mathf.Sin(Time.time), 0, 0);
        // transform.position += Time.deltaTime * new Vector3(1, 0, 0);
        // transform.eulerAngles += Time.deltaTime * new Vector3(1, 0, 0);

    }
}
