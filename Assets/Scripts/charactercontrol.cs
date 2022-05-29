using UnityEngine;

public class charactercontrol : MonoBehaviour
{   
    public float movementSpeed = 50f;
    public Spawnmanager spawnmanager;
    public float speed = 5.0f;
    public float Rspeed = 5.0f;
    public float Zspeed = 0.1f;
    public Rigidbody rb;
    public GameObject bullet;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //transform.position += new Vector3(0, 0, Zspeed) * Time.deltaTime;
        if (speed < 20)
        {
            speed += 1f;
        }
        else if (speed > 20)
        {
            speed = 20f;
        }

        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 6;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(0, 0, vMovement) * Time.deltaTime);
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * Rspeed, 0.0f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (speed > 0f)
            {
                speed -= 2f;
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }

        transform.position += transform.forward * speed * Time.deltaTime;

        //output to log the position change
        Debug.Log(transform.position);
        Debug.Log(speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnmanager.SpawnTriggerEntered();
    }
}
