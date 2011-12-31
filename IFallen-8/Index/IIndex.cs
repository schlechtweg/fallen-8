// 
// IIndex.cs
//  
// Author:
//       Henning Rauch <Henning@RauchEntwicklung.biz>
// 
// Copyright (c) 2011 Henning Rauch
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using Fallen8.API.Plugin;
using Fallen8.Model;
using System.Collections.Generic;

namespace Fallen8.API.Index
{
	/// <summary>
	/// The Fallen8 index interface.
	/// </summary>
	public interface IIndex : IFallen8Plugin, IDictionary<IComparable, HashSet<IGraphElementModel>>
	{
		/// <summary>
		/// Count of the keys.
		/// </summary>
		/// <returns>
		/// The key count.
		/// </returns>
		Int64 CountOfKeys ();
		
		/// <summary>
		/// Count of the values.
		/// </summary>
		/// <returns>
		/// The value count.
		/// </returns>
		Int64 CountOfValues ();
		
		/// <summary>
		/// Clears this instance.
		/// </summary>
		void Wipe();
		
		/// <summary>
		/// Tries to add or update.
		/// </summary>
		// <returns>
		/// <c>true</c> if something was added; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='key'>
		/// Key.
		/// </param>
		/// <param name='graphElement'>
		/// Graph element.
		/// </param>
		Boolean TryAddOrUpdate (IComparable key, IGraphElementModel graphElement);
		
		/// <summary>
		/// Tries to remove a key.
		/// </summary>
		// <returns>
		/// <c>true</c> if something was removed; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='key'>
		/// Key.
		/// </param>
		Boolean TryRemoveKey (IComparable key);
		
		/// <summary>
		/// Tries to remove a value.
		/// </summary>
		// <returns>
		/// <c>true</c> if something was removed; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='graphElement'>
		/// Graph element.
		/// </param>
		Boolean TryRemoveValue (IComparable graphElement);
	}
}

