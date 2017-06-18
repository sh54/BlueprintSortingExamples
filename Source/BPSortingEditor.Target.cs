// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class BPSortingEditorTarget : TargetRules
{
	public BPSortingEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "BPSorting" } );
    }
}
