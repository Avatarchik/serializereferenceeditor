﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRDemoAttribute : SRAttribute
{
	public SRDemoAttribute(Type type) : base(type)
	{
	}

	public SRDemoAttribute(Type[] types) : base(types)
	{
	}

	public override void OnCreate(object instance)
	{
		if(instance is AbstractData)
		{
			((AbstractData)instance).DataName = instance.GetType().Name;
		}
	}
}
