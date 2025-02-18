namespace AngleSharp.Css.Declarations
{
    using AngleSharp.Css.Converters;
    using AngleSharp.Css.Dom;
    using System;
    using static ValueConverters;

    static class TextDecorationDeclaration
    {
        public static String Name = PropertyNames.TextDecoration;

        public static IValueConverter Converter = AggregateTuple(
            WithAny(
                ColorConverter.Option(InitialValues.TextDecorationColorDecl),
                TextDecorationStyleConverter.Option(InitialValues.TextDecorationLineDecl),
                TextDecorationLinesConverter.Option(InitialValues.TextDecorationStyleDecl)));

        public static ICssValue InitialValue = null;

        public static PropertyFlags Flags = PropertyFlags.Animatable | PropertyFlags.Shorthand;

        public static String[] Longhands = new[]
        {
            PropertyNames.TextDecorationColor,
            PropertyNames.TextDecorationLine,
            PropertyNames.TextDecorationStyle,
        };
    }
}
