﻿//  Copyright 2012 Applied Geographics, Inc.
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGeo.Clients.Ags.Proxy
{
  [Serializable]
  public class MapServerDefinition
  {
    private string _url = null;
    private List<MapServerInfo> _mapServerInfos = new List<MapServerInfo>();

    internal MapServerDefinition(string url)
    {
      _url = url;
    }

    public List<MapServerInfo> MapServerInfos
    {
      get
      {
        return _mapServerInfos;
      }
    }

    public string Url
    {
      get
      {
        return _url;
      }
    }

    public MapServer NewMapServer()
    {
      return new MapServer(_url);
    }
  }
}
