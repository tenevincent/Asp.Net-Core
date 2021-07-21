using MediatR;
using PrismDryIocMediatR.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrismDryIocMediatR.Handlers
{
    public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand, string>
    {
        public Task<string> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult("The command has handled");
        }
    }
}
