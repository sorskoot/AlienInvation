using System.Collections;
using System.Collections.Generic;
using Metromino.Interfaces;
using RealityCollective.ServiceFramework.Services;
using UnityEngine;

public class GameStateBase : MonoBehaviour
{
    private IGameStateService internalGameState;

    protected IGameStateService GameStateService =>
        internalGameState ??= ServiceManager.Instance.GetService<IGameStateService>();
}
