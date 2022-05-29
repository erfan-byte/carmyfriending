using UnityEngine;

public class bullet_control : MonoBehaviour
{
    public float speed = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        //transform.position += new Vector3(0, 0, Zspeed) * Time.deltaTime;
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
