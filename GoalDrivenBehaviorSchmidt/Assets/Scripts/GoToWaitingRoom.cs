using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToWaitingRoom: GAction
{
    public override bool PrePerform()
    {
        return true;
    }
    public override bool PostPerform()
    {
        return true;
    }
}
