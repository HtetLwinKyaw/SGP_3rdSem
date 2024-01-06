using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force=1000f;
    public float speed=10f;
    public float speed22 = 1f;
    public float max_x;
    public float min_x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(playerpos.x, min_x,max_x);
        transform.position = playerpos;

        /*
         ********METHOD 1 *********
         Vector3 playerpos = transform.position;
         if(playerpos.x<min_x)
         {
             playerpos.x = min_x;
         }
         if (playerpos.x > max_x)
         {
             playerpos.x = max_x;
         }
         transform.position = playerpos;*/

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
            
        }
        //rigidbody.AddForce(0, 0, 500f * Time.deltaTime);
    }
    public void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
}
