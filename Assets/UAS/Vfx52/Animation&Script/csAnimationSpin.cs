using UnityEngine;

namespace UAS.Vfx52.Animation_Script
{
	public class csAnimationSpin : MonoBehaviour {

		Animation an;

		void Update () {
			an = gameObject.GetComponent<Animation>();
			an.Play();
		}
	}
}
