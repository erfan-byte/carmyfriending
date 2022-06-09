using UnityEngine;

public class charactercontrol : MonoBehaviour
{   
    public Spawnmanager spawnmanager;
    public float speed;
    public float movementSpeed;
    public float Rspeed;
    public float Zspeed;
    public float range;
    public Rigidbody rb;
    public GameObject bullet;

    private bool shot;
   

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
            speed += 0.5f;
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
        RaycastHit hit;
        Ray shooting = new Ray(this.transform.position, Vector3.forward);

        Debug.DrawRay(transform.position, Vector3.forward * range);
        
        if (!shot)
        {
            if (Physics.Raycast(shooting, out hit, range))
            {
                if (hit.collider.tag == "enemy")
                {
                    Debug.Log("hit true");
                    Instantiate(bullet, this.transform.position, this.transform.rotation);
                }
            }
        }

        //output to log the position change
        /*Debug.Log(transform.position);
        Debug.Log(speed);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnmanager.SpawnTriggerEntered();
    }
}
