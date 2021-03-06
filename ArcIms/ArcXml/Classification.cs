//  Copyright 2012 Applied Geographics, Inc.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;

namespace AppGeo.Clients.ArcIms.ArcXml
{
  [Serializable]
  public abstract class Classification : ICloneable
	{
    private string _label = null;
    private Symbol _symbol;

    public string Label
    {
      get
      {
        return _label;
      }
      set
      {
        _label = value;
      }
    }

		public Symbol Symbol
		{
			get
			{
				return _symbol;
			}
			set
			{
				_symbol = value;
			}
		}

		public abstract object Clone();

		public abstract void WriteTo(ArcXmlWriter writer);
	}
}
