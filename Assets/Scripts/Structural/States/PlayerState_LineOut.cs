using System.Collections.Generic;
using UnityEditor;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class PlayerState_LineOut : State
{
    Transform player;

    public PlayerState_LineOut(FSM fsm) : base(fsm) { }

    public override void OnStateEnter(Dictionary<string, object> blackboard)
    {

    }

    public override void OnStateExit(Dictionary<string, object> blackboard)
    {

    }

    public override void UpdateState(Dictionary<string, object> blackboard)
    {
        if (Input.GetMouseButton(0))
        {

        }
    }
}

