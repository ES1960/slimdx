﻿// Copyright (c) 2007-2011 SlimDX Group
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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SlimDX.Generator
{
	class ApiModel
	{
		#region Interface

		/// <summary>
		/// Initializes a new instance of the <see cref="ApiModel"/> class.
		/// </summary>
		/// <param name="name">The name of the API.</param>
		public ApiModel(string name)
		{
			if (string.IsNullOrEmpty(name))
				throw new ArgumentException("Value may not be null or empty.", "name");

			Name = name;
		}

		/// <summary>
		/// Gets the name of the API.
		/// </summary>
		public string Name
		{
			get;
			private set;
		}

		public ReadOnlyCollection<TranslationModel> Translations
		{
			get
			{
				return translations.AsReadOnly();
			}
		}

		public ReadOnlyCollection<EnumerationModel> Enumerations
		{
			get
			{
				return enumerations.AsReadOnly();
			}
		}

		public ReadOnlyCollection<StructureModel> Structures
		{
			get
			{
				return structures.AsReadOnly();
			}
		}

		public ReadOnlyCollection<InterfaceModel> Interfaces
		{
			get
			{
				return interfaces.AsReadOnly();
			}
		}

		public void AddTranslation(TranslationModel model)
		{
			if (model == null)
				throw new ArgumentNullException("model");
			translations.Add(model);
		}

		public void AddEnumeration(EnumerationModel model)
		{
			if (model == null)
				throw new ArgumentNullException("model");
			enumerations.Add(model);
		}

		public void AddStructure(StructureModel model)
		{
			if (model == null)
				throw new ArgumentNullException("model");
			structures.Add(model);
		}

		public void AddInterface(InterfaceModel model)
		{
			if (model == null)
				throw new ArgumentNullException("model");
			interfaces.Add(model);
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return Name;
		}

		#endregion
		#region Implementation

		List<TranslationModel> translations = new List<TranslationModel>();
		List<EnumerationModel> enumerations = new List<EnumerationModel>();
		List<StructureModel> structures = new List<StructureModel>();
		List<InterfaceModel> interfaces = new List<InterfaceModel>();

		#endregion
	}
}