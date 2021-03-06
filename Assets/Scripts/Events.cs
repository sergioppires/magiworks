using System;
using UnityEngine;

public class Events : MonoBehaviour
{

    public static Events current;

    private void Awake()
    {
        current = this;
    }
    public event Action onStartGame;
    public event Action onEndGame;
    public void StartGame()
    {
        onStartGame?.Invoke();
    }

    public void EndGame()
    {
        onEndGame?.Invoke();
    }

    //Button press events
    public event Action onPressRightButton;
    public event Action onPressLeftButton;

    public void PressRightButton()
    {
        onPressRightButton?.Invoke();
    }

    public void PressLeftButton()
    {
        onPressLeftButton?.Invoke();
    }


    //Fireworks Emitter Events 
    public event Action<Fireworks> onEmitFireworks;
    public event Action<bool> onExplodeFireworks;
    public event Action<bool> onHitButtonRightTime;

    public void EmitFireworks(Fireworks fireworks)
    {
        onEmitFireworks?.Invoke(fireworks);
    }

    public void ExplodeFireworks(bool success)
    {
        onExplodeFireworks?.Invoke(success);
    }
    public void HitButtonRightTime(bool isLeft)
    {
        onHitButtonRightTime?.Invoke(isLeft);
    }

    //LevelUp Events
    public event Action<Level> onLevelUp;
    public event Action<Level> onLevelReset;
    public event Action<Level> onUpdateLevel; 

    public void LevelUp(Level level)
    {
        onLevelUp?.Invoke(level);
    }
    public void LevelReset(Level level)
    {
        onLevelReset?.Invoke(level);
    }
    public void UpdateLevel(Level level)
    {
        onUpdateLevel?.Invoke(level);
    }
}
