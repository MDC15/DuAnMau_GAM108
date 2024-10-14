using UnityEngine;
using Patterns.Singleton;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] PlayerMovement _player;

    void Init()
    {

    }

    void Start()
    {
        Init();
    }
}