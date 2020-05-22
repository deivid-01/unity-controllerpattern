using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public  Text score;
    #region Singlenton
    public static Score instance;
    private void Awake ()
    {
        instance = this;
    }

    #endregion

    public void  UpdateScore () => score.text = ( int.Parse ( score.text ) + 1 ).ToString ();

}
