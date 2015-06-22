﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Queries;
using MusicTime.Core.Enumerations;
using Should;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.MusicLibrarySteps
{
    [Binding]
    public class AddSongSteps : StepBase
    {
        private IEnumerable<ValidationFailure> _errors;

        private UnauthorizedAccessException _exception;

        [Given(@"I have the '(.*)' role")]
        public void GivenIHaveTheRole(Role role)
        {
            Get<ISession>().CurrentUserRoles.Add(role);
        }

        [When(@"I add a new song with the following information")]
        public void WhenIAddANewSongWithTheFollowingInformation(Table table)
        {
            var command = table.CreateInstance<CreateSongCommand>();
            try
            {
                Get<ICommandHandler<CreateSongCommand>>().Handle(command);
            }
            catch (ValidationException e)
            {
                _errors = e.Errors;
            }
            catch (UnauthorizedAccessException e)
            {
                _exception = e;
            }
        }

        [Then(@"the music library should be as follows")]
        public void ThenTheMusicLibraryShouldBeAsFollows(Table table)
        {
            var musicLibrary = Get<IQueryHandler<FindAllQuery, List<Song>>>().Handle(new FindAllQuery());
            table.CompareToSet(musicLibrary);
        }

        [Then(@"I should see an unsuccessful add song error message '(.*)'")]
        public void ThenIShouldSeeAnUnsuccessfulAddSongErrorMessage(string message)
        {
            _errors.Any(e => e.ErrorMessage == message).ShouldBeTrue();
        }

        [Then(@"I should recived an not authorized exception")]
        public void ThenIShouldRecivedAnNoAuthorizedException()
        {
            _exception.ShouldNotBeNull();
        }

        public AddSongSteps(StepContext stepContext)
            : base(stepContext)
        {
        }
    }
}
