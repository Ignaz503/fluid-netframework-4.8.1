using System;
using System.Reflection;
using System.Text;

namespace Fluid
{
    public class MemberNameStrategies
    {
        public static readonly MemberNameStrategy Default = RenameDefault;
        public static readonly MemberNameStrategy CamelCase = RenameCamelCase;
        public static readonly MemberNameStrategy SnakeCase = RenameSnakeCase;

        private static string RenameDefault(MemberInfo member) => member.Name;
        public static string RenameCamelCase(MemberInfo member)
        {
            var firstChar = member.Name[0];

            if (firstChar == char.ToLowerInvariant(firstChar))
            {
                return member.Name;
            }

            var name = member.Name.ToCharArray();
            name[0] = char.ToLowerInvariant(firstChar);

            return new String(name);
        }

        public static string RenameSnakeCase(MemberInfo member)
        {
            var builder = new StringBuilder();
            var name = member.Name;
            var previousUpper = false;

            for (var i = 0; i < name.Length; i++)
            {
                var c = name[i];
                if (char.IsUpper(c))
                {
                    if (i > 0 && !previousUpper)
                    {
                        builder.Append("_");
                    }
                    builder.Append(char.ToLowerInvariant(c));
                    previousUpper = true;
                }
                else
                {
                    builder.Append(c);
                    previousUpper = false;
                }
            }
            return builder.ToString();
        }

    }
}
