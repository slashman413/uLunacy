using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class of Characters and Mobs
public class Biology
{
	// health point
	private float maxHp;
	private float currentHp;

	// magic point
	private float maxMp;
	private float currentMp;

	// tiredness point
	private float currentTp;
	private float baseTp;

	// readiness point
	private float currentRp;

	// constructors
	public Biology ()
	{
		currentHp = maxHp = 100f;
		currentMp = maxMp = 100f;
		currentTp = 1f;
		baseTp = 10f;
		currentRp = 0f;
	}

	public Biology (float initHp, float initMp, float initTp, float initMaxHp, float initMaxMp, float initBaseTp, float initRp)
	{
		currentHp = initHp;
		currentMp = initMp;
		currentTp = initTp;

		maxHp = initMaxHp;
		maxMp = initMaxMp;
		baseTp = initBaseTp;

		currentRp = initRp;
	}

	// common methods
	public bool IsAlive ()
	{
		return (currentHp > 0) ? true : false;
	}

	public bool TakeDamage (float damage)
	{
		if (IsAlive() == false)
		{
			return false;
		}
		if (currentHp < damage) 
		{
			currentHp = 0;
		} 
		else 
		{
			currentHp -= damage;
		}

		return true;
	}

	public bool TakeHeal (float heal)
	{
		if (IsAlive() == false)
		{
			return false;
		}
		currentHp += heal;
		if (currentHp > maxHp) 
		{
			currentHp = maxHp;
		}
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

	public bool ConsumeTp (float increasingTp)
	{
		currentTp += increasingTp;
		return true;
	}

	// update readiness with tireness point
	public bool UpdateRp ()
	{
		if (currentRp >= 100f)
		{
			return false;
		}
		currentRp += (1000.0f / ((baseTp + currentTp) * 1000.0f));
		return true;
	}

	public bool IsReady()
	{
		return (currentRp >= 100f) ? true : false;
	}
}
