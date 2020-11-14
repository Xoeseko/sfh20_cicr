using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickNameScript : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public GameObject text;

    public float delay = 0.5f;
    public bool brickCanFall = true;

    // Update is called once per frame
    void Update()
    {
        spawnPos.position = new Vector3(0.26f, spawnPos.position.y, spawnPos.position.z);
        if (Input.GetKeyDown(KeyCode.Space) && brickCanFall)
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
            brickCanFall = false;
            delay = 1f;
        }

        if (delay > 0 && !brickCanFall)
        {
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                Instantiate(text, spawnPos.position, spawnPos.rotation);
            }
        }
    }
}
