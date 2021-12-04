// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Http;

namespace RESTFulSense.WebAssembly.Models
{
    public class UpgradeRequiredObjectResult : ObjectResult
    {
        public UpgradeRequiredObjectResult(object value) : base(value) =>
            StatusCode = StatusCodes.Status426UpgradeRequired;
    }
}