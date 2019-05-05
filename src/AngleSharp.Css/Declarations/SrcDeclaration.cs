namespace AngleSharp.Css.Declarations
{
    using System;
    using static ValueConverters;

    static class SrcDeclaration
    {
        public static String Name = PropertyNames.Src;

        public static IValueConverter Converter = SrcListConverter;

        public static PropertyFlags Flags = PropertyFlags.None;
    }
}
