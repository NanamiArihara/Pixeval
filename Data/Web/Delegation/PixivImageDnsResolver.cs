﻿// Pixeval - A Strong, Fast and Flexible Pixiv Client
// Copyright (C) 2019 Dylech30th
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Pixeval.Data.Web.Delegation
{
    public class PixivImageDnsResolver : DnsResolver
    {
        public static DnsResolver Instance = new PixivImageDnsResolver();

        protected override IEnumerable<IPAddress> UseDefaultDns()
        {
            return Enumerable.Range(136, 10).Select(i => IPAddress.Parse($"210.140.92.{i}"));
        }
    }
}