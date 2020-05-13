﻿namespace final2.Application.UseCases.GetAccountDetails
{
    using System.Threading.Tasks;
    using final2.Application.Repositories;
    using final2.Application.Outputs;

    public class GetAccountDetailsInteractor : IInputBoundary<GetAccountDetailsInput>
    {
        private readonly IAccountReadOnlyRepository accountReadOnlyRepository;
        private readonly IOutputBoundary<AccountOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public GetAccountDetailsInteractor(
            IAccountReadOnlyRepository accountReadOnlyRepository,
            IOutputBoundary<AccountOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.accountReadOnlyRepository = accountReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(GetAccountDetailsInput input)
        {
            var account = await accountReadOnlyRepository.Get(input.AccountId);
            if (account == null)
            {
                outputBoundary.Populate(null);
                return;
            }

            AccountOutput output = outputConverter.Map<AccountOutput>(account);
            outputBoundary.Populate(output);
        }
    }
}
