using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {
	public GameObject fullHeart;
	public GameObject halfHeart;

	public GameObject fullHeartButton;
	public GameObject halfHeartButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowExternal()
	{
		fullHeart.SetActive (true);
		halfHeart.SetActive (false);

		fullHeartButton.SetActive (false);
		halfHeartButton.SetActive (true);
	}

	public void ShowInternal()
	{
		fullHeart.SetActive (false);
		halfHeart.SetActive (true);

		fullHeartButton.SetActive (true);
		halfHeartButton.SetActive (false);
	}
}
