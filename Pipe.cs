using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    GamePlayManager manager;
     void Awake()
    {
        manager = GamePlayManager.FindObjectOfType<GamePlayManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        manager.ScoreUp();
        manager.bestOfScore();
    }
}
