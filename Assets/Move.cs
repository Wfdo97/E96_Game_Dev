using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime make the function dependend on the time rather than frames
        // transform.position += Time.deltaTime * new Vector3(10 * Mathf.Sin(Time.time), 0, 0);
        // transform.eulerAngles += Time.deltaTime * new Vector3(1, 0, 0);
    }
}
