using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pohod : MonoBehaviour {
	
		public GameObject KAI;

		public void OpenPohod ()
		{
			if (KAI != null) {
				bool isActive = KAI.activeSelf;
				KAI.SetActive (!isActive);
			} 
		}
}
