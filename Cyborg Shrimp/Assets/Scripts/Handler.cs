using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Handler : MonoBehaviour
{
    public GameAction actionObj;
    public UnityEvent handlerEvent;

    private void Start()
    {
        actionObj.action += Handle;
    }

    private void Handle()
    {
        handlerEvent.Invoke();
    }
}
