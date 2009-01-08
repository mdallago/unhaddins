﻿using System;

namespace uNhAddIns.Adapters
{
	/// <summary>
	/// Attribute to mark a mathod as involved in a persistence conversation
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class PersistenceConversationAttribute : Attribute
	{
		/// <summary>
		/// The action to take after finishing this part of the conversation.
		/// </summary>
		/// <remarks>
		/// Default <see cref="PersistenceConversationalAttribute.DefaultEndMode"/>
		/// </remarks>
		public EndMode ConversationEndMode { get; set; }

		///<summary>
		/// <see langword="true"/> if you want explicit exclude a method from a persistence-conversation.
		///</summary>
		/// <remarks>
		/// Default <see langword="false"/>.
		/// </remarks>
		public bool Exclude { get; set; }
	}
}
