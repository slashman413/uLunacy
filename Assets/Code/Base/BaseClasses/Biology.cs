using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class of Characters and Mobs
public class Biology
{
	// health point
	public float maxHp;
	public float currentHp;

	// magic point
	public float maxMp;
	public float currentMp;

	// tiredness point
	public float currentTp;

	// constructors
	public Biology ()
	{
		currentHp = 100.0f;
		currentMp = 100.0f;
		currentTp = 0.0f;
	}

	public Biology (float initHp, float initMp, float initTp)
	{
		currentHp = initHp;
		currentMp = initMp;
		currentTp = initTp;
	}

	// common methods
	public bool IsAlive ()
	{
		return (currentHp > 0);
	}

	public bool TakeDamage (float damage)
	{
		if (currentHp <= 0) 
		{
			return false;
		}
		currentHp -= damage;
		return true;
	}

	public bool ConsumeMp (float consumingMp)
	{
		if (currentMp <= 0 || currentMp < consumingMp) 
		{
			return false;
		}
		currentMp -= consumingMp;
		return true;
	}

	public bool IncreaseTp (float increasingTp)
	{
		// TODO: need maximum limit of tp?
		currentTp += increasingTp;
		return true;
	}
}
