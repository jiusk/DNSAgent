﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace DnsAgent
{
    internal class Rules : List<Rule> {}

    internal class Rule
    {
        public Rule()
        {
            Pattern = "$^";
            Address = "127.0.0.1";
            NameServer = null;
            QueryTimeout = null;
            CompressionMutation = null;
        }

        /// <summary>
        ///     Regex pattern to match the domain name.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Pattern { get; set; }

        /// <summary>
        ///     IP Address for this domain name. IPv4 address will be returned as A record and IPv6 address as AAAA record.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///     The name server used to query about this domain name. If "Address" is set, this will be ignored.
        /// </summary>
        public string NameServer { get; set; }

        /// <summary>
        ///     Timeout for the query, in milliseconds. This overrides options.cfg. If "Address" is set, this will be ignored.
        /// </summary>
        public int? QueryTimeout { get; set; }

        /// <summary>
        ///     Whether to enable compression pointer mutation to query this name server. If "Address" is set, this will be
        ///     ignored.
        /// </summary>
        public bool? CompressionMutation { get; set; }
    }
}