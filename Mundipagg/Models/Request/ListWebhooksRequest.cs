﻿using Mundipagg.Models.Enums;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    /// <summary>
    /// List customers request
    /// </summary>
    public class ListWebhooksRequest : BaseListRequest
    {
        /// <summary>
        /// Filter by create date - Creation after this date
        /// </summary>
        public DateTime? CreatedSince { get; set; }

        /// <summary>
        /// Filter by create date - Creation before this date
        /// </summary>
        public DateTime? CreatedUntil { get; set; }

        /// <summary>
        /// Filter by status
        /// </summary>
        public WebhookStatusEnum? Status { get; set; }

        /// <summary>
        /// Webhook event type
        /// </summary>
        public WebhookEventEnum? WebhookEvent { get; set; }
    }
}