﻿// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System.Linq;

namespace Depra.Ecs.Hybrid.CodeGen.Editor
{
	internal static class StringExtensions
	{
		public static string ToCamelCaseWithUnderscore(this string self) =>
			"_" + string.Concat(self.Select((x, i) => i == 0 && char.IsUpper(x)
				? char.ToLower(x).ToString()
				: x.ToString()));
	}
}