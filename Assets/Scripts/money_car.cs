using UnityEngine;

public class money_car : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject player;

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
        if (transform.position.z < player.transform.position.z)
        {
            speed += 5.0f;
        }else
        {
            speed += 0f;
        }
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
