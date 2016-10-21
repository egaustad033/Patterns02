using UnityEngine;
using System.Collections;

public class TrainState : MonoBehaviour {

	State myState;

	State forwardState = new ForwardState();
	State backwardState = new BackState();
	State stopState = new StopState();

	public TrainMovement t;
	public int rand = 0;

	public int dir;
	private Renderer rend;
	// Use this for initialization
	void Start () {
		dir = 2;

	}
	// Update is called once per frame
	void Update () {
		if(dir == 0)
		{
			myState = forwardState;
			myState.changeState(t);

		}
		if (dir == 1)
		{
			myState = backwardState;
			myState.changeState(t);

		}
		if (dir == 2) 
		{
			myState = stopState;
			myState.changeState (t);

		}
	}
}
public abstract class State
{
	public abstract void changeState(TrainMovement t);
}

public class BackState : State
{
	public override void changeState(TrainMovement t)
	{
		t.move = new Back ();
	}
}
public class ForwardState : State
{
	public override void changeState(TrainMovement t)
	{
		t.move = new For ();
	}
}

public class StopState : State
{
	public override void changeState (TrainMovement t)
	{
		t.move = new Stop ();
	}
}


