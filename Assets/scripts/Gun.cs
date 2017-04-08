using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnPosition;
    //public Transform spawnPositionDir;

    void Start()
    {
        //Vector3 mousPos = Input.mousePosition;

    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletShoot = Instantiate(bullet, spawnPosition.position, Quaternion.identity) as GameObject;

            Debug.Log("shoot");
        }
    }
}
