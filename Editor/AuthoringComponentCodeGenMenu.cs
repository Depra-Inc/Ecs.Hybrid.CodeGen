﻿// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.CodeGen.Editor.Pipeline;
using UnityEditor;
using UnityEngine;
using static Depra.Ecs.Hybrid.CodeGen.Editor.Module;

namespace Depra.Ecs.Hybrid.CodeGen.Editor
{
	internal static class AuthoringComponentCodeGenMenu
	{
		[MenuItem(FRAMEWORK_NAME + SLASH + nameof(CodeGen) + "/Generate/Authoring Components")]
		private static void GenerateComponentBakers()
		{
			UnityCodeGenUtility.Generate<AuthoringComponentGenerator>();

			Debug.Log("Authoring components generated.");
		}
	}
}