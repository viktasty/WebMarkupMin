﻿using System.Collections.Generic;

namespace WebMarkupMin.Core.Parsers
{
	/// <summary>
	/// XML parsing handlers
	/// </summary>
	internal sealed class XmlParsingHandlers : MarkupParsingHandlersBase
	{
		/// <summary>
		/// XML declaration handler
		/// </summary>
		public XmlDeclarationDelegate XmlDeclaration
		{
			get;
			set;
		}

		/// <summary>
		/// Processing instruction handler
		/// </summary>
		public ProcessingInstructionDelegate ProcessingInstruction
		{
			get;
			set;
		}

		/// <summary>
		/// CDATA sections handler
		/// </summary>
		public CdataSectionDelegate CdataSection
		{
			get;
			set;
		}

		/// <summary>
		/// Start tags handler
		/// </summary>
		public StartTagDelegate StartTag
		{
			get;
			set;
		}

		/// <summary>
		/// End tags handler
		/// </summary>
		public EndTagDelegate EndTag
		{
			get;
			set;
		}

		/// <summary>
		/// Empty tags delegate
		/// </summary>
		public EmptyTagDelegate EmptyTag
		{
			get;
			set;
		}


		/// <summary>
		/// XML declaration delegate
		/// </summary>
		/// <param name="context">Markup parsing context</param>
		/// <param name="attributes">List of attributes</param>
		public delegate void XmlDeclarationDelegate(MarkupParsingContext context, IList<XmlAttribute> attributes);

		/// <summary>
		/// Processing instruction delegate
		/// </summary>
		/// <param name="context">Markup parsing context</param>
		/// <param name="instructionName">Instruction name</param>
		/// <param name="attributes">List of attributes</param>
		public delegate void ProcessingInstructionDelegate(MarkupParsingContext context, string instructionName,
			IList<XmlAttribute> attributes);

		/// <summary>
		/// CDATA sections delegate
		/// </summary>
		/// <param name="context">Markup parsing context</param>
		/// <param name="cdataText">CDATA text</param>
		public delegate void CdataSectionDelegate(MarkupParsingContext context, string cdataText);

		/// <summary>
		/// Start tags delegate
		/// </summary>
		/// <param name="context">Markup parsing context</param>
		/// <param name="tagName">Tag name</param>
		/// <param name="attributes">List of attributes</param>
		public delegate void StartTagDelegate(MarkupParsingContext context, string tagName,
			IList<XmlAttribute> attributes);

		/// <summary>
		/// End tags delegate
		/// </summary>
		/// <param name="context">Markup parsing context</param>
		/// <param name="tagName">Tag name</param>
		public delegate void EndTagDelegate(MarkupParsingContext context, string tagName);

		/// <summary>
		/// Empty tags delegate
		/// </summary>
		/// <param name="context">Markup parsing context</param>
		/// <param name="tagName">Tag name</param>
		/// <param name="attributes">List of attributes</param>
		public delegate void EmptyTagDelegate(MarkupParsingContext context, string tagName,
			IList<XmlAttribute> attributes);
	}
}