
using UnityEngine;

public class player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public float jumpSpeed = 5f;
    public float downSpeed = 5f;
   
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
    //private Vector3 playerPos = new Vector3(0, 1,0);
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //float xPos = transform.position.x;

        if (KinectManager.instance.IsAvailable)
        {
             float xPos = KinectManager.instance.PaddlePosition;
            float jump = KinectManager.instance.JumpPosition;
            Debug.Log("jump   "+jump);
           
           if (Mathf.Clamp(xPos, -8f, 8f) > 0)
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (Mathf.Clamp(xPos, -8f, 8f) < 0)
              rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f),1, transform.position.z);
            // transform.position = playerPos;
            if (jump > -0.92 && jump< -0.47) {
                rb.AddForce(Vector3.up * jumpSpeed);
                rb.AddForce(Vector3.down * (downSpeed));
            }
            
        }
        else
        {
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            }
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed);
            rb.AddForce(Vector3.down * (downSpeed));
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<Game_Manager>().EndGame();
        }

    }
}

