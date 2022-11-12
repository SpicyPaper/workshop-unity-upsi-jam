using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    [SerializeField] private float speed = 80;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
        Debug.Log("UPDATE");
    }
}
