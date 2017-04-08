using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public Transform target;
    //public Transform origin;

    //private Rigidbody rb;

    void Start()
    {

        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //AB = B - A
        Vector3 dir = this.transform.position - target.position;
        //Vector3 dir = target.position - this.transform.position;
        transform.Translate(dir.normalized * Time.deltaTime, Space.World);
        transform.LookAt(dir);
        //rb.velocity = dir;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
            Debug.Log("destroy");
        }
    }
}
