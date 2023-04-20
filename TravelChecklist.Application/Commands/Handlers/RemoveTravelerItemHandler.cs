﻿using TravelChecklist.Application.Exceptions;
using TravelChecklist.Domain.Repositories;
using TravelChecklist.Shared.Abstractions.Commands;

namespace TravelChecklist.Application.Commands.Handlers
{
    internal sealed class RemoveTravelerItemHandler : ICommandHandler<RemoveTravelerItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public RemoveTravelerItemHandler(ITravelerCheckListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(RemoveTravelerItem command)
        {
            var travelerCheckingList = await _repository.GetAsync(command.TravelerCheckListId);

            if (travelerCheckingList is null)
            {
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);
            }

            travelerCheckingList.RemoveItem(command.Name);

            await _repository.UpdateAsync(travelerCheckingList);
        }
    }
}
