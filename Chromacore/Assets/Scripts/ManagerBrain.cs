﻿using UnityEngine;
using System.Collections;

public class ManagerBrain : MonoBehaviour {

	public void LoadMenuScene() {
		Application.LoadLevel ("MenuScene");
	}

	public void LoadGameScene() {
		Application.LoadLevel ("GameScene");
	}
}
