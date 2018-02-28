using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveText : MonoBehaviour {

	public GameObject starwarsCanvas;
	public GameObject flatText;
	public Animator cinematicAnimator;

	bool moveText;

	// Use this for initialization
	void Start () {
			
		Invoke("HideText",3);
		
	}
	
	void HideText() {
		
		starwarsCanvas.SetActive(!starwarsCanvas.activeSelf);
		moveText = true;
		Invoke("StartAnimation", 18);
		//cinematicAnimator.Play("CameraAnimation");
	}
	void StartAnimation() {

		cinematicAnimator.Play("CameraAnimation");
	}
	// Update is called once per frame
	void Update () {

		if(moveText) {

			flatText.transform.Translate(Vector3.back * (Time.deltaTime*0.5f));
		}
	}
}
