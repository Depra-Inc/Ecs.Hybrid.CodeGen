// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

namespace Depra.Ecs.Hybrid.CodeGen.Editor
{
	internal static class Module
	{
		public const string SLASH = "/";
		public const string FRAMEWORK_NAME = nameof(Depra);
		public const string MODULE_PATH = FRAMEWORK_NAME + SLASH + MODULE_NAME + SLASH;

		private const string MODULE_NAME = nameof(Ecs);
	}
}