using UnityEngine;

public class MovePlayer : MonoBehaviour {
    public Rigidbody rb;
   	public float forceOnZ=500f;
    public float applyForce = 200f;
    public Transform trans;
    Vector3 rotateRight=new Vector3(0,30f,0);
    Vector3 rotateLeft = new Vector3(0, -30f, 0);
    // Use this for initialization
    //	void Start () {
    //        rb.AddForce(0, 200, 500);
    //	}

    // We are using FixedUpdate as we are dealing  with unity physic
    void FixedUpdate () {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(0, 0, forceOnZ * Time.deltaTime,ForceMode.Acceleration);  //Adding Force on Z axis While Updatimg Frame 
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            /*if (Input.GetKeyDown(KeyCode.DownArrow)) {
                rb.AddForce(0,0,-3000*Time.deltaTime,ForceMode.Impulse);
            }*/
            rb.AddForce(0, 0, -forceOnZ * Time.deltaTime,ForceMode.Acceleration);  //Adding Force on Z axis While Updatimg Frame 
        }

       

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(applyForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            trans.Rotate(rotateRight*Time.deltaTime);//For rotating Car with respect to mOvement
            //trans.localEulerAngles =new  Vector3(0,2,0);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-applyForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            trans.Rotate(rotateLeft*Time.deltaTime);//For rotating Car with respect to mOvement
            //trans.localEulerAngles = new Vector3(0, 2, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            //rb.position = rb.transform.position;
            rb.velocity = Vector3.zero;
        }

        if (rb.position.y<21.47) {
            
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
/*
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 100.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 50.0f;
        //var y = Input.GetAxis("Y")*Time.deltaTime;
        transform.Rotate(0, x, 0);
        transform.Translate(z, 0, 0);
    }
}*/