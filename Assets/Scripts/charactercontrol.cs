using UnityEngine;

public class charactercontrol : MonoBehaviour
{   
    public float movementSpeed = 50f;
    public Spawnmanager spawnmanager;
    public float speed = 5.0f;
    public float Zspeed = 0.1f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.position(0, 0, Zspeed) * Time.deltaTime;

        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(0, 0, vMovement) * Time.deltaTime);
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * speed, 0.0f);
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        spawnmanager.SpawnTriggerEntered();
    }
}
