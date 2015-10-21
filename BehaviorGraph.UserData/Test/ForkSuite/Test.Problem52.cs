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
    /*
     * Problem 51: Given two points B(3,6) and C(7,3), 
     * what is the distance between these two points? 
     * (Use notation d to represent distance)
     */
    [TestFixture]
    public partial class ProblemAuthoringModelTest
    {
        [Test]
        public void Test_Problem_52()
        {
            var graph = BehaviorUserModelLoader.Instance.LoadProblem(52);
            Assert.True(graph.SolvingCache.Count == 2);

            Reasoner.Instance.Reset();
        }
    }
}
