﻿namespace final2.Application.UseCases.GetAccountDetails
{
    using System;
    public class GetAccountDetailsInput
    {
        public Guid AccountId { get; private set; }
        public GetAccountDetailsInput(Guid accountId)
        {
            this.AccountId = accountId;
        }
    }
}
