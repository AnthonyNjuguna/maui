using System;
using Microsoft.CodeAnalysis;

namespace Microsoft.Maui.Controls.SourceGen
{
	public static class Descriptors
	{
		public static DiagnosticDescriptor XamlParserError = new DiagnosticDescriptor(
			id: "MAUIG1001",
			title: new LocalizableResourceString(nameof(MauiGResources.XamlParsingFailed), MauiGResources.ResourceManager, typeof(MauiGResources)),
			messageFormat: new LocalizableResourceString(nameof(MauiGResources.XamlParsingErrorMessage), MauiGResources.ResourceManager, typeof(MauiGResources)),
			category: "XamlParsing",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true);

		public static DiagnosticDescriptor XamlCompFalse = new DiagnosticDescriptor(
			id: "MAUIG0070",
			title: new LocalizableResourceString(nameof(MauiGResources.XamlCompFalseMessage), MauiGResources.ResourceManager, typeof(MauiGResources)),
			messageFormat: new LocalizableResourceString(nameof(MauiGResources.XamlCompFalseMessage), MauiGResources.ResourceManager, typeof(MauiGResources)),
			category: "XamlParsing",
			defaultSeverity: DiagnosticSeverity.Warning,
			isEnabledByDefault: true);
	}
}