﻿using System.Collections.Generic;
using MusicTime.Core.Abstract.Authorization;
using MusicTime.Core.Abstract.Handlers.Commands;
using MusicTime.Core.Abstract.Handlers.Queries;
using MusicTime.Core.Concrete.Commands;
using MusicTime.Core.Concrete.Entities;
using MusicTime.Core.Concrete.Queries;
using MusicTime.Core.Enumerations;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MusicTime.Core.Tests.Steps.MusicLibrarySteps
{
    [Binding]
    public class AddSongSteps :StepBase
    {
        [Given(@"I have the '(.*)' role")]
        public void GivenIHaveTheRole(Role role)
        {
            Get<ISession>().CurrentUserRole = role;
        }
        [When(@"I add a new song with the following information")]
        public void WhenIAddANewSongWithTheFollowingInformation(Table table)
        {
            var command = table.CreateInstance<CreateSongCommand>();
            Get<ICommandHandler<CreateSongCommand>>().Handle(command);
        }
        [Then(@"the music library should be as follows")]
        public void ThenTheMusicLibraryShouldBeAsFollows(Table table)
        {
            var musicLibrary = Get<IQueryHandler<FindAllQuery, List<Song>>>().Handle(new FindAllQuery());
            table.CompareToSet(musicLibrary);
        }


        public AddSongSteps(StepContext stepContext) : base(stepContext)
        {
        }
    }
}