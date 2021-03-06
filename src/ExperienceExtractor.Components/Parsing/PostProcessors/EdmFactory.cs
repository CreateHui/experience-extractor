﻿//--------------------------------------------------------------------------------------------
// Copyright 2015 Sitecore Corporation A/S
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
// except in compliance with the License. You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the 
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
// either express or implied. See the License for the specific language governing permissions 
// and limitations under the License.
// -------------------------------------------------------------------------------------------

using ExperienceExtractor.Api.OData;
using ExperienceExtractor.Api.Parsing;
using ExperienceExtractor.Components.PostProcessors;
using ExperienceExtractor.Processing;

namespace ExperienceExtractor.Components.Parsing.PostProcessors
{
    [ParseFactory("edm", "EDM/CSDL schema", "Adds EDM/CSDL schema to the output")]
    public class EdmFactory : IParseFactory<ITableDataPostProcessor>
    {
        public ITableDataPostProcessor Parse(JobParser parser, ParseState state)
        {
            return new EdmSchemaBuilder();            
        }
    }
}
