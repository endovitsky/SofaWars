﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
При активации ледяной стрелы курсор должен поменять свой вид. 
После того как игрок нажмет левую кнопку мыши на выбранном враге (нельзя выбрать дружественных юнитов или землю), 
	ледяная стрела вылетает от главного персонажа в выбранного юнита, 
	при этом замедляет его скорость и скорость его атаки на некоторое время.
Если игрок выбрал врага вне этого радиуса, 
	то персонаж должен сначала подойти на минимальное расстояние для выполнения этой способности;
*/

namespace Assets.Abilities
{
	public class IceBolt : Ability, Target
	{
		public float Slow;  //процентное значение замедления [0..1]. 0 — не замедляет вообще, 1 — цель не может двигаться
		public float AttackSlow;    //процентное значение замедления [0..1]. 0 — не замедляет атаку вообще, 1 — цель не может атаковать
		public int Duration;    //длительность заморозки в секундах
	}
}