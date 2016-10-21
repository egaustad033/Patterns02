using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour {

	public TrainState i;

	void OnMouseDown() {
		if (i.rand == 0 || i.rand == 1) {
			i.dir = 0;
		} else if (i.rand == 2 || i.rand == 3) {
			i.dir = 1;
		} else {
			i.dir = 2;
		}
	}
}