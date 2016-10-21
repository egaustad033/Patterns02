using UnityEngine;
using System.Collections;

public class StopCap : MonoBehaviour {

	public TrainState i;

	void OnMouseDown() {
		if (i.rand == 3 || i.rand == 5) {
			i.dir = 0;
		} else if (i.rand == 1 || i.rand == 4) {
			i.dir = 1;
		} else {
			i.dir = 2;
		}
	}
}
