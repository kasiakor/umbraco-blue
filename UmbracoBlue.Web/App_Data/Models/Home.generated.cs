//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, IContentControls, IFooter, IHeaderControls, IMainImageControls, ISEocontrols
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Colour Name: Enter your favourite colour
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("colourName")]
		public string ColourName => this.Value<string>("colourName");

		///<summary>
		/// Show Image: Add image to show
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("showImage")]
		public bool ShowImage => this.Value<bool>("showImage");

		///<summary>
		/// Main Content: Enter main content for the page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("mainContent")]
		public Newtonsoft.Json.Linq.JToken MainContent => ContentControls.GetMainContent(this);

		///<summary>
		/// Social Links: Enter social links for the footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("socialLinks")]
		public IEnumerable<IconLinkItem> SocialLinks => Footer.GetSocialLinks(this);

		///<summary>
		/// Subtitle: Enter subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("subtitle")]
		public string Subtitle => HeaderControls.GetSubtitle(this);

		///<summary>
		/// Title: Enter the title, if blank page name will be used
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("title")]
		public string Title => HeaderControls.GetTitle(this);

		///<summary>
		/// Main Image: Enter main image for the page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("mainImage")]
		public IPublishedContent MainImage => MainImageControls.GetMainImage(this);

		///<summary>
		/// Meta Description: Enter meta description for the page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => SEocontrols.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords: Enter meta keywords for the page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaKeywords")]
		public IEnumerable<string> MetaKeywords => SEocontrols.GetMetaKeywords(this);

		///<summary>
		/// Meta Name: Enter meta name for the page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaName")]
		public string MetaName => SEocontrols.GetMetaName(this);
	}
}