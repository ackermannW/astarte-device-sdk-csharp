/*
 * This file is part of Astarte.
 *
 * Copyright 2023 SECO Mind Srl
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * SPDX-License-Identifier: Apache-2.0
 */

namespace AstarteDeviceSDKCSharp.Protocol.AstarteEvents
{
    public class AstarteAggregateDatastreamEvent : AstarteGenericAggregateEvent
    {
        private readonly DateTime _timestamp;
        private readonly string _interfacePath;

        public AstarteAggregateDatastreamEvent(
      String interfaceName, Dictionary<String, Object> values, DateTime timestamp, string interfacePath) : base(interfaceName, values)
        {
            _timestamp = timestamp;
            _interfacePath = interfacePath;
        }

        public DateTime GetTimestamp()
        {
            return _timestamp;
        }

        public string GetPath()
        {
            return _interfacePath;
        }
    }
}
