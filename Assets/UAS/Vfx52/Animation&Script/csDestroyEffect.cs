using UnityEngine;
using UnityEngine.InputSystem;

namespace UAS.Vfx52.Animation_Script
{
	public class csDestroyEffect : MonoBehaviour {

		void Update ()
		{
			if(Keyboard.current.xKey.wasPressedThisFrame ||
			   Keyboard.current.zKey.wasPressedThisFrame ||
			   Keyboard.current.zKey.wasPressedThisFrame)
			{
				Destroy(gameObject);
			}
		}
	}
}
