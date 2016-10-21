using UnityEngine;
using System.Collections;

public class Ran : MonoBehaviour {

	public TrainState i;

	void OnMouseDown() {
		i.rand = Random.Range (0, 6);
	}
}
