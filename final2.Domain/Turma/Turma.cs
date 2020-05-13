namespace final2.Domain.Turmas
{
    using final2.Domain.ValueObjects;
    using System;

    public class Turma : Entity, IAggregateRoot
    {
        public virtual int TurmaId { get; protected set; }
        public virtual int Nome { get; protected set; }
        public virtual List<Aluno> Alunos { get; protected set; }
        public virtual List<Disciplina> Disciplinas { get; protected set; }

        protected Turma()
        {
            Transactions = new TransactionCollection();
        }

        public Turma(Guid customerId)
            : this()
        {
            CustomerId = customerId;
        }

        public void Deposit(Credit credit)
        {
            Transactions.Add(credit);
        }

        public void Withdraw(Debit debit)
        {
            if (Transactions.GetCurrentBalance() < debit.Amount)
                throw new InsuficientFundsException($"The account {Id} does not have enough funds to withdraw {debit.Amount}.");

            Transactions.Add(debit);
        }

        public void Close()
        {
            if (Transactions.GetCurrentBalance() > 0)
                throw new TurmaCannotBeClosedException($"The account {Id} can not be closed because it has funds.");
        }

        public Amount GetCurrentBalance()
        {
            return Transactions.GetCurrentBalance();
        }
    }
}
