﻿namespace final2.WebApi.UseCases.Withdraw
{
    using System;
    public class WithdrawRequest
    {
        public Guid AccountId { get; set; }
        public Double Amount { get; set; }
    }
}