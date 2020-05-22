using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public UIScore uiScore;

    public int actualScore;

    #region Singlenton
    public static ScoreController instance;

    void Awake ()
    {
        instance = this;
    }
    #endregion
    private void Start () => uiScore.DisplayScore ( actualScore.ToString () );


    public void UpdateScore ()
    {
        //Logic
        actualScore = Operation.IncreaseScore ( actualScore );
        //UI
        uiScore.DisplayScore ( actualScore.ToString () );
    }
}
