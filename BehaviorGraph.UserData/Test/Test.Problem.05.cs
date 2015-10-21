﻿/*******************************************************************************
 * Copyright (c) 2015 Bo Kang
 *   
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *  
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *******************************************************************************/

using MathCog;

namespace MathCogUserData
{
    using NUnit.Framework;

    [TestFixture]
    public partial class ProblemAuthoringModelTest
    {
        /*
         * Given an equation 2y+2x-y+2x+4=0, graph this equation's corresponding shape?
         * What is the slope of this line? 
         */
        [Test]
        public void Test_Problem_05()
        {
            var graph = BehaviorUserModelLoader.Instance.LoadProblem(5);
            //Assert.True(graph.Nodes.Count == 7);
            Assert.True(graph.SolvingCache.Count == 2);
            Reasoner.Instance.Reset();
        }
    }
}
