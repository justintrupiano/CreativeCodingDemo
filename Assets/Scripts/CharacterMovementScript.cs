using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour
{
    string name = "Bran";

    public Vector3 velocity = new Vector3(0, 0, 0);

    [Range(0, 10)]
    public float speed;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
      rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.y < -10f)
        transform.position = new Vector3(10f, 2f, 0);

      if (Input.GetKey(KeyCode.W))
        velocity = new Vector3(speed, 0, 0);

      if (Input.GetKey(KeyCode.A))
        velocity = new Vector3(0, 0, speed);

      if (Input.GetKey(KeyCode.S))
        velocity = new Vector3(-speed, 0, 0);

      if (Input.GetKey(KeyCode.D))
        velocity = new Vector3(0, 0, -speed);

      rigidbody.AddForce(velocity);

      velocity = new Vector3(0, 0, 0);
    }
}
