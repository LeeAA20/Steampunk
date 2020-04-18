using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject piece1;
    public float rotateSpeed = 10f;
    public float rotx, roty, rotz;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotx, roty, rotz);

    }
}
