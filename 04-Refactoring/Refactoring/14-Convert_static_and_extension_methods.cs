﻿namespace JetBrains.ReSharper.Koans.Refactoring
{
    // Convert Extension Method to Plain Static
    //
    // No keyboard shortcut. Invoke via Refactor This
    // Ctrl+Shift+R

    // Convert Static Method to Extension Method
    //
    // No keyboard shortcut. Invoke via Refactor This
    // Ctrl+Shift+R

    public static class ConvertStaticAndExtensionMethods
    {
        // 1. Convert extension method to plain static
        //    Place text caret on method name
        //    Invoke Refactor This → Extension Method to Plain Static
        //    Call site is updated
        public static void ExtensionMethod(this Target target, string value)
        {
        }

        // 2. Convert extension method to plain static
        //    Place text caret on method name
        //    Invoke Refactor This → Convert Static Method to Extension
        //    Call site is updated
        public static void StaticMethod(Target target, string value)
        {
        }

        public static void Consumer()
        {
            var target = new Target();
            target.ExtensionMethod("cheese");
            StaticMethod(target, "sandwich");
        }

        public class Target
        {
        }
    }
}