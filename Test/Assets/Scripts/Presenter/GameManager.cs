using System;
using Model;
using Presenter;
using UnityEngine;
using View;
public class GameManager : MonoBehaviour
{
    public Action Instantiater;
    public IFallingItem FallingItem;
    public IBallPresenter BallPresenter;
    public IBallView BallView;
    public GameObject go;
    void Start()
    {
        GameObject GO = Instantiate(go, new Vector3(0, 20, 0), Quaternion.identity);
       
        FallingItem = GO.AddComponent<BallModel>();
        BallView = GO.AddComponent<BallView>();
        BallPresenter = GO.AddComponent<BallPresenter>();
        BallPresenter.Init(BallView,FallingItem);
        
    }

    
    void Update()
    {
        
    }
}
