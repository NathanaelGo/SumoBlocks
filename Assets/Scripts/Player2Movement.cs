using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float MaxSpeed = 200f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("l"))
        {
            rb.AddForce(MaxSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("j"))
        {
            rb.AddForce(-MaxSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("i"))
        {
            rb.AddForce(0, 0, MaxSpeed * Time.deltaTime);
        }
        if (Input.GetKey("k"))
        {
            rb.AddForce(0, 0, -MaxSpeed * Time.deltaTime);
        }
    }
}