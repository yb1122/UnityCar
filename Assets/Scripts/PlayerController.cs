using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);




    }
}
