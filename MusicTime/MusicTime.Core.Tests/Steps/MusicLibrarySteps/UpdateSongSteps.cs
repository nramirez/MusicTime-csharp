using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Queries;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.MusicLibrarySteps
{
    [Binding]
   public class UpdateSongSteps : StepBase
    {
        private int _songId;

        [Given(@"the following song is in my library")]
        public void GivenTheFollowingSongIsInMyLibrary(Table table)
        {
            Get<ICommandHandler<CreateSongCommand>>().Handle(table.CreateInstance<CreateSongCommand>());
           _songId = Get<IQueryHandler<FindAllQuery, List<Song>>>().Handle(new FindAllQuery()).First().Id;
        }
        [When(@"I update this song information as follows")]
        [When(@"he tries to update this song information as follows")]
        public void WhenIUpdateThisSongInformationAsFollows(Table table)
        {
            var command = table.CreateInstance<UpdateSongCommand>();
            command.Id = _songId;
            try
            {
                Get<ICommandHandler<UpdateSongCommand>>().Handle(command);
            }
            catch (ValidationException e)
            {
                SetValidationException(e);
            }
            catch (UnauthorizedAccessException e)
            {
                SetUnauthorizedAccessException(e);
            }
        
        }

        


        protected UpdateSongSteps(StepContext stepContext) : base(stepContext)
        {
        }
    }
}
