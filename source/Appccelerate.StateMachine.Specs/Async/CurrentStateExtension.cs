//-------------------------------------------------------------------------------
// <copyright file="CurrentStateExtension.cs" company="Appccelerate">
//   Copyright (c) 2008-2017 Appccelerate
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.StateMachine.Async
{
    using System.Threading.Tasks;
    using Appccelerate.StateMachine.AsyncMachine;

    public class CurrentStateExtension : AsyncExtensionBase<int, int>
    {
        public int CurrentState { get; private set; }

        public override Task SwitchedState(IStateMachineInformation<int, int> stateMachine, IState<int, int> oldState, IState<int, int> newState)
        {
            this.CurrentState = newState.Id;

            return Task.CompletedTask;
        }
    }
}