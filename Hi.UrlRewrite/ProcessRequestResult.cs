﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hi.UrlRewrite
{
    public class ProcessRequestResult
    {

        public ProcessRequestResult(RuleResult ruleResult, bool matchedAtLeastOneRule, List<RuleResult> processedResults)
        {
            this.OriginalUri = ruleResult.OriginalUri;
            this.HttpCacheability = ruleResult.HttpCacheability;
            this.RewrittenUri = ruleResult.RewrittenUri;
            this.StatusCode = ruleResult.StatusCode;
            this.MatchedAtLeastOneRule = matchedAtLeastOneRule;
            this.ProcessedResults = processedResults;
            this.Abort = ruleResult.Abort;
        }


        public Uri OriginalUri { get; set; }

        public HttpCacheability? HttpCacheability { get; set; }

        public Uri RewrittenUri { get; set; }

        public int? StatusCode { get; set; }

        public bool MatchedAtLeastOneRule { get; set; }

        public List<RuleResult> ProcessedResults { get; set; }

        public bool Abort { get; set; }
    }
}
