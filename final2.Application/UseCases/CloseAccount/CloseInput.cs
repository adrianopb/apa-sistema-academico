namespace final2.Application.UseCases.CloseAccount
{
    using System;
    public class CloseInput
    {
        public Guid AccountId { get; private set; }
        public CloseInput(Guid guid)
        {
            this.AccountId = guid;
        }
    }
}
