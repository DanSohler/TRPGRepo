using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameStates State;

    public static event Action<GameStates> OnGameStateChanged;

    void Awake()
    {
        Instance = this; 
    }

    private void Start()
    {
        UpdateGameStates(GameStates.StartRound);
    }

    public void UpdateGameStates(GameStates newState)
    {
        State = newState;

        switch (newState)
        {
            case GameStates.StartRound:
                break;
            case GameStates.PlayerRound:
                break;
            case GameStates.EnemyRound:
                break;
            case GameStates.Victory:
                break;
            case GameStates.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }

    
}

public enum GameStates
{
    StartRound,
    PlayerRound,
    EnemyRound,
    Victory,
    Lose
};