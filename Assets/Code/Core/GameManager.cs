using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
	static public GameController instance;

	private List<Biology> enemyTeam;
	private List<Biology> playerTeam;

	// constructor
	private GameController() 
	{
	}
		
	bool AddEnemy (Biology biology)
	{
		enemyTeam.Add (biology);

		return true;
	}

	bool AddPlayer (Biology biology)
	{
		playerTeam.Add (biology);

		return true;
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// either enemies or players are eliminated, game over and do nothing
		if (enemyTeam.Count <= 0 || playerTeam.Count <= 0) 
		{
			return;
		}


	}
}
