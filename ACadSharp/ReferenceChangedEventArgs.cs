﻿using System;

namespace ACadSharp
{
	// TODO: Add an eventargs for adding and removing from lists??
	public class ReferenceChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Current value
		/// </summary>
		public CadObject Current { get; }

		/// <summary>
		/// Old value for the object
		/// </summary>
		public CadObject Old { get; }

		public ReferenceChangedEventArgs(CadObject curr)
		{
			this.Current = curr;
		}

		public ReferenceChangedEventArgs(CadObject curr, CadObject old)
		{
			this.Current = curr;
			this.Old = old;
		}
	}
}
