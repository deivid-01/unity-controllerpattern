using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;



    private void Start ()
    {

        StartCoroutine ( SpawnCube () );
    }

    IEnumerator SpawnCube ()
    {

        cube.transform.position = RandomPosition ();
        cube.transform.localScale = RandomScale ();
        if ( !Cube.explotionOn )
            cube.GetComponent<MeshRenderer> ().enabled = true;

        yield return new WaitForSeconds ( 0.8f );
        if ( !Cube.explotionOn )
            cube.GetComponent<MeshRenderer> ().enabled = false;


        StartCoroutine ( SpawnCube () );

    }

    UnityEngine.Vector3 RandomPosition ()
    {
        Vector3 randVector3=Vector3.zero;
        randVector3.x = Random.Range ( -10f , 10f );
        randVector3.y = Random.Range ( -10f , 10f );

        return randVector3;
    }

    Vector3 RandomScale ()
    {

        Vector3 randScale=Vector3.one;
        randScale.x = Random.Range ( 1 , 3 );
        randScale.y = Random.Range ( 1 , 3 );

        return randScale;
    }


}
