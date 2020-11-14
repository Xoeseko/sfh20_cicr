using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWallConstructionScript : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;

    public float delay = 0.2f;
    public int brickCount = 0;

    // Update is called once per frame
    void Update()
    {

        if(delay > 0)
        {
            delay -= Time.deltaTime;
            if(delay <= 0 && brickCount < 20)
            {
                
                if(brickCount == 0 || brickCount == 12)
                {
                    spawnPos.position = new Vector3(-1f, spawnPos.position.y, spawnPos.position.z);
                }
                else if(brickCount == 6)
                {
                    spawnPos.position = new Vector3(-0.8f, spawnPos.position.y, spawnPos.position.z);
                }
                else
                {
                    spawnPos.position = new Vector3(spawnPos.position.x + 0.42f, spawnPos.position.y, spawnPos.position.z);
                }


                delay = 0.2f;
                brickCount += 1;

                if (brickCount != 16)
                {
                    Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
                }

            }
        }
    }
}
