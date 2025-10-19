using System;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Activities.Queries;

public class GetActivityList
{
    public class Query : IRequest<List<Activity>> { }
    public class Handler(AppDbContext context, ILogger<GetActivityList> logger) : IRequestHandler<Query, List<Activity>>
    {
        public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
        {
            try
            {
                // Simulate delay
                for (int i = 0; i < 10; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    await Task.Delay(1000, cancellationToken);
                    logger.LogInformation($"Delay {i} has completed");
                }
               
            }
            catch (TaskCanceledException)
            {
                // Handle the cancellation if needed
                logger.LogInformation("Task was cancelled");
            }
            return await context.Activities.ToListAsync(cancellationToken);
        }
    }
}
