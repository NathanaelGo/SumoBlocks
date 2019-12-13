using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rbmain;
    public Rigidbody rbsec;

    public float MaxSpeed = 200f;
    public float MaxTorque = 1f;
    public string forward = "w";
    public string left = "a";
    public string right = "d";
    public string backward = "s";
    public string power1 = "e";
    public string power2 = "q";



    public int pow = 3;
    //private bool lastSec = false;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {

        if(Input.GetKey(right))
        {
            rbmain.AddForce(MaxSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(left))
        {
            rbmain.AddForce(-MaxSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(forward))
        {
            rbmain.AddForce(0, 0, MaxSpeed* Time.deltaTime);
        }
        if (Input.GetKey(backward))
        {
            rbmain.AddForce(0, 0, -MaxSpeed * Time.deltaTime);
        }

        //pow comands for changey
        if (Input.GetKeyDown(power1) && pow == 0)
        {
            rbmain.transform.localScale = new Vector3(2.0f, 1.0f, 2.0f);
            rbmain.mass = 2.5f;
            MaxSpeed = 180.0f;
            pow = 1;
        }
        if (Input.GetKeyDown(power2) && pow == 1)
        {
            rbmain.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
            rbmain.mass = 0.1f;
            MaxSpeed = 18.5f;
            pow = 0;
        }
        
        //pow comands for Lanky
        if (Input.GetKey(power1) && pow == 2)
        {
            rbmain.AddTorque(0, MaxTorque * Time.deltaTime, 0, ForceMode.Force);

        }
        if (Input.GetKey(power2) && pow == 2)
        {
            rbmain.AddTorque(0, -MaxTorque * Time.deltaTime, 0, ForceMode.Force);

        }
    }

    public void reeset()
    { 
        rbmain.transform.position = new Vector3(7.0f, 1.5f, -7.0f);
        rbsec.transform.position = new Vector3(-7.0f, 1.5f, 7.0f);
        rbmain.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        rbsec.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        rbmain.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        rbsec.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);

    }


    //Char Select
    public void turnFatty()
    {
        rbmain.transform.localScale = new Vector3(3.0f, 1.0f, 3.0f);
        rbmain.mass = 4.0f;
        MaxSpeed = 275.0f;
        pow = 3;
        reeset();
    }

    public void turnJeff()
    {
        rbmain.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        rbmain.mass = 1.0f;
        MaxSpeed = 200.0f;
        pow = 3;
        reeset();
    }

    public void turnSpeedy()
    {
        rbmain.transform.localScale = new Vector3(0.65f, 1.0f, 0.65f);
        rbmain.mass = 0.25f;
        MaxSpeed = 210.0f;
        pow = 3;
        reeset();
    }

    public void turnLanky()
    {
        rbmain.transform.localScale = new Vector3(3.0f, 1.0f, 1.0f);
        rbmain.mass = 2.75f;
        MaxSpeed = 190.0f;
        pow = 2;
        reeset();
    }

    public void turnChangey()
    {
        rbmain.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        rbmain.mass = 0.1f;
        MaxSpeed = 18.5f;
        pow = 0;
        reeset();
    }
}
