namespace Microsoft.Maui.Graphics
{
	public static class IFontExtensions
	{
		public static string GetSvgWeight(this IFont font)
		{
			if (font == null)
			{
				return null;
			}

			if (font.Weight == FontWeights.Normal)

/* Unmerged change from project 'Graphics(net8.0-maccatalyst)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net8.0-windows10.0.19041)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net8.0-windows10.0.20348)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net8.0-macos)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net7.0)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net7.0-ios)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net7.0-maccatalyst)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net7.0-android)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net7.0-windows10.0.19041)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net7.0-windows10.0.20348)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/

/* Unmerged change from project 'Graphics(net7.0-macos)'
Before:
				return "normal";

			if (font.Weight == FontWeights.Bold)
				return "bold";
After:
			{
				return "normal";
*/
			{
				return "normal";
			}

			if (font.Weight == FontWeights.Regular)
			{
				return "normal";
			}

			if (font.Weight == FontWeights.Bold)
			{
				return "bold";
			}
			}

			if (font.Weight == FontWeights.Regular)
			{
				return "normal";
			}

			if (font.Weight == FontWeights.Bold)
			{
				return "bold";
			}

			return font.Weight.ToInvariantString();
		}

		public static string GetSvgStyle(this IFont font)
		{
			if (font == null)
			{
				return null;
			}

			if (font.StyleType == FontStyleType.Italic)
			{
				return "italic";
			}

			if (font.StyleType == FontStyleType.Oblique)
			{
				return "oblique";
			}

			return "normal";
		}
	}
}
