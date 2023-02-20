using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField]
    float first,dist;
    float rndm;

    [SerializeField]
    GameObject pipe;

    private void Start()
    {

        for (int i = 0; i < 50; i++)
        {
            rndm = Random.Range(2, 5.2f);
            first += dist;
            Vector2 pos = new Vector2(first,rndm);

            Instantiate(pipe, pos, transform.rotation);

        }
    }

}
