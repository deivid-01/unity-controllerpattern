using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Cube : MonoBehaviour
{
    public GameObject explotion;

    public static bool explotionOn;

    private void Start ()
    {
        explotionOn = false;
        explotion.SetActive ( false );
    }
    private void OnMouseDown ()
    {
        explotionOn = true;
        StartCoroutine ( Explode () );

        ScoreController.instance.UpdateScore ();
    }

    IEnumerator Explode ()
    {
        this.GetComponent<MeshRenderer> ().enabled = false;
        explotion.transform.position = gameObject.transform.position;
        explotion.SetActive ( true );
        CameraShaker.Instance.ShakeOnce ( 5f , 5f , .1f , 1f );
        yield return new WaitForSeconds ( 1f );

        explotion.SetActive ( false );
        explotionOn = false;

    }
}
