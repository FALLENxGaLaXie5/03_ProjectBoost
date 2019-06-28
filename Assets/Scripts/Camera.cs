using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject playerObject;
    [SerializeField] float offsetZ = 52f;
    [SerializeField] float offsetY = 18f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject)
        {
            gameObject.transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + offsetY, offsetZ);
        }
    }
}
