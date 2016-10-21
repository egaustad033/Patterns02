using UnityEngine;
using System.Collections;

public class TrainMovement : MonoBehaviour {

	public Movement move = new Stop ();
	public Rigidbody rb;

	private float Thrust = 0.0f;

	void Start () {
		rb = GetComponent <Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		move.Move(ref Thrust);
		rb.AddForce (transform.forward * Thrust * 100);

	}
}
public abstract class Movement
{
	public abstract void Move(ref float i);
}
public class Back : Movement
{
	public override void Move(ref float i)
	{
		i = -0.1f;
	}
}
public class For : Movement 
{
	public override void Move(ref float i)
	{
		i = 0.1f;
	}
}
public class Stop : Movement
{
	public override void Move (ref float i)
	{
		i = 0.0f;
	}
}
