using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Birdy BirdScript;
    public GameObject Borular;
    public float lowheight;
    public float topheight;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject( time ));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnObject( float time ) 
    {
       while(!BirdScript.isDead){

            Instantiate(Borular, new Vector3(2,Random.Range(-lowheight,topheight),0),  Quaternion.identity);
            yield return new WaitForSeconds(time);
       }
        
    }
}

