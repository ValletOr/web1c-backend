﻿using Microsoft.AspNetCore.Mvc;
using web1c_backend.Models;
using web1c_backend.Constants;
using web1c_backend.Models.Entities;
using web1c_backend.Models.Http.Responses;
using web1c_backend.Models.Http.Params;
using web1c_backend.Services;

namespace web1c_backend.Controllers
{
    [Route("api/classes/debtors")]
    [ApiController]
    public class DebtorCardController : Web1cController
    {
        public DebtorCardController(Web1cDBContext context) : base(context)
        { }

        [HttpGet]
        public async Task<JsonResult> GetDebtorCards([FromQuery] GetParams getDebtorCardParams)
        {
            var sessionId = CheckSession(ConstValues.SESSION_ID);

            EntityWithRoute[]? foundData = null;
            if (sessionId != null)
            {
                foundData = await new DataBuilder(context).Build(new DebtorCardBuilderStrategy(), getDebtorCardParams);
                if (getDebtorCardParams.Type == 2 && foundData.Length != 0)
                {
                    await UpdateHistory(foundData.First(), (long) sessionId);
                }
            }

            var response = new DataResponse<EntityWithRoute>()
            {
                Result = foundData != null && foundData.Length != 0,
                Message = foundData != null ? "" : ConstValues.SESSION_NOT_FOUND,
                Data = foundData
            };

            return new JsonResult(response);
        }

    }
}
