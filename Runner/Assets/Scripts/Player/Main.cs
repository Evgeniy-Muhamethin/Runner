using UnityEngine;

namespace Assets.Scripts.Player
{ 
	public class Main : MonoBehaviour
	{
		private Action _action;
	
		private void Start()
		{
			_action = new Action();
		}
	
	}
}
